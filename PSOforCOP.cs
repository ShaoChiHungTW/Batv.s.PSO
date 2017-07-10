using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using R05546014洪紹綺FinalProject;

namespace R05546014洪紹綺Ass11
{

    enum OptimizationType { Minimization , Maximization };

    //目標函式
    public delegate double ObjectiveFunction( double[] solution );
    

    class PSOforCOP
    {
        //set property
        
        int numberOfParticles = 50;  //鳥的數量
        int numberOfVariables;   //城市數量

        int iterationCount;
        int iterationLimit = 100;

        OptimizationType optimizationTpe; // = OptimizationType.Minimization;
        ObjectiveFunction objFunction;

        double[] LowerBound;
        double[] UpperBound;

        double[][] V;  //速度

        double congnitionFactor = 0.5;  //paricle movement follows its own search experience
        double socialFactor = 0.5;  //particle movement follows the swam search experience
        Random rnd = new Random();

        public PSOforCOP(int numberOfVariables, double[] upBound, double[] lowBound , ObjectiveFunction objFun)
        {
            
            this.numberOfVariables = numberOfVariables;
            LowerBound = lowBound;
            UpperBound = upBound;
            //this.optimizationTpe = type;  //完全讓constructor決定就好
            objFunction = objFun;

            SoFarTheBestSolution = new double[numberOfVariables];
        }
        

        double IterationAverage ;
        double IterationBest;
       
        double[][] solutions;
        double[] objectives;

        double[][] IndividualLocalSolutions;
        double[] IndividualBestValue;

        double SoFarTheBestObjectives;
        double[] SoFarTheBestSolution;
        //private int dimension;
        //private R05546014洪紹綺FinalProject.OptimizationType opty;
        //private Func<double[], double> getObjectiveValue;

        #region Properties

        [Category("PSO Parameters"), Description("粒子團成員數量")]
        public int NumberOfParticles
        {
            get
            {
                return numberOfParticles;
            }

            set
            {
                numberOfParticles = value;
            }
        }

        [Browsable(false)]
        public double[][] Solutions
        {
            get
            {
                return solutions;
            }

        }
        [Category("PSO Parameters"), Description("社交經歷參考係數")]
        public double SocialFactor
        {
            get
            {
                return socialFactor;
            }

            set
            {
                socialFactor = value;
            }
        }
        [Category("PSO Parameters"), Description("自我認知參考係數")]
        public double CongnitionFactor
        {
            get
            {
                return congnitionFactor;
            }

            set
            {
                congnitionFactor = value;
            }
        }

        [Browsable(false)]
        public double IterationAverage1
        {
            get
            {               
                    return IndividualBestValue.Average();             
            }

           
        }

