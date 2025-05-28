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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl_nmy_score_gain_or_loss = new System.Windows.Forms.Label();
            this.lbl_wallet = new System.Windows.Forms.Label();
            this.LBL_HOW_MUCH_THEY_WORTH = new System.Windows.Forms.Label();
            this.lbl_how_many_i_have_bought = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_buy = new System.Windows.Forms.Button();
            this.BTN_SELL = new System.Windows.Forms.Button();
            this.lbl_how_much_wortyh = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
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
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.Size = new System.Drawing.Size(222, 480);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            this.splitContainer2.Panel1.Controls.Add(this.chart1);
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
            this.chart1.Size = new System.Drawing.Size(996, 399);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
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
            this.panel3.Controls.Add(this.lbl_how_much_wortyh);
            this.panel3.Controls.Add(this.LBL_HOW_MUCH_THEY_WORTH);
            this.panel3.Controls.Add(this.lbl_how_many_i_have_bought);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(675, 109);
            this.panel3.TabIndex = 1;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // lbl_nmy_score_gain_or_loss
            // 
            this.lbl_nmy_score_gain_or_loss.AutoSize = true;
            this.lbl_nmy_score_gain_or_loss.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nmy_score_gain_or_loss.ForeColor = System.Drawing.Color.Black;
            this.lbl_nmy_score_gain_or_loss.Location = new System.Drawing.Point(11, 42);
            this.lbl_nmy_score_gain_or_loss.Name = "lbl_nmy_score_gain_or_loss";
            this.lbl_nmy_score_gain_or_loss.Size = new System.Drawing.Size(310, 24);
            this.lbl_nmy_score_gain_or_loss.TabIndex = 4;
            this.lbl_nmy_score_gain_or_loss.Text = "lbl_my_score-gain_or_loss";
            this.lbl_nmy_score_gain_or_loss.Click += new System.EventHandler(this.label2_Click);
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
            this.lbl_wallet.Click += new System.EventHandler(this.label1_Click);
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
            this.LBL_HOW_MUCH_THEY_WORTH.Click += new System.EventHandler(this.LBL_HOW_MUCH_THEY_WORTH_Click);
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
            this.lbl_how_many_i_have_bought.Click += new System.EventHandler(this.lbl_how_many_i_have_bought_Click);
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
            // lbl_how_much_wortyh
            // 
            this.lbl_how_much_wortyh.AutoSize = true;
            this.lbl_how_much_wortyh.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_how_much_wortyh.ForeColor = System.Drawing.Color.Black;
            this.lbl_how_much_wortyh.Location = new System.Drawing.Point(168, 4);
            this.lbl_how_much_wortyh.Name = "lbl_how_much_wortyh";
            this.lbl_how_much_wortyh.Size = new System.Drawing.Size(154, 24);
            this.lbl_how_much_wortyh.TabIndex = 5;
            this.lbl_how_much_wortyh.Text = " labelWallet";
            this.lbl_how_much_wortyh.Click += new System.EventHandler(this.lbl_how_much_wortyh_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(236, 512);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(228, 486);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Trades";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
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
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label LBL_HOW_MUCH_THEY_WORTH;
        private System.Windows.Forms.Label lbl_how_many_i_have_bought;
        private System.Windows.Forms.Button btn_buy;
        private System.Windows.Forms.Button BTN_SELL;
        private System.Windows.Forms.Label lbl_nmy_score_gain_or_loss;
        private System.Windows.Forms.Label lbl_wallet;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbl_how_much_wortyh;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}

