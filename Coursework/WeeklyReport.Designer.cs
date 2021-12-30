
namespace Coursework
{
    partial class WeeklyReport
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.weeklychart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.weeklychart)).BeginInit();
            this.SuspendLayout();
            // 
            // weeklychart
            // 
            chartArea1.Name = "ChartArea1";
            this.weeklychart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.weeklychart.Legends.Add(legend1);
            this.weeklychart.Location = new System.Drawing.Point(12, 61);
            this.weeklychart.Name = "weeklychart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Visitors";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Earning";
            this.weeklychart.Series.Add(series1);
            this.weeklychart.Series.Add(series2);
            this.weeklychart.Size = new System.Drawing.Size(876, 377);
            this.weeklychart.TabIndex = 0;
            this.weeklychart.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(342, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Weekly Report";
            // 
            // WeeklyReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.weeklychart);
            this.Name = "WeeklyReport";
            this.Text = "WeeklyReport";
            this.Load += new System.EventHandler(this.WeeklyReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.weeklychart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart weeklychart;
        private System.Windows.Forms.Label label1;
    }
}