        [Browsable(false)]
        public double IterationBest1
        {
            get
            {
                //if( optimizationTpe == OptimizationType.Minimization)
                    return IndividualBestValue.Min();

                //if (optimizationTpe == OptimizationType.Minimization)
                //    return IndividualBestValue.Max();

                //else
                //    return double.NaN;

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

        [Browsable(false)]
        public double SoFarTheBestObjectives1
        {
            get
            {
                return SoFarTheBestObjectives;
            }

        }

        [Category("Execution"), Description("演化代次上限Iteration Limit")]
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
        public double[] SoFarTheBestSolution1
        {
            get
            {
                return SoFarTheBestSolution;
            }
        }

        #endregion

        public void reset()
        {
            iterationCount = 0;

            //allocate correct memory
            solutions = new double[numberOfParticles][];
            IndividualLocalSolutions = new double[numberOfParticles][];
            V = new double[numberOfParticles][];
            SoFarTheBestSolution = new double[numberOfParticles];
            IndividualBestValue = new double[numberOfParticles];

            //for( int i = 0; i < solutions.Length; i++)
            for ( int i = 0; i < numberOfParticles; i ++ )
            {
                solutions[i] = new double[numberOfVariables];

                IndividualLocalSolutions[i] = new double[numberOfVariables];

                V[i] = new double[numberOfVariables];

            }

            objectives = new double[numberOfParticles];

            //if (optimizationTpe == OptimizationType.Minimization)
            SoFarTheBestObjectives = double.MaxValue;

            //if (optimizationTpe == OptimizationType.Maximization)
            //SoFarTheBestObjectives = double.MinValue;



            Initialization();
        }

        public void Initialization()
        {
            //初始化所有元素

            //內插法
            for (int i = 0; i < numberOfParticles; i++)
            {
                for (int j = 0; j < numberOfVariables; j++)
                {
                    //LowerBounnd 跟 variable有關
                    solutions[i][j] = LowerBound[j] + rnd.NextDouble()* (UpperBound[j] - LowerBound[j]) ;
                }

                IndividualLocalSolutions[i] = solutions[i];

                //Compute Objective
                IndividualBestValue[i] = objFunction(IndividualLocalSolutions[i]);
                objectives[i] = objFunction(solutions[i]);


                //如果我的比大家好,就以我的最好做為大家最好的
                if (IndividualBestValue[i] < objectives[i])
                {
                    objectives[i] = IndividualBestValue[i];
                    solutions[i] = IndividualLocalSolutions[i];
                }
                    if (objectives[i] < SoFarTheBestObjectives)
                    {
                        SoFarTheBestObjectives = objectives[i];

                        for (int j = 0; j < numberOfVariables; j++)
                        {
                            SoFarTheBestSolution[j] =solutions[i][j];
                        }
                    }
            

        //    else if (optimizationTpe == OptimizationType.Maximization)
        //    {
        //        if (IndividualBestValue[i] > objectives[i])
        //    {
        //        objectives[i] = IndividualBestValue[i];
        //    }

        //    if (objectives[i] > SoFarTheBestObjectives)
        //    {
        //        SoFarTheBestObjectives = objectives[i];

        //        for (int j = 0; j < numberOfVariables; j++)
        //        {
        //            SoFarTheBestSolution[i] = solutions[i][j];
        //        }
        //    }
        //}


             }
            
        }

        public void RunOneIteration()
        {
            ParticaleMoveToNewPosition();
            ComputeObjectiveAndUpdateSoFarTheBest();

            iterationCount++;

            
        }



        private void ComputeObjectiveAndUpdateSoFarTheBest()
        {
            for( int i = 0; i < numberOfParticles; i++  )
            {
                //Compute Objective
                IndividualBestValue[i] = objFunction(IndividualLocalSolutions[i]);
                objectives[i] = objFunction(solutions[i]);

                if (optimizationTpe == OptimizationType.Minimization)
                {
                    //改成現在最好的
                    if ( objectives[i]< IndividualBestValue[i])
                    {
                        IndividualBestValue[i] = objectives[i];

                        for (int j = 0; j < numberOfVariables; j++)
                        {
                          IndividualLocalSolutions[i] = solutions[i];
                        }
                    
                    }

                    if (IndividualBestValue[i] < SoFarTheBestObjectives )
                    {
                        SoFarTheBestObjectives = IndividualBestValue[i];

                        for (int j = 0; j < numberOfVariables; j++)
                        {
                            SoFarTheBestSolution[j] = solutions[i][j];
                        }
                    }
            }

            //    else if (optimizationTpe == OptimizationType.Maximization)
            //{
            //    if (IndividualBestValue[i] > objectives[i])
            //    {
            //        objectives[i] = IndividualBestValue[i];
            //        solutions[i] = IndividualLocalSolutions[i];
            //    }

            //    if (objectives[i] > SoFarTheBestObjectives)
            //    {

            //        SoFarTheBestObjectives = objectives[i];

            //        for (int j = 0; j < numberOfVariables; j++)
            //        {
            //            SoFarTheBestSolution[i] = solutions[i][j];
            //        }

            //    }
            //}
          }
        }

        private void ParticaleMoveToNewPosition()
        {

            //更新位置與速度
            for (int i=0; i < numberOfParticles; i++ )
            {
                double a = congnitionFactor * rnd.NextDouble();  //我自己以前看過最好的權重
                double b = socialFactor * rnd.NextDouble();    //團體裡看過最好之權重

                for ( int j = 0; j < numberOfVariables; j++ )
                {
                    //(我曾經最好的-現在) + (團體最好的-現在)
                    V[i][j] = a * (IndividualLocalSolutions[i][j] - solutions[i][j]) + b * (SoFarTheBestSolution[j] - solutions[i][j]);

                    solutions[i][j] = solutions[i][j] + V[i][j];

                    if( solutions[i][j] > UpperBound[j] )
                    {
                        solutions[i][j] = UpperBound[j];
                    }

                    if( solutions[i][j] < LowerBound[j] )
                    {
                        solutions[i][j] = LowerBound[j];
                    }

                    else
                    {
                        solutions[i][j] = solutions[i][j];
                    }

                }
            }
        }
    }
}
