namespace R05546014洪紹綺FinalProject
{
    partial class MainForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpBA = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.labelBAbestObjective = new System.Windows.Forms.Label();
            this.listBoxBA = new System.Windows.Forms.ListBox();
            this.propertyGridBA = new System.Windows.Forms.PropertyGrid();
            this.btnBARunToEnd = new System.Windows.Forms.Button();
            this.btnBARunOneIteration = new System.Windows.Forms.Button();
            this.btnBAcreate = new System.Windows.Forms.Button();
            this.btnBAReset = new System.Windows.Forms.Button();
            this.tpPSO = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.labelPSObestObjective = new System.Windows.Forms.Label();
            this.propertyGridPSO = new System.Windows.Forms.PropertyGrid();
            this.listBoxPSO = new System.Windows.Forms.ListBox();
            this.btnPSOReset = new System.Windows.Forms.Button();
            this.btnPSORunOneIteration = new System.Windows.Forms.Button();
            this.btnPSOcreate = new System.Windows.Forms.Button();
            this.btnPSORunToEnd = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsBtnOpenCOP = new System.Windows.Forms.ToolStripButton();
            this.dlgOpen = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tpBA.SuspendLayout();
            this.tpPSO.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(0, 31);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer1.Size = new System.Drawing.Size(1388, 677);
            this.splitContainer1.SplitterDistance = 289;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 2;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer3.BackColor = System.Drawing.Color.Pink;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer3.Size = new System.Drawing.Size(1091, 683);
            this.splitContainer3.SplitterDistance = 687;
            this.splitContainer3.SplitterWidth = 5;
            this.splitContainer3.TabIndex = 2;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer2.BackColor = System.Drawing.Color.PeachPuff;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.chart1);
            this.splitContainer2.Size = new System.Drawing.Size(688, 677);
            this.splitContainer2.SplitterDistance = 333;
            this.splitContainer2.SplitterWidth = 5;
            this.splitContainer2.TabIndex = 1;
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea3.AxisX.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Horizontal;
            chartArea3.AxisX.Title = "Iteration";
            chartArea3.AxisY.Title = "Objective";
            chartArea3.Name = "ChartAreaBA";
            chartArea4.AxisX.Title = "Iteration";
            chartArea4.AxisY.Title = "Objective";
            chartArea4.Name = "ChartAreaPSO";
            this.chart1.ChartAreas.Add(chartArea3);
            this.chart1.ChartAreas.Add(chartArea4);
            legend3.Alignment = System.Drawing.StringAlignment.Center;
            legend3.DockedToChartArea = "ChartAreaBA";
            legend3.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend3.IsDockedInsideChartArea = false;
            legend3.Name = "BALegend";
            legend3.Title = "Bat Algorithm";
            legend4.Alignment = System.Drawing.StringAlignment.Center;
            legend4.DockedToChartArea = "ChartAreaPSO";
            legend4.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend4.IsDockedInsideChartArea = false;
            legend4.Name = "PSOLegend";
            legend4.Title = "Particle Swarm Optimizaton";
            this.chart1.Legends.Add(legend3);
            this.chart1.Legends.Add(legend4);
            this.chart1.Location = new System.Drawing.Point(4, 4);
            this.chart1.Margin = new System.Windows.Forms.Padding(4);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series7.ChartArea = "ChartAreaBA";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series7.Legend = "BALegend";
            series7.Name = "BA Iteration Average";
            series8.ChartArea = "ChartAreaBA";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series8.Legend = "BALegend";
            series8.Name = "BA Iteration Best";
            series9.ChartArea = "ChartAreaBA";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series9.Legend = "BALegend";
            series9.Name = "BA So Far The Best";
            series10.ChartArea = "ChartAreaPSO";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series10.Legend = "PSOLegend";
            series10.Name = "PSO Iteration Average";
            series11.ChartArea = "ChartAreaPSO";
            series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series11.Legend = "PSOLegend";
            series11.Name = "PSO Iteration Best";
            series12.ChartArea = "ChartAreaPSO";
            series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series12.Legend = "PSOLegend";
            series12.Name = "PSO So Far The Best";
            this.chart1.Series.Add(series7);
            this.chart1.Series.Add(series8);
            this.chart1.Series.Add(series9);
            this.chart1.Series.Add(series10);
            this.chart1.Series.Add(series11);
            this.chart1.Series.Add(series12);
            this.chart1.Size = new System.Drawing.Size(680, 325);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tpBA);
            this.tabControl1.Controls.Add(this.tpPSO);
            this.tabControl1.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tabControl1.Location = new System.Drawing.Point(4, 4);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(386, 675);
            this.tabControl1.TabIndex = 5;
            // 
            // tpBA
            // 
            this.tpBA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tpBA.Controls.Add(this.label1);
            this.tpBA.Controls.Add(this.labelBAbestObjective);
            this.tpBA.Controls.Add(this.listBoxBA);
            this.tpBA.Controls.Add(this.propertyGridBA);
            this.tpBA.Controls.Add(this.btnBARunToEnd);
            this.tpBA.Controls.Add(this.btnBARunOneIteration);
            this.tpBA.Controls.Add(this.btnBAcreate);
            this.tpBA.Controls.Add(this.btnBAReset);
            this.tpBA.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tpBA.ForeColor = System.Drawing.Color.Black;
            this.tpBA.Location = new System.Drawing.Point(4, 31);
            this.tpBA.Margin = new System.Windows.Forms.Padding(4);
            this.tpBA.Name = "tpBA";
            this.tpBA.Padding = new System.Windows.Forms.Padding(4);
            this.tpBA.Size = new System.Drawing.Size(378, 640);
            this.tpBA.TabIndex = 1;
            this.tpBA.Text = "Bat Algorithm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(244, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 22);
            this.label1.TabIndex = 7;
            this.label1.Text = "Solution";
            // 
            // labelBAbestObjective
            // 
            this.labelBAbestObjective.AutoSize = true;
            this.labelBAbestObjective.Font = new System.Drawing.Font("微軟正黑體", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelBAbestObjective.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelBAbestObjective.Location = new System.Drawing.Point(5, 290);
            this.labelBAbestObjective.Name = "labelBAbestObjective";
            this.labelBAbestObjective.Size = new System.Drawing.Size(257, 24);
            this.labelBAbestObjective.TabIndex = 6;
            this.labelBAbestObjective.Text = "So Far The Best Objective : ";
            // 
            // listBoxBA
            // 
            this.listBoxBA.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxBA.FormattingEnabled = true;
            this.listBoxBA.HorizontalScrollbar = true;
            this.listBoxBA.ItemHeight = 22;
            this.listBoxBA.Location = new System.Drawing.Point(201, 30);
            this.listBoxBA.Name = "listBoxBA";
            this.listBoxBA.Size = new System.Drawing.Size(173, 246);
            this.listBoxBA.TabIndex = 5;
            // 
            // propertyGridBA
            // 
            this.propertyGridBA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.propertyGridBA.Location = new System.Drawing.Point(4, 328);
            this.propertyGridBA.Margin = new System.Windows.Forms.Padding(4);
            this.propertyGridBA.Name = "propertyGridBA";
            this.propertyGridBA.Size = new System.Drawing.Size(369, 306);
            this.propertyGridBA.TabIndex = 4;
            this.propertyGridBA.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.propertyGridBA_PropertyValueChanged);
            // 
            // btnBARunToEnd
            // 
            this.btnBARunToEnd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnBARunToEnd.Location = new System.Drawing.Point(9, 222);
            this.btnBARunToEnd.Margin = new System.Windows.Forms.Padding(4);
            this.btnBARunToEnd.Name = "btnBARunToEnd";
            this.btnBARunToEnd.Size = new System.Drawing.Size(185, 49);
            this.btnBARunToEnd.TabIndex = 3;
            this.btnBARunToEnd.Text = "Run To End";
            this.btnBARunToEnd.UseVisualStyleBackColor = false;
            this.btnBARunToEnd.Click += new System.EventHandler(this.btnRunToEnd_Click);
            // 
            // btnBARunOneIteration
            // 
            this.btnBARunOneIteration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnBARunOneIteration.Location = new System.Drawing.Point(9, 156);
            this.btnBARunOneIteration.Margin = new System.Windows.Forms.Padding(4);
            this.btnBARunOneIteration.Name = "btnBARunOneIteration";
            this.btnBARunOneIteration.Size = new System.Drawing.Size(185, 58);
            this.btnBARunOneIteration.TabIndex = 2;
            this.btnBARunOneIteration.Text = "Run One Iteration";
            this.btnBARunOneIteration.UseVisualStyleBackColor = false;
            this.btnBARunOneIteration.Click += new System.EventHandler(this.btnRunOneIteration_Click);
            // 
            // btnBAcreate
            // 
            this.btnBAcreate.Location = new System.Drawing.Point(8, 8);
            this.btnBAcreate.Margin = new System.Windows.Forms.Padding(4);
            this.btnBAcreate.Name = "btnBAcreate";
            this.btnBAcreate.Size = new System.Drawing.Size(186, 79);
            this.btnBAcreate.TabIndex = 0;
            this.btnBAcreate.Text = "Create a BA Solver";
            this.btnBAcreate.UseVisualStyleBackColor = true;
            this.btnBAcreate.Click += new System.EventHandler(this.btnCreateBASOLVER_Click);
            // 
            // btnBAReset
            // 
            this.btnBAReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnBAReset.Location = new System.Drawing.Point(9, 95);
            this.btnBAReset.Margin = new System.Windows.Forms.Padding(4);
            this.btnBAReset.Name = "btnBAReset";
            this.btnBAReset.Size = new System.Drawing.Size(185, 53);
            this.btnBAReset.TabIndex = 1;
            this.btnBAReset.Text = "Reset";
            this.btnBAReset.UseVisualStyleBackColor = false;
            this.btnBAReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // tpPSO
            // 
            this.tpPSO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tpPSO.Controls.Add(this.label2);
            this.tpPSO.Controls.Add(this.labelPSObestObjective);
            this.tpPSO.Controls.Add(this.propertyGridPSO);
            this.tpPSO.Controls.Add(this.listBoxPSO);
            this.tpPSO.Controls.Add(this.btnPSOReset);
            this.tpPSO.Controls.Add(this.btnPSORunOneIteration);
            this.tpPSO.Controls.Add(this.btnPSOcreate);
            this.tpPSO.Controls.Add(this.btnPSORunToEnd);
            this.tpPSO.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tpPSO.Location = new System.Drawing.Point(4, 31);
            this.tpPSO.Margin = new System.Windows.Forms.Padding(4);
            this.tpPSO.Name = "tpPSO";
            this.tpPSO.Padding = new System.Windows.Forms.Padding(4);
            this.tpPSO.Size = new System.Drawing.Size(378, 640);
            this.tpPSO.TabIndex = 0;
            this.tpPSO.Text = "Particle Swarm Optimization";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(244, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 22);
            this.label2.TabIndex = 10;
            this.label2.Text = "Solution";
            // 
            // labelPSObestObjective
            // 
            this.labelPSObestObjective.AutoSize = true;
            this.labelPSObestObjective.Font = new System.Drawing.Font("微軟正黑體", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelPSObestObjective.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelPSObestObjective.Location = new System.Drawing.Point(7, 291);
            this.labelPSObestObjective.Name = "labelPSObestObjective";
            this.labelPSObestObjective.Size = new System.Drawing.Size(252, 24);
            this.labelPSObestObjective.TabIndex = 7;
            this.labelPSObestObjective.Text = "So Far The Best Objective :";
            // 
            // propertyGridPSO
            // 
            this.propertyGridPSO.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.propertyGridPSO.Location = new System.Drawing.Point(7, 331);
            this.propertyGridPSO.Margin = new System.Windows.Forms.Padding(4);
            this.propertyGridPSO.Name = "propertyGridPSO";
            this.propertyGridPSO.Size = new System.Drawing.Size(368, 278);
            this.propertyGridPSO.TabIndex = 9;
            this.propertyGridPSO.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.propertyGridPSO_PropertyValueChanged);
            // 
            // listBoxPSO
            // 
            this.listBoxPSO.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxPSO.BackColor = System.Drawing.Color.White;
            this.listBoxPSO.FormattingEnabled = true;
            this.listBoxPSO.HorizontalScrollbar = true;
            this.listBoxPSO.ItemHeight = 22;
            this.listBoxPSO.Location = new System.Drawing.Point(199, 30);
            this.listBoxPSO.Name = "listBoxPSO";
            this.listBoxPSO.Size = new System.Drawing.Size(178, 246);
            this.listBoxPSO.TabIndex = 8;
            // 
            // btnPSOReset
            // 
            this.btnPSOReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnPSOReset.Location = new System.Drawing.Point(9, 98);
            this.btnPSOReset.Margin = new System.Windows.Forms.Padding(4);
            this.btnPSOReset.Name = "btnPSOReset";
            this.btnPSOReset.Size = new System.Drawing.Size(185, 53);
            this.btnPSOReset.TabIndex = 7;
            this.btnPSOReset.Text = "Reset";
            this.btnPSOReset.UseVisualStyleBackColor = false;
            this.btnPSOReset.Click += new System.EventHandler(this.btnPSOReset_Click);
            // 
            // btnPSORunOneIteration
            // 
            this.btnPSORunOneIteration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnPSORunOneIteration.Location = new System.Drawing.Point(9, 159);
            this.btnPSORunOneIteration.Margin = new System.Windows.Forms.Padding(4);
            this.btnPSORunOneIteration.Name = "btnPSORunOneIteration";
            this.btnPSORunOneIteration.Size = new System.Drawing.Size(185, 53);
            this.btnPSORunOneIteration.TabIndex = 5;
            this.btnPSORunOneIteration.Text = "Run One Iteration";
            this.btnPSORunOneIteration.UseVisualStyleBackColor = false;
            this.btnPSORunOneIteration.Click += new System.EventHandler(this.btnPSORunOneIteration_Click);
            // 
            // btnPSOcreate
            // 
            this.btnPSOcreate.Location = new System.Drawing.Point(7, 8);
            this.btnPSOcreate.Margin = new System.Windows.Forms.Padding(4);
            this.btnPSOcreate.Name = "btnPSOcreate";
            this.btnPSOcreate.Size = new System.Drawing.Size(185, 82);
            this.btnPSOcreate.TabIndex = 4;
            this.btnPSOcreate.Text = "Create a PSO Solver";
            this.btnPSOcreate.UseVisualStyleBackColor = true;
            this.btnPSOcreate.Click += new System.EventHandler(this.btnPSOcreate_Click);
            // 
            // btnPSORunToEnd
            // 
            this.btnPSORunToEnd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnPSORunToEnd.Location = new System.Drawing.Point(9, 220);
            this.btnPSORunToEnd.Margin = new System.Windows.Forms.Padding(4);
            this.btnPSORunToEnd.Name = "btnPSORunToEnd";
            this.btnPSORunToEnd.Size = new System.Drawing.Size(185, 51);
            this.btnPSORunToEnd.TabIndex = 6;
            this.btnPSORunToEnd.Text = "Run To End";
            this.btnPSORunToEnd.UseVisualStyleBackColor = false;
            this.btnPSORunToEnd.Click += new System.EventHandler(this.btnPSORunToEnd_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBtnOpenCOP});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip1.Size = new System.Drawing.Size(1388, 27);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsBtnOpenCOP
            // 
            this.tsBtnOpenCOP.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnOpenCOP.Image")));
            this.tsBtnOpenCOP.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnOpenCOP.Name = "tsBtnOpenCOP";
            this.tsBtnOpenCOP.Size = new System.Drawing.Size(188, 24);
            this.tsBtnOpenCOP.Text = "Open COP Benchmark";
            this.tsBtnOpenCOP.Click += new System.EventHandler(this.tsBtnOpenCOP_Click);
            // 
            // dlgOpen
            // 
            this.dlgOpen.DefaultExt = "cop";
            this.dlgOpen.FileName = "*.cop";
            this.dlgOpen.Title = "Open COP Benchmark";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1388, 710);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("新細明體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Bat Algorithm for Continuous Optimization Problem";
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tpBA.ResumeLayout(false);
            this.tpBA.PerformLayout();
            this.tpPSO.ResumeLayout(false);
            this.tpPSO.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.PropertyGrid propertyGridBA;
        private System.Windows.Forms.Button btnBARunToEnd;
        private System.Windows.Forms.Button btnBARunOneIteration;
        private System.Windows.Forms.Button btnBAReset;
        private System.Windows.Forms.Button btnBAcreate;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpBA;
        private System.Windows.Forms.TabPage tpPSO;
        private System.Windows.Forms.ListBox listBoxBA;
        private System.Windows.Forms.Button btnPSOReset;
        private System.Windows.Forms.Button btnPSORunOneIteration;
        private System.Windows.Forms.Button btnPSOcreate;
        private System.Windows.Forms.Button btnPSORunToEnd;
        private System.Windows.Forms.PropertyGrid propertyGridPSO;
        private System.Windows.Forms.ListBox listBoxPSO;
        private System.Windows.Forms.Label labelBAbestObjective;
        private System.Windows.Forms.Label labelPSObestObjective;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsBtnOpenCOP;
        private System.Windows.Forms.OpenFileDialog dlgOpen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

