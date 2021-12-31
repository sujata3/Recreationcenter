
namespace Coursework
{
    partial class DayReport
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
            this.dailyReport = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.backbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dailyReport)).BeginInit();
            this.SuspendLayout();
            // 
            // dailyReport
            // 
            this.dailyReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dailyReport.Location = new System.Drawing.Point(6, 49);
            this.dailyReport.Name = "dailyReport";
            this.dailyReport.Size = new System.Drawing.Size(652, 389);
            this.dailyReport.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(258, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Daily Report";
            // 
            // backbtn
            // 
            this.backbtn.Location = new System.Drawing.Point(47, 460);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(75, 23);
            this.backbtn.TabIndex = 2;
            this.backbtn.Text = "Back";
            this.backbtn.UseVisualStyleBackColor = true;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // DayReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 493);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dailyReport);
            this.Name = "DayReport";
            this.Text = "DayReport";
            this.Load += new System.EventHandler(this.DayReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dailyReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dailyReport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button backbtn;
    }
}