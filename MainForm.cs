using COP;
using R05546014洪紹綺Ass11;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace R05546014洪紹綺FinalProject
{
    public partial class MainForm : Form
    {
        COPBenchmark theProblem;
        //需要一個物件,跟TSP直接是一個靜態類別不一樣

        BAforCOP BAsolver;
        PSOforCOP PSOsolver;

        public MainForm()
        {
            InitializeComponent();

            btnBAcreate.Enabled = false;
            btnBAReset.Enabled = false;
            btnBARunOneIteration.Enabled = false;
            btnBARunToEnd.Enabled = false;

            btnPSOcreate.Enabled = false;
            btnPSOReset.Enabled = false;
            btnPSORunOneIteration.Enabled = false;
            btnPSORunToEnd.Enabled = false;
        }

        #region BA
        private void btnCreateBASOLVER_Click(object sender, EventArgs e)
        {
            OptimizationType opty = theProblem.OptimizationGoal == COP.OptimizationType.Minimization ? OptimizationType.Minimization : OptimizationType.Maximization;
            BAsolver = new BAforCOP(theProblem.Dimension, theProblem.UpperBound, theProblem.LowerBound, opty, theProblem.GetObjectiveValue);

            propertyGridBA.SelectedObject = BAsolver;
            btnBAReset.Enabled = true;            
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            BAsolver.reset();

            //reset objective graphics on panel2
            theProblem.DisplayObjectiveGraphics(splitContainer2.Panel2);
            theProblem.DisplaySolutionsOnGraphics(BAsolver.SolutionsX);


            btnBARunOneIteration.Enabled = true;
            btnBARunToEnd.Enabled = true;

            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();
            chart1.Series[2].Points.Clear();

            //foreach (Series p in chart1.Series)
            //{
            //    p.Points.Clear();
            //}
        }

        private void btnRunOneIteration_Click(object sender, EventArgs e)
        {
            //call thesolver.Runoneiteration();
            BAsolver.RunOneIteration();

            //update series
            chart1.Series[0].Points.AddXY(BAsolver.IterationCount, BAsolver.IterationAverage);
            chart1.Series[1].Points.AddXY(BAsolver.IterationCount, BAsolver.IterationBest);
            chart1.Series[2].Points.AddXY(BAsolver.IterationCount, BAsolver.SoFarTheBestObjective);

            theProblem.DisplaySolutionsOnGraphics(BAsolver.SolutionsX);
            //update chart
            chart1.Update();
            labelBAbestObjective.Text = "So Far The Best Objective:"+ Convert.ToString(BAsolver.SoFarTheBestObjective);
            labelBAbestObjective.Refresh();
            //寫出解
            string sol = " ";
            for( int i = 0; i < theProblem.Dimension; i++ )
            {
                sol += "[ " + BAsolver.SoFarTheBestSolution[i] + " ] ";
            }
            listBoxBA.Items.Add(sol);
        }

        private void btnRunToEnd_Click(object sender, EventArgs e)
        {          
            while( BAsolver.IterationCount < BAsolver.IterationLimit )
            {
                BAsolver.RunOneIteration();
                
                //update series
                chart1.Series[0].Points.AddXY(BAsolver.IterationCount, BAsolver.IterationAverage);
                chart1.Series[1].Points.AddXY(BAsolver.IterationCount, BAsolver.IterationBest);
                chart1.Series[2].Points.AddXY(BAsolver.IterationCount, BAsolver.SoFarTheBestObjective);

                theProblem.DisplaySolutionsOnGraphics(BAsolver.SolutionsX);
                labelBAbestObjective.Text = "So Far The Best Objective:"+ Convert.ToString(BAsolver.SoFarTheBestObjective);
                labelBAbestObjective.Refresh();
                //寫出解
                string sol = " ";
                for (int i = 0; i < theProblem.Dimension; i++)
                {
                    sol += "[ " + BAsolver.SoFarTheBestSolution[i] + " ] ";
                }
                listBoxBA.Items.Add(sol);
                listBoxBA.Refresh();
                //update chart
                chart1.Update();

                if( BAsolver.IterationCount == BAsolver.IterationLimit)
                {
                    MessageBox.Show("Iteration Limit : " + BAsolver.IterationLimit, "Bat Algorithm has been completed.");
                }
            }            
        }
        #endregion

        #region PSO
        private void btnPSOcreate_Click(object sender, EventArgs e)
        {
            OptimizationType opty = theProblem.OptimizationGoal == COP.OptimizationType.Minimization ? OptimizationType.Minimization : OptimizationType.Maximization;
            PSOsolver = new PSOforCOP(theProblem.Dimension, theProblem.UpperBound, theProblem.LowerBound, theProblem.GetObjectiveValue);
            propertyGridPSO.SelectedObject = PSOsolver;
            btnPSOReset.Enabled = true;
            
        }

        private void btnPSOReset_Click(object sender, EventArgs e)
        {
            PSOsolver.reset();

            //reset objective graphics on panel2
            theProblem.DisplayObjectiveGraphics(splitContainer2.Panel2);
            theProblem.DisplaySolutionsOnGraphics(PSOsolver.Solutions);

            btnPSORunOneIteration.Enabled = true;
            btnPSORunToEnd.Enabled = true;

            chart1.Series[3].Points.Clear();
            chart1.Series[4].Points.Clear();
            chart1.Series[5].Points.Clear();

            //foreach (Series p in chart1.Series)
            //{         
            //    p.Points.Clear();
            //}
        }

        private void btnPSORunOneIteration_Click(object sender, EventArgs e)
        {
            //call thesolver.Runoneiteration();
            PSOsolver.RunOneIteration();

            //update series
            chart1.Series[3].Points.AddXY(PSOsolver.IterationCount,PSOsolver.IterationAverage1);
            chart1.Series[4].Points.AddXY(PSOsolver.IterationCount,PSOsolver.IterationBest1);
            chart1.Series[5].Points.AddXY(PSOsolver.IterationCount,PSOsolver.SoFarTheBestObjectives1);
            theProblem.DisplaySolutionsOnGraphics(PSOsolver.Solutions);
            labelPSObestObjective.Text = "So Far The Best Objective:"+ Convert.ToString(PSOsolver.SoFarTheBestObjectives1);
            labelPSObestObjective.Refresh();
            //寫出解
            string sol = " ";
            for (int i = 0; i < theProblem.Dimension; i++)
            {
                sol += "[ " + PSOsolver.SoFarTheBestSolution1[i] + " ] ";
            }
            listBoxPSO.Items.Add(sol);
            //update chart
            chart1.Update();
        }

        private void btnPSORunToEnd_Click(object sender, EventArgs e)
        {
            while(PSOsolver.IterationCount < PSOsolver.IterationLimit)
            {
                //call thesolver.Runoneiteration();
                PSOsolver.RunOneIteration();
                //update series
                chart1.Series[3].Points.AddXY(PSOsolver.IterationCount, PSOsolver.IterationAverage1);
                chart1.Series[4].Points.AddXY(PSOsolver.IterationCount, PSOsolver.IterationBest1);
                chart1.Series[5].Points.AddXY(PSOsolver.IterationCount, PSOsolver.SoFarTheBestObjectives1);
                theProblem.DisplaySolutionsOnGraphics(PSOsolver.Solutions);
                labelPSObestObjective.Text = "So Far The Best Objective:" + Convert.ToString(PSOsolver.SoFarTheBestObjectives1);
                labelPSObestObjective.Refresh();
                //寫出解
                string sol = " ";
                for (int i = 0; i < theProblem.Dimension; i++)
                {
                    sol += "[ " + PSOsolver.SoFarTheBestSolution1[i] + " ] ";
                }
                listBoxPSO.Items.Add(sol);
                listBoxPSO.Refresh();
                //update chart
                chart1.Update();

                if (PSOsolver.IterationCount == PSOsolver.IterationLimit )
                {
                    MessageBox.Show("Iteration Limit : " + PSOsolver.IterationLimit, "PSO has been completed.");
                }
            }
        }
        #endregion

        //讀檔
        private void tsBtnOpenCOP_Click(object sender, EventArgs e)
        {
            //if (dlgOpen.ShowDialog() == DialogResult.OK)
            //{
                //清除之前的資料
                foreach (Series p in chart1.Series)
                {
                    p.Points.Clear();
                }
                listBoxBA.Items.Clear();
                listBoxPSO.Items.Clear();
                labelBAbestObjective.Text = "So Far The Best Objective: ";
                labelPSObestObjective.Text = "So Far The Best Objective: ";
                //read in Problem
                //.用類別名稱呼叫靜態函式獲得一個物件
                theProblem = COPBenchmark.LoadAProblemFromAFile();
                //Show problem set on panel
                theProblem.DisplayOnPanel(splitContainer1.Panel1);
                theProblem.DisplayObjectiveGraphics(splitContainer2.Panel2);
                if (theProblem == null)
                {
                    return;
                }
                //draw thesolver.solution on panel
                //theProblem.DisplaySolutionsOnGraphics(BAsolver.Solutions);

                btnBAcreate.Enabled = true;
                btnPSOcreate.Enabled = true;

                MessageBox.Show("You could choose Bat Algorithm or Particle Swarm Optimization to solve your problem.", "For Your COP Benchmark");
            //}
            //if( dlgOpen.ShowDialog() == DialogResult.Cancel)
            //{
            //    return;
            //}
            //if( dlgOpen.ShowDialog() == DialogResult.No)
            //{
            //    return;
            //}
        }

        private void propertyGridBA_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
        {

        }

        private void propertyGridPSO_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
        {

        }
    }
}
