namespace Trading_Game
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btn_buy_max_stocks_i_can_buy = new System.Windows.Forms.Button();
            this.btn_sell_max_stocks_i_can_sell = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btb_buy_1000_stocks = new System.Windows.Forms.Button();
            this.btb_sell_1000_stocks = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btb_buy_100_stocks = new System.Windows.Forms.Button();
            this.btb_sell_100_stocks = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btb_buy_10_stocks = new System.Windows.Forms.Button();
            this.btb_sell_10_stocks = new System.Windows.Forms.Button();
            this.lbl_how_much_wortyh = new System.Windows.Forms.Label();
            this.LBL_HOW_MUCH_THEY_WORTH = new System.Windows.Forms.Label();
            this.lbl_how_many_i_have_bought = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_buy = new System.Windows.Forms.Button();
            this.BTN_SELL = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lbl_my_shares_worth = new System.Windows.Forms.Label();
            this.lbl_my_wallet_wrth = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_wallet = new System.Windows.Forms.Label();
            this.lbl_nmy_score_gain_or_loss = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.splitContainer3);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.splitContainer2.Panel2.Controls.Add(this.panel1);
            this.splitContainer2.Panel2.Cursor = System.Windows.Forms.Cursors.Cross;
            this.splitContainer2.Size = new System.Drawing.Size(996, 512);
            this.splitContainer2.SplitterDistance = 399;
            this.splitContainer2.TabIndex = 0;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.chart2);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.chart1);
            this.splitContainer3.Size = new System.Drawing.Size(996, 399);
            this.splitContainer3.SplitterDistance = 279;
            this.splitContainer3.TabIndex = 0;
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StepLine;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(996, 116);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // chart2
            // 
            chartArea1.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea1);
            this.chart2.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart2.Legends.Add(legend1);
            this.chart2.Location = new System.Drawing.Point(0, 0);
            this.chart2.Name = "chart2";
            this.chart2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart2.Series.Add(series1);
            this.chart2.Size = new System.Drawing.Size(996, 279);
            this.chart2.TabIndex = 10;
            this.chart2.Text = "chart2";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(996, 109);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.lbl_how_much_wortyh);
            this.panel3.Controls.Add(this.LBL_HOW_MUCH_THEY_WORTH);
            this.panel3.Controls.Add(this.lbl_how_many_i_have_bought);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(675, 109);
            this.panel3.TabIndex = 1;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.Controls.Add(this.btn_buy_max_stocks_i_can_buy);
            this.panel7.Controls.Add(this.btn_sell_max_stocks_i_can_sell);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel7.Location = new System.Drawing.Point(379, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(74, 109);
            this.panel7.TabIndex = 9;
            // 
            // btn_buy_max_stocks_i_can_buy
            // 
            this.btn_buy_max_stocks_i_can_buy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_buy_max_stocks_i_can_buy.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_buy_max_stocks_i_can_buy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_buy_max_stocks_i_can_buy.ForeColor = System.Drawing.Color.Black;
            this.btn_buy_max_stocks_i_can_buy.Location = new System.Drawing.Point(0, 0);
            this.btn_buy_max_stocks_i_can_buy.Name = "btn_buy_max_stocks_i_can_buy";
            this.btn_buy_max_stocks_i_can_buy.Size = new System.Drawing.Size(74, 57);
            this.btn_buy_max_stocks_i_can_buy.TabIndex = 3;
            this.btn_buy_max_stocks_i_can_buy.Text = "BUY MAX";
            this.btn_buy_max_stocks_i_can_buy.UseVisualStyleBackColor = false;
            this.btn_buy_max_stocks_i_can_buy.Click += new System.EventHandler(this.btn_buy_max_stocks_i_can_buy_Click);
            // 
            // btn_sell_max_stocks_i_can_sell
            // 
            this.btn_sell_max_stocks_i_can_sell.BackColor = System.Drawing.Color.Red;
            this.btn_sell_max_stocks_i_can_sell.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_sell_max_stocks_i_can_sell.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_sell_max_stocks_i_can_sell.ForeColor = System.Drawing.Color.Black;
            this.btn_sell_max_stocks_i_can_sell.Location = new System.Drawing.Point(0, 57);
            this.btn_sell_max_stocks_i_can_sell.Name = "btn_sell_max_stocks_i_can_sell";
            this.btn_sell_max_stocks_i_can_sell.Size = new System.Drawing.Size(74, 52);
            this.btn_sell_max_stocks_i_can_sell.TabIndex = 2;
            this.btn_sell_max_stocks_i_can_sell.Text = "SELL MAX";
            this.btn_sell_max_stocks_i_can_sell.UseVisualStyleBackColor = false;
            this.btn_sell_max_stocks_i_can_sell.Click += new System.EventHandler(this.btn_sell_max_stocks_i_can_sell_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.Add(this.btb_buy_1000_stocks);
            this.panel6.Controls.Add(this.btb_sell_1000_stocks);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(453, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(74, 109);
            this.panel6.TabIndex = 8;
            // 
            // btb_buy_1000_stocks
            // 
            this.btb_buy_1000_stocks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btb_buy_1000_stocks.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btb_buy_1000_stocks.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btb_buy_1000_stocks.ForeColor = System.Drawing.Color.Black;
            this.btb_buy_1000_stocks.Location = new System.Drawing.Point(0, 0);
            this.btb_buy_1000_stocks.Name = "btb_buy_1000_stocks";
            this.btb_buy_1000_stocks.Size = new System.Drawing.Size(74, 57);
            this.btb_buy_1000_stocks.TabIndex = 3;
            this.btb_buy_1000_stocks.Text = "BUY 1000";
            this.btb_buy_1000_stocks.UseVisualStyleBackColor = false;
            this.btb_buy_1000_stocks.Click += new System.EventHandler(this.btb_buy_1000_stocks_Click);
            // 
            // btb_sell_1000_stocks
            // 
            this.btb_sell_1000_stocks.BackColor = System.Drawing.Color.Red;
            this.btb_sell_1000_stocks.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btb_sell_1000_stocks.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btb_sell_1000_stocks.ForeColor = System.Drawing.Color.Black;
            this.btb_sell_1000_stocks.Location = new System.Drawing.Point(0, 57);
            this.btb_sell_1000_stocks.Name = "btb_sell_1000_stocks";
            this.btb_sell_1000_stocks.Size = new System.Drawing.Size(74, 52);
            this.btb_sell_1000_stocks.TabIndex = 2;
            this.btb_sell_1000_stocks.Text = "SELL 1000";
            this.btb_sell_1000_stocks.UseVisualStyleBackColor = false;
            this.btb_sell_1000_stocks.Click += new System.EventHandler(this.btb_sell_1000_stocks_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.btb_buy_100_stocks);
            this.panel5.Controls.Add(this.btb_sell_100_stocks);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(527, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(74, 109);
            this.panel5.TabIndex = 7;
            // 
            // btb_buy_100_stocks
            // 
            this.btb_buy_100_stocks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btb_buy_100_stocks.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btb_buy_100_stocks.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btb_buy_100_stocks.ForeColor = System.Drawing.Color.Black;
            this.btb_buy_100_stocks.Location = new System.Drawing.Point(0, 0);
            this.btb_buy_100_stocks.Name = "btb_buy_100_stocks";
            this.btb_buy_100_stocks.Size = new System.Drawing.Size(74, 57);
            this.btb_buy_100_stocks.TabIndex = 3;
            this.btb_buy_100_stocks.Text = "BUY 100";
            this.btb_buy_100_stocks.UseVisualStyleBackColor = false;
            this.btb_buy_100_stocks.Click += new System.EventHandler(this.btb_buy_100_stocks_Click);
            // 
            // btb_sell_100_stocks
            // 
            this.btb_sell_100_stocks.BackColor = System.Drawing.Color.Red;
            this.btb_sell_100_stocks.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btb_sell_100_stocks.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btb_sell_100_stocks.ForeColor = System.Drawing.Color.Black;
            this.btb_sell_100_stocks.Location = new System.Drawing.Point(0, 57);
            this.btb_sell_100_stocks.Name = "btb_sell_100_stocks";
            this.btb_sell_100_stocks.Size = new System.Drawing.Size(74, 52);
            this.btb_sell_100_stocks.TabIndex = 2;
            this.btb_sell_100_stocks.Text = "SELL 100";
            this.btb_sell_100_stocks.UseVisualStyleBackColor = false;
            this.btb_sell_100_stocks.Click += new System.EventHandler(this.btb_sell_100_stocks_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.btb_buy_10_stocks);
            this.panel4.Controls.Add(this.btb_sell_10_stocks);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(601, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(74, 109);
            this.panel4.TabIndex = 6;
            // 
            // btb_buy_10_stocks
            // 
            this.btb_buy_10_stocks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btb_buy_10_stocks.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btb_buy_10_stocks.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btb_buy_10_stocks.ForeColor = System.Drawing.Color.Black;
            this.btb_buy_10_stocks.Location = new System.Drawing.Point(0, 0);
            this.btb_buy_10_stocks.Name = "btb_buy_10_stocks";
            this.btb_buy_10_stocks.Size = new System.Drawing.Size(74, 57);
            this.btb_buy_10_stocks.TabIndex = 3;
            this.btb_buy_10_stocks.Text = "BUY 10";
            this.btb_buy_10_stocks.UseVisualStyleBackColor = false;
            this.btb_buy_10_stocks.Click += new System.EventHandler(this.btb_buy_10_stocks_Click);
            // 
            // btb_sell_10_stocks
            // 
            this.btb_sell_10_stocks.BackColor = System.Drawing.Color.Red;
            this.btb_sell_10_stocks.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btb_sell_10_stocks.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btb_sell_10_stocks.ForeColor = System.Drawing.Color.Black;
            this.btb_sell_10_stocks.Location = new System.Drawing.Point(0, 57);
            this.btb_sell_10_stocks.Name = "btb_sell_10_stocks";
            this.btb_sell_10_stocks.Size = new System.Drawing.Size(74, 52);
            this.btb_sell_10_stocks.TabIndex = 2;
            this.btb_sell_10_stocks.Text = "SELL 10";
            this.btb_sell_10_stocks.UseVisualStyleBackColor = false;
            this.btb_sell_10_stocks.Click += new System.EventHandler(this.btb_sell_10_stocks_Click);
            // 
            // lbl_how_much_wortyh
            // 
            this.lbl_how_much_wortyh.AutoSize = true;
            this.lbl_how_much_wortyh.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_how_much_wortyh.ForeColor = System.Drawing.Color.Black;
            this.lbl_how_much_wortyh.Location = new System.Drawing.Point(261, 4);
            this.lbl_how_much_wortyh.Name = "lbl_how_much_wortyh";
            this.lbl_how_much_wortyh.Size = new System.Drawing.Size(0, 24);
            this.lbl_how_much_wortyh.TabIndex = 5;
            // 
            // LBL_HOW_MUCH_THEY_WORTH
            // 
            this.LBL_HOW_MUCH_THEY_WORTH.AutoSize = true;
            this.LBL_HOW_MUCH_THEY_WORTH.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_HOW_MUCH_THEY_WORTH.ForeColor = System.Drawing.Color.Black;
            this.LBL_HOW_MUCH_THEY_WORTH.Location = new System.Drawing.Point(3, 28);
            this.LBL_HOW_MUCH_THEY_WORTH.Name = "LBL_HOW_MUCH_THEY_WORTH";
            this.LBL_HOW_MUCH_THEY_WORTH.Size = new System.Drawing.Size(82, 24);
            this.LBL_HOW_MUCH_THEY_WORTH.TabIndex = 2;
            this.LBL_HOW_MUCH_THEY_WORTH.Text = "label1";
            // 
            // lbl_how_many_i_have_bought
            // 
            this.lbl_how_many_i_have_bought.AutoSize = true;
            this.lbl_how_many_i_have_bought.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_how_many_i_have_bought.ForeColor = System.Drawing.Color.Black;
            this.lbl_how_many_i_have_bought.Location = new System.Drawing.Point(3, 4);
            this.lbl_how_many_i_have_bought.Name = "lbl_how_many_i_have_bought";
            this.lbl_how_many_i_have_bought.Size = new System.Drawing.Size(82, 24);
            this.lbl_how_many_i_have_bought.TabIndex = 1;
            this.lbl_how_many_i_have_bought.Text = "label1";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btn_buy);
            this.panel2.Controls.Add(this.BTN_SELL);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(675, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(321, 109);
            this.panel2.TabIndex = 0;
            // 
            // btn_buy
            // 
            this.btn_buy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_buy.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_buy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_buy.ForeColor = System.Drawing.Color.Black;
            this.btn_buy.Location = new System.Drawing.Point(0, 0);
            this.btn_buy.Name = "btn_buy";
            this.btn_buy.Size = new System.Drawing.Size(321, 57);
            this.btn_buy.TabIndex = 3;
            this.btn_buy.Text = "BUY";
            this.btn_buy.UseVisualStyleBackColor = false;
            this.btn_buy.Click += new System.EventHandler(this.btn_buy_Click);
            // 
            // BTN_SELL
            // 
            this.BTN_SELL.BackColor = System.Drawing.Color.Red;
            this.BTN_SELL.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BTN_SELL.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_SELL.ForeColor = System.Drawing.Color.Black;
            this.BTN_SELL.Location = new System.Drawing.Point(0, 57);
            this.BTN_SELL.Name = "BTN_SELL";
            this.BTN_SELL.Size = new System.Drawing.Size(321, 52);
            this.BTN_SELL.TabIndex = 2;
            this.BTN_SELL.Text = "SELL";
            this.BTN_SELL.UseVisualStyleBackColor = false;
            this.BTN_SELL.Click += new System.EventHandler(this.BTN_SELL_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(236, 512);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lbl_my_shares_worth);
            this.tabPage2.Controls.Add(this.lbl_my_wallet_wrth);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.lbl_wallet);
            this.tabPage2.Controls.Add(this.lbl_nmy_score_gain_or_loss);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(228, 486);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Broker Wallet";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lbl_my_shares_worth
            // 
            this.lbl_my_shares_worth.AutoSize = true;
            this.lbl_my_shares_worth.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_my_shares_worth.ForeColor = System.Drawing.Color.Black;
            this.lbl_my_shares_worth.Location = new System.Drawing.Point(43, 180);
            this.lbl_my_shares_worth.Name = "lbl_my_shares_worth";
            this.lbl_my_shares_worth.Size = new System.Drawing.Size(130, 24);
            this.lbl_my_shares_worth.TabIndex = 8;
            this.lbl_my_shares_worth.Text = "__________";
            // 
            // lbl_my_wallet_wrth
            // 
            this.lbl_my_wallet_wrth.AutoSize = true;
            this.lbl_my_wallet_wrth.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_my_wallet_wrth.ForeColor = System.Drawing.Color.Black;
            this.lbl_my_wallet_wrth.Location = new System.Drawing.Point(43, 156);
            this.lbl_my_wallet_wrth.Name = "lbl_my_wallet_wrth";
            this.lbl_my_wallet_wrth.Size = new System.Drawing.Size(130, 24);
            this.lbl_my_wallet_wrth.TabIndex = 7;
            this.lbl_my_wallet_wrth.Text = "__________";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(3, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "b$";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(3, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "$$";
            // 
            // lbl_wallet
            // 
            this.lbl_wallet.AutoSize = true;
            this.lbl_wallet.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_wallet.ForeColor = System.Drawing.Color.Black;
            this.lbl_wallet.Location = new System.Drawing.Point(-8, 0);
            this.lbl_wallet.Name = "lbl_wallet";
            this.lbl_wallet.Size = new System.Drawing.Size(154, 24);
            this.lbl_wallet.TabIndex = 3;
            this.lbl_wallet.Text = " labelWallet";
            // 
            // lbl_nmy_score_gain_or_loss
            // 
            this.lbl_nmy_score_gain_or_loss.AutoSize = true;
            this.lbl_nmy_score_gain_or_loss.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nmy_score_gain_or_loss.ForeColor = System.Drawing.Color.Black;
            this.lbl_nmy_score_gain_or_loss.Location = new System.Drawing.Point(3, 24);
            this.lbl_nmy_score_gain_or_loss.Name = "lbl_nmy_score_gain_or_loss";
            this.lbl_nmy_score_gain_or_loss.Size = new System.Drawing.Size(310, 24);
            this.lbl_nmy_score_gain_or_loss.TabIndex = 4;
            this.lbl_nmy_score_gain_or_loss.Text = "lbl_my_score-gain_or_loss";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tabControl1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1236, 512);
            this.splitContainer1.SplitterDistance = 236;
            this.splitContainer1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1236, 512);
            this.Controls.Add(this.splitContainer1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btn_buy_max_stocks_i_can_buy;
        private System.Windows.Forms.Button btn_sell_max_stocks_i_can_sell;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btb_buy_1000_stocks;
        private System.Windows.Forms.Button btb_sell_1000_stocks;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btb_buy_100_stocks;
        private System.Windows.Forms.Button btb_sell_100_stocks;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btb_buy_10_stocks;
        private System.Windows.Forms.Button btb_sell_10_stocks;
        private System.Windows.Forms.Label lbl_how_much_wortyh;
        private System.Windows.Forms.Label LBL_HOW_MUCH_THEY_WORTH;
        private System.Windows.Forms.Label lbl_how_many_i_have_bought;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_buy;
        private System.Windows.Forms.Button BTN_SELL;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lbl_my_shares_worth;
        private System.Windows.Forms.Label lbl_my_wallet_wrth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_wallet;
        private System.Windows.Forms.Label lbl_nmy_score_gain_or_loss;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}

