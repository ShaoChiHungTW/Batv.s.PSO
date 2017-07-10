using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R05546014洪紹綺FinalProject
{
    enum OptimizationType { Minimization, Maximization };

    //目標函式
    public delegate double ObjectiveFunction(double[] solution);
    class BAforCOP
    {
        //Property Set
        //參數參考paper設定
        //蝙蝠數量
        int numberOfBats = 50;
        //獵物數量(問題維度)
        int numberOfPreys;
        //速度
        double[][] speedOfBats;
        //頻率
        double[] frequencyOfBats;
        //波長
        double[] wavelengthOfBats;
        //Loudness 一開始要設最大值
        double[] loudnessA;
        //脈衝發射率[0,1] 一開始要最小
        //0代表完全沒射;1發射max
        double[] pulserateOfBats;

        double fMax = 100.0;
        double fMin = 0.0;

        double averageLoudness;

        double beta;   //0<=b<=1
        double alpha=0.9;   //類似退火法中的cooling Factor 0<=a<=1
        double gama=0.9;
        double epslon;     //-1,1  

        double[] lowerBound;
        double[] upperBound;

        double iterationAverage;
        double iterationBest;

        //Xi
        double[][] solutionsX;
        double[] objectives;

        //X*
        double soFarTheBestObjective;
        double[] soFarTheBestSolution;

        //RandomAcceptSolution
        double[][] localSolution;
        double[] localBestValue;
        double rndObjective;

        double[] xRandom;
        double[] xOriginal;

        int iterationCount;
        int iterationLimit = 100;

        OptimizationType optimizationTpe; // = OptimizationType.Minimization;
        ObjectiveFunction objFunction;

        Random rnd = new Random();

        #region Properties
        [Category("BA Parameters"), Description("蝙蝠數量")]
        public int NumberOfBats
        {
            get
            {
                return numberOfBats;
            }

            set
            {
                numberOfBats = value;
            }
        }
        [Browsable(false)]
        public int NumberOfPreys
        {
            get
            {
                return numberOfPreys;
            }

            set
            {
                numberOfPreys = value;
            }
        }
        [Browsable(false)]
        public double IterationAverage
        {
            get
            {
                return localBestValue.Average();
            }
        }
        [Browsable(false)]
        public double IterationBest
        {
            get
            {
                return localBestValue.Min();
            }
        }
        [Browsable(false)]
        public double[][] SolutionsX
        {
            get
            {                
                return solutionsX;
            }
            
        }
        [Browsable(false)]
        public double SoFarTheBestObjective
        {
            get
            {
                return soFarTheBestObjective;
            }
        }
        [Browsable(false)]
        public int IterationCount
        {
            get
            {
                return iterationCount;
            }
        }
        [Category("Execution"), Description("演化代次上限")]
        public int IterationLimit
        {
            get
            {
                return iterationLimit;
            }

            set
            {
                iterationLimit = value;
            }
        }

        [Browsable(false)]
        public double[] SoFarTheBestSolution
        {
            get
            {
                return soFarTheBestSolution;
            }

        }

        [Category("BA Parameters"), Description("聲音遞減值，介於0到1之間")]
        public double Alpha
        {
            get
            {
                return alpha;
            }

            set
            {
                if (alpha >= 0 && alpha <= 1)
                {
                    alpha = value;
                }
            }
        }

        [Category("BA Parameters"), Description("影響脈衝發射率，介於0到1之間")]
        public double Gama
        {
            get
            {
                return gama;
            }

            set
            {
                if (gama >= 0 && gama <= 1)
                {
                    gama = value;
                }
            }
        }

        #endregion

        public BAforCOP(int numberOfPreys, double[] upBound, double[] lowBound, OptimizationType type, ObjectiveFunction objFun)
        {
            this.numberOfPreys = numberOfPreys;
            lowerBound = lowBound;
            upperBound = upBound;
            optimizationTpe = type;  //完全讓constructor決定就好
            objFunction = objFun;

            soFarTheBestSolution = new double[numberOfPreys];
        }

        

        public void reset()
        {
            iterationCount = 0;
            iterationAverage = 0.0;

            //allocate memory
            speedOfBats = new double[numberOfBats][];
            frequencyOfBats = new double[numberOfBats];
            wavelengthOfBats = new double[numberOfBats];
            loudnessA = new double[numberOfBats];
            solutionsX = new double[numberOfBats][];
            localSolution = new double[numberOfBats][];
            pulserateOfBats = new double[numberOfBats];

            for( int i =0 ; i < numberOfBats;i++)
            {
                speedOfBats[i] = new double[numberOfPreys];                
                solutionsX[i] = new double[numberOfPreys];
                localSolution[i] = new double[numberOfPreys];               
            }

            objectives = new double[numberOfBats];
            soFarTheBestSolution = new double[numberOfBats];
            localBestValue = new double[numberOfBats];

            xRandom = new double[numberOfPreys];
            xOriginal = new double[numberOfPreys];

            soFarTheBestObjective = double.MaxValue;
           
            Initialization();
            
        }

        public void Initialization()
        {

            for (int i = 0; i < numberOfBats; i++)
            {
                //響度一開始隨機1~2
                loudnessA[i] = rnd.Next(1, 3);
                //發射率一開始隨機0~1
                pulserateOfBats[i] = rnd.Next(0, 2);
                //一開始隨機分配頻率
                frequencyOfBats[i] = rnd.Next(0, 100);
                //波長=音速340m/soFarTheBestSolution /頻率
                wavelengthOfBats[i] = 340 / frequencyOfBats[i];

                for (int j = 0; j < numberOfPreys; j++)
                {
                    //蝙蝠起始速度
                    speedOfBats[i][j] = 0.0;
                    //內插法
                    solutionsX[i][j] = lowerBound[j] + rnd.NextDouble() * (upperBound[j] - lowerBound[j]);
                }
                localSolution[i] = solutionsX[i];
            }

            for (int i = 0; i < numberOfBats; i++)
            {
                //Compute Objective
                localBestValue[i] = objFunction(localSolution[i]);
                objectives[i] = objFunction(solutionsX[i]);

                if (localBestValue[i] < soFarTheBestObjective)
                {
                    soFarTheBestObjective = localBestValue[i];
                    for (int j = 0; j < numberOfPreys; j++)
                    {
                        soFarTheBestSolution[j] = localSolution[i][j];
                    }
                }
            }
        }

        public void RunOneIteration()
        {              
            double rand =0.0 ;
            //double p = 0.0;
            //Generate new solutions by adjusting frequency
            //Update 蝙蝠速度位置和解
            for (int i = 0; i < numberOfBats; i++)
            {
                for (int j = 0; j < numberOfPreys; j++)
                {
                    beta = rnd.NextDouble();
                    //2頻率
                    frequencyOfBats[i] = fMin + (fMax - fMin) * beta;
                    //3速度
                    speedOfBats[i][j] = speedOfBats[i][j] + frequencyOfBats[i] * (solutionsX[i][j] - soFarTheBestSolution[j]);
                    //4位置
                    solutionsX[i][j] = solutionsX[i][j] + speedOfBats[i][j];

                    //Check UpperBound、LowerBound
                    if (solutionsX[i][j] > upperBound[j])
                    {
                        solutionsX[i][j] = lowerBound[j] + rnd.NextDouble() * (upperBound[j] - lowerBound[j]);
                    }
                    else if (solutionsX[i][j] < lowerBound[j])
                    {
                        solutionsX[i][j] = lowerBound[j] + rnd.NextDouble() * (upperBound[j] - lowerBound[j]);                      
                    }
                }
            }

            //RandomWalk
            //Select a solution among the best solutions
            //Generate a local solution around the selected best solution
            for (int i = 0; i < numberOfBats; i++)
            {
                rand = rnd.NextDouble();
                if (rand > pulserateOfBats[i])                    
                {                  
                    for (int j = 0; j < numberOfPreys; j++)
                    {
                        xOriginal[j] = soFarTheBestSolution[j];
                        if (xOriginal[j] > upperBound[j])
                        {
                            xOriginal[j] = lowerBound[j] + rnd.NextDouble() * (upperBound[j] - lowerBound[j]);
                        }
                        else if (xOriginal[j] < lowerBound[j])
                        {
                            xOriginal[j] = lowerBound[j] + rnd.NextDouble() * (upperBound[j] - lowerBound[j]);
                        }
                    }
                }
                objectives[i] = objFunction(solutionsX[i]);
            }

            for (int i = 0; i < numberOfBats; i++)
            { 
                for (int k = 0; k < numberOfPreys; k++ )
                {
                    epslon = 2 * rnd.NextDouble() - 1;
                    averageLoudness = loudnessA.Average();
                    xRandom[k] = xOriginal[k] + epslon * averageLoudness;

                    if( xRandom[k] > upperBound[k])
                    {
                        xRandom[k] = lowerBound[k] + rnd.NextDouble() * (upperBound[k] - lowerBound[k]);
                    }
                    else if( xRandom[k] < lowerBound[k])
                    {
                        xRandom[k] = lowerBound[k] + rnd.NextDouble() * (upperBound[k] - lowerBound[k]);
                    }
                }
                localBestValue[i] = objFunction(xOriginal);
                rndObjective = objFunction(xRandom);
                if (rand < loudnessA[i] && rndObjective < localBestValue[i])
                {
                    //accept this random solution
                    for( int z = 0; z < numberOfPreys; z++ )
                    {           
                        localSolution[i][z] = xRandom[z];
                    }
                    //gama = rnd.NextDouble();
                    //alpha = rnd.NextDouble();
                    //響度減少
                    loudnessA[i] = loudnessA[i] * alpha;
                    //發射率增加
                    pulserateOfBats[i] = pulserateOfBats[i] * (1 - Math.Exp(-1 * gama * this.iterationCount));
                }
                
                if ( rndObjective < soFarTheBestObjective)
                {
                    soFarTheBestObjective = rndObjective;
                    soFarTheBestSolution = xRandom;
                }
                if( rndObjective > soFarTheBestObjective)
                {
                    soFarTheBestObjective = localBestValue[i];
                    soFarTheBestSolution = xOriginal;
                }
            }
            #region wrong
            //for (int i = 0; i < numberOfBats; i++)
            //{
            //    for (int j = 0; j < numberOfPreys; j++)
            //    {
            //        p = rnd.NextDouble();
            //        if (p >= 0.5)
            //        {
            //            epslon = 1;
            //        }
            //        else
            //        {
            //            epslon = -1;
            //        }
            //        rand = rnd.NextDouble();
            //        //select a solution among the best solutions
            //        //generate a local solution around the selected best solution
            //        if (rand > pulserateOfBats[i][j])
            //        {
            //            averageLoudness = loudnessA[i].Average();
            //            solutionsX[i][j] = solutionsX[i][j] + epslon * averageLoudness;
            //        }

            //        //generate a new solution by flying randomly

            //    }
            //}
            //更新蝙蝠的Loudness越靠近越小,rate越靠近越大
            //for (int i = 0; i < numberOfBats + 1; i++)
            //{
            //    for (int j = 0; j < numberOfPreys; j++)
            //    {                   
            //        if (rand < loudnessA[i] && objectives[i] < soFarTheBestObjective)
            //        {
            //            gama = rnd.NextDouble();
            //            alpha = rnd.NextDouble();
            //            loudnessA[i] = loudnessA[i] * alpha;
            //            pulserateOfBats[i] = pulserateOfBats[i] * (1 - Math.Exp(-1 * gama * this.iterationCount));
            //        }
            //    }
            //} 
            #endregion

            ComputeObjectiveAndUpdateSoFarTheBest();
            iterationCount++;
        }

        private void ComputeObjectiveAndUpdateSoFarTheBest()
        {
            for (int i = 0; i < numberOfBats; i++)
            {
                //Compute Objective              
                objectives[i] = objFunction(solutionsX[i]);
                //找到一個so far the best之後 更新每隻蝙蝠的位置
                    if (objectives[i] < localBestValue[i])
                    {
                        localBestValue[i] = objectives[i];

                        for (int j = 0; j < numberOfPreys; j++)
                        {
                            localSolution[i][j] = solutionsX[i][j];
                        }
                    }

                    if (localBestValue[i] < soFarTheBestObjective)
                    {
                        soFarTheBestObjective = localBestValue[i];
                        for (int j = 0; j < numberOfPreys; j++)
                        {
                            soFarTheBestSolution[j] = solutionsX[i][j];
                        }
                    }
            }
        }
      }
   }

