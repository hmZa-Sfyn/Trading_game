using System;
using System.Collections.Generic; // For List<>
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Trading_Game
{
    public partial class Form1 : Form
    {
        private Random rand = new Random();
        private Timer timer;
        private double lastPrice = 100; // Initial starting price
        private int stocksOwned = 0;

        private double wallet = 10000;      // Starting wallet amount
        private double initialWallet;       // Track initial wallet to compare for gain/loss

        // List to track the price of each stock bought for profit/loss calculation (FIFO)
        private List<StockTrade> boughtStockTrades = new List<StockTrade>();

        private const string TradesFileName = "trades.json";

        public Form1()
        {
            InitializeComponent();
            SetupSplineChart();
            SetupDataGridView();

            timer = new Timer();
            timer.Interval = 200; // Update every 1 second
            timer.Tick += Timer_Tick;
            timer.Start();

            initialWallet = wallet;

            // Initial label values
            UpdateOwnedLabel();
            UpdateWorthLabel();
            UpdateWalletLabel();
        }

        private void SetupDataGridView()
        {
            dataGridView1.Columns.Clear();

            dataGridView1.Columns.Add("TradeType", "Type");
            dataGridView1.Columns.Add("TradeProfitLoss", "Profit/Loss");

            // Set column format
            dataGridView1.Columns["TradeProfitLoss"].DefaultCellStyle.Format = "C2";

            // Align right for better visuals
            dataGridView1.Columns["TradeProfitLoss"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        private void AddTradeToGrid(string type, double profitLoss)
        {
            string profitLossStr = $"{profitLoss:C2}";
            int rowIndex = dataGridView1.Rows.Add(type, profitLossStr);
            var row = dataGridView1.Rows[rowIndex];

            // Set row color based on profit or loss
            row.DefaultCellStyle.BackColor = profitLoss >= 0 ? Color.LightGreen : Color.LightCoral;
        }

        // New class to hold trade info including UUID and timestamps
        private class StockTrade
        {
            public string UUID { get; set; }
            public double Price { get; set; }
            public DateTime InTime { get; set; }
            public DateTime? OutTime { get; set; }  // Nullable for open trades
            public double? ProfitLoss { get; set; } // Nullable until sold
        }

        // Helper: Load existing trades from JSON file (or create empty list)
        private List<StockTrade> LoadTrades()
        {
            try
            {
                if (!File.Exists(TradesFileName))
                    return new List<StockTrade>();

                string json = File.ReadAllText(TradesFileName);
                return JsonSerializer.Deserialize<List<StockTrade>>(json) ?? new List<StockTrade>();
            }
            catch
            {
                return new List<StockTrade>();
            }
        }

        // Helper: Save trades list to JSON file
        private void SaveTrades(List<StockTrade> trades)
        {
            string json = JsonSerializer.Serialize(trades, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(TradesFileName, json);
        }

        private void btn_buy_Click(object sender, EventArgs e)
        {
            if (wallet >= lastPrice)
            {
                stocksOwned++;
                wallet -= lastPrice;

                // Create a new trade entry for bought stock
                var trade = new StockTrade
                {
                    UUID = Guid.NewGuid().ToString(),
                    Price = lastPrice,
                    InTime = DateTime.Now,
                    OutTime = null,
                    ProfitLoss = null
                };

                boughtStockTrades.Add(trade);

                UpdateOwnedLabel();
                UpdateWorthLabel();
                UpdateWalletLabel();

                AddTradeToGrid("Buy", 0); // no profit/loss on buy

                // Save updated trades to file (append new buy)
                var allTrades = LoadTrades();
                allTrades.Add(trade);
                SaveTrades(allTrades);
            }
            else
            {
                MessageBox.Show("Not enough money to buy!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BTN_SELL_Click(object sender, EventArgs e)
        {
            if (stocksOwned > 0 && boughtStockTrades.Count > 0)
            {
                stocksOwned--;
                wallet += lastPrice;

                // Use FIFO: sell the oldest bought trade
                StockTrade boughtTrade = boughtStockTrades[0];
                boughtStockTrades.RemoveAt(0);

                // Calculate profit/loss
                double profitLoss = lastPrice - boughtTrade.Price;

                // Update trade with sell info
                boughtTrade.OutTime = DateTime.Now;
                boughtTrade.ProfitLoss = profitLoss;

                UpdateOwnedLabel();
                UpdateWorthLabel();
                UpdateWalletLabel();

                AddTradeToGrid("Sell", profitLoss);

                // Save updated trades to file, updating the sold trade
                var allTrades = LoadTrades();

                // Find the trade by UUID and update it
                int index = allTrades.FindIndex(t => t.UUID == boughtTrade.UUID);
                if (index >= 0)
                {
                    allTrades[index].OutTime = boughtTrade.OutTime;
                    allTrades[index].ProfitLoss = profitLoss;
                }
                else
                {
                    // If not found (shouldn't happen), just add it
                    allTrades.Add(boughtTrade);
                }

                SaveTrades(allTrades);
            }
            else
            {
                MessageBox.Show("No stocks to sell!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void SetupSplineChart()
        {
            chart1.Series.Clear();
            chart1.ChartAreas.Clear();

            ChartArea chartArea = new ChartArea("MainArea");
            chart1.ChartAreas.Add(chartArea);

            Series series1 = new Series("Series1");
            series1.ChartType = SeriesChartType.Spline;
            series1.XValueType = ChartValueType.DateTime;
            series1.Color = Color.Black;

            chart1.Series.Add(series1);
        }

        // Add these fields to your class
        private int lastDirection = 0;              // +1 = up, -1 = down, 0 = first move
        private double momentumProbability = 0.05;  // starts low (5%), grows on trend

        private void PushRandomData()
        {
            DateTime now = DateTime.Now;
            bool isEvenTick = (now.Ticks % 2 == 0);

            double timeFactor = 0.03 * Math.Sin(now.TimeOfDay.TotalSeconds * Math.PI / 30);
            double volatility = 0.01 + 0.02 * Math.Sin(now.TimeOfDay.TotalMinutes);
            double baseDrift = 0.0003;

            int chance = rand.Next(100); // 0-99
            double percentChange = 0;

            // 👇 Flip a coin for direction if no momentum
            bool continueMomentum = (lastDirection != 0) && (rand.NextDouble() < momentumProbability);

            int directionToUse;

            if (continueMomentum)
            {
                directionToUse = lastDirection; // keep going same way
                momentumProbability /= 2.0;     // drop chance to continue again next tick
            }
            else
            {
                directionToUse = (rand.Next(2) == 0) ? 1 : -1; // random up or down
                momentumProbability = 0.5;                     // reset momentum back to 50%
            }

            // 🎯 Apply percent change based on chance
            if (chance < 1)
            {
                // 💥 1% chance of massive 50% move
                percentChange = directionToUse * 0.50;
            }
            else if (chance < 5)
            {
                // 🔥 4% chance of big 25% move
                percentChange = directionToUse * 0.25;
            }
            else if (chance < 10)
            {
                // ⚠️ 5% chance of medium 12.5% move
                percentChange = directionToUse * 0.125;
            }
            else
            {
                // 📈 95% chance of small movement (0.5% to 2.5%)
                percentChange = directionToUse * (0.005 + rand.NextDouble() * 0.02);
            }

            // 📊 Add base drift and time-based trend
            percentChange += baseDrift + timeFactor;

            // 🧮 Calculate new price
            double price = lastPrice * (1 + percentChange);
            if (price < 1) price = 1;

            // 📉 Add new data point to chart
            int index = chart1.Series["Series1"].Points.AddXY(now, price);
            chart1.Series["Series1"].Points[index].Color = price >= lastPrice ? Color.Green : Color.Red;

            // 🔁 Save direction for next time
            lastDirection = (price >= lastPrice) ? 1 : -1;
            lastPrice = price;

            // 🧹 Keep last 30 points
            if (chart1.Series["Series1"].Points.Count > 100)
                chart1.Series["Series1"].Points.RemoveAt(0);

            // ⏱ Update X axis range
            var area = chart1.ChartAreas["MainArea"];
            area.AxisX.Minimum = chart1.Series["Series1"].Points[0].XValue;
            area.AxisX.Maximum = chart1.Series["Series1"].Points[chart1.Series["Series1"].Points.Count - 1].XValue;

            // 💬 Update UI
            UpdateWorthLabel();
            UpdateWalletLabel();
            lbl_how_much_wortyh.Text = lastPrice.ToString("C2");
        }



        private void Timer_Tick(object sender, EventArgs e)
        {
            PushRandomData();
        }

        private void UpdateOwnedLabel()
        {
            lbl_how_many_i_have_bought.Text = $"Owned: {stocksOwned}";
        }

        private void UpdateWorthLabel()
        {
            double worth = stocksOwned * lastPrice;
            LBL_HOW_MUCH_THEY_WORTH.Text = $"Worth: {worth:C2}";
        }

        private void UpdateWalletLabel()
        {
            double totalValue = wallet + stocksOwned * lastPrice;

            double Perc = (totalValue / 10000) * 100;

            lbl_wallet.Text = $"{totalValue:C2}";
            lbl_nmy_score_gain_or_loss.Text = $"{Perc:F2}%";

            if (totalValue >= initialWallet)
                lbl_wallet.ForeColor = Color.Green;
            else
                lbl_wallet.ForeColor = Color.Red;

            if (Perc >= 100)
                lbl_nmy_score_gain_or_loss.ForeColor = Color.Green;
            else
                lbl_nmy_score_gain_or_loss.ForeColor = Color.Red;
        }

        // Your other empty event handlers remain unchanged...
        private void chart1_Click(object sender, EventArgs e) { }
        private void LBL_HOW_MUCH_THEY_WORTH_Click(object sender, EventArgs e) { }
        private void lbl_how_many_i_have_bought_Click(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        private void lbl_how_much_wortyh_Click(object sender, EventArgs e) { }

        private void panel3_Paint(object sender, PaintEventArgs e) { }
    }
}
