
namespace Coursework
{
    partial class mainPage
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rolecombo = new System.Windows.Forms.ComboBox();
            this.logIn = new System.Windows.Forms.Button();
            this.password_tb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.username_tb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.homepanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.reportlbl = new System.Windows.Forms.Label();
            this.ticketpricing = new System.Windows.Forms.Label();
            this.customercheckoutlbl = new System.Windows.Forms.Label();
            this.homepagelbl = new System.Windows.Forms.Label();
            this.loginpanel = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.homepanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.loginpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(323, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Log In Page";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightCyan;
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.rolecombo);
            this.groupBox1.Controls.Add(this.logIn);
            this.groupBox1.Controls.Add(this.password_tb);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.username_tb);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(268, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(288, 248);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Role";
            // 
            // rolecombo
            // 
            this.rolecombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rolecombo.FormattingEnabled = true;
            this.rolecombo.Items.AddRange(new object[] {
            "Admin",
            "Staff"});
            this.rolecombo.Location = new System.Drawing.Point(111, 133);
            this.rolecombo.Name = "rolecombo";
            this.rolecombo.Size = new System.Drawing.Size(121, 21);
            this.rolecombo.TabIndex = 5;
            this.rolecombo.SelectedIndexChanged += new System.EventHandler(this.rolecombo_SelectedIndexChanged);
            // 
            // logIn
            // 
            this.logIn.ForeColor = System.Drawing.SystemColors.Highlight;
            this.logIn.Location = new System.Drawing.Point(111, 197);
            this.logIn.Name = "logIn";
            this.logIn.Size = new System.Drawing.Size(75, 23);
            this.logIn.TabIndex = 4;
            this.logIn.Text = "LogIn";
            this.logIn.UseVisualStyleBackColor = true;
            this.logIn.Click += new System.EventHandler(this.logIn_Click);
            // 
            // password_tb
            // 
            this.password_tb.Location = new System.Drawing.Point(111, 81);
            this.password_tb.Name = "password_tb";
            this.password_tb.Size = new System.Drawing.Size(134, 20);
            this.password_tb.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            // 
            // username_tb
            // 
            this.username_tb.Location = new System.Drawing.Point(111, 35);
            this.username_tb.Name = "username_tb";
            this.username_tb.Size = new System.Drawing.Size(134, 20);
            this.username_tb.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Username";
            // 
            // homepanel
            // 
            this.homepanel.Controls.Add(this.panel1);
            this.homepanel.Location = new System.Drawing.Point(0, 0);
            this.homepanel.Name = "homepanel";
            this.homepanel.Size = new System.Drawing.Size(797, 446);
            this.homepanel.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.reportlbl);
            this.panel1.Controls.Add(this.ticketpricing);
            this.panel1.Controls.Add(this.customercheckoutlbl);
            this.panel1.Controls.Add(this.homepagelbl);
            this.panel1.Location = new System.Drawing.Point(4, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(791, 76);
            this.panel1.TabIndex = 0;
            // 
            // reportlbl
            // 
            this.reportlbl.AutoSize = true;
            this.reportlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportlbl.Location = new System.Drawing.Point(473, 31);
            this.reportlbl.Name = "reportlbl";
            this.reportlbl.Size = new System.Drawing.Size(109, 20);
            this.reportlbl.TabIndex = 3;
            this.reportlbl.Text = "weekly Report";
            this.reportlbl.Click += new System.EventHandler(this.reportlbl_Click);
            // 
            // ticketpricing
            // 
            this.ticketpricing.AutoSize = true;
            this.ticketpricing.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ticketpricing.Location = new System.Drawing.Point(359, 31);
            this.ticketpricing.Name = "ticketpricing";
            this.ticketpricing.Size = new System.Drawing.Size(102, 20);
            this.ticketpricing.TabIndex = 2;
            this.ticketpricing.Text = "Ticket Pricing";
            this.ticketpricing.Click += new System.EventHandler(this.ticketpricing_Click);
            // 
            // customercheckoutlbl
            // 
            this.customercheckoutlbl.AutoSize = true;
            this.customercheckoutlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customercheckoutlbl.Location = new System.Drawing.Point(198, 30);
            this.customercheckoutlbl.Name = "customercheckoutlbl";
            this.customercheckoutlbl.Size = new System.Drawing.Size(150, 20);
            this.customercheckoutlbl.TabIndex = 1;
            this.customercheckoutlbl.Text = "Customer Checkout";
            this.customercheckoutlbl.Click += new System.EventHandler(this.customercheckoutlbl_Click);
            // 
            // homepagelbl
            // 
            this.homepagelbl.AutoSize = true;
            this.homepagelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homepagelbl.Location = new System.Drawing.Point(8, 20);
            this.homepagelbl.Name = "homepagelbl";
            this.homepagelbl.Size = new System.Drawing.Size(156, 31);
            this.homepagelbl.TabIndex = 0;
            this.homepagelbl.Text = "Home Page";
            // 
            // loginpanel
            // 
            this.loginpanel.Controls.Add(this.groupBox1);
            this.loginpanel.Controls.Add(this.label1);
            this.loginpanel.Location = new System.Drawing.Point(0, 0);
            this.loginpanel.Name = "loginpanel";
            this.loginpanel.Size = new System.Drawing.Size(795, 445);
            this.loginpanel.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(597, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Daily Report";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // mainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.homepanel);
            this.Controls.Add(this.loginpanel);
            this.Name = "mainPage";
            this.Text = "mainPage";
            this.Load += new System.EventHandler(this.mainPage_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.homepanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.loginpanel.ResumeLayout(false);
            this.loginpanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox username_tb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox password_tb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button logIn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox rolecombo;
        private System.Windows.Forms.Panel homepanel;
        private System.Windows.Forms.Panel loginpanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label reportlbl;
        private System.Windows.Forms.Label ticketpricing;
        private System.Windows.Forms.Label customercheckoutlbl;
        private System.Windows.Forms.Label homepagelbl;
        private System.Windows.Forms.Label label5;
    }
}