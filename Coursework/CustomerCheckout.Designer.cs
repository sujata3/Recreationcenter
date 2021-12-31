
namespace Coursework
{
    partial class CustomerCheckout
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
            this.components = new System.ComponentModel.Container();
            this.name = new System.Windows.Forms.Label();
            this.name_tb = new System.Windows.Forms.TextBox();
            this.Age = new System.Windows.Forms.Label();
            this.age_tb = new System.Windows.Forms.TextBox();
            this.address = new System.Windows.Forms.Label();
            this.adrs_tb = new System.Windows.Forms.TextBox();
            this.contact = new System.Windows.Forms.Label();
            this.contact_tb = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.adult_tb = new System.Windows.Forms.TextBox();
            this.adult = new System.Windows.Forms.Label();
            this.child_tb = new System.Windows.Forms.TextBox();
            this.child = new System.Windows.Forms.Label();
            this.checkout_btn = new System.Windows.Forms.Button();
            this.save_btn = new System.Windows.Forms.Button();
            this.groupnumber_cb = new System.Windows.Forms.ComboBox();
            this.total_tb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.hour_tb = new System.Windows.Forms.TextBox();
            this.hour = new System.Windows.Forms.Label();
            this.outTime_tb = new System.Windows.Forms.TextBox();
            this.out_time = new System.Windows.Forms.Label();
            this.inTime_tb = new System.Windows.Forms.TextBox();
            this.in_time = new System.Windows.Forms.Label();
            this.group_rb = new System.Windows.Forms.RadioButton();
            this.individual_rb = new System.Windows.Forms.RadioButton();
            this.type = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.backbtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(25, 251);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(80, 20);
            this.name.TabIndex = 0;
            this.name.Text = "Full Name";
            // 
            // name_tb
            // 
            this.name_tb.Location = new System.Drawing.Point(111, 241);
            this.name_tb.Multiline = true;
            this.name_tb.Name = "name_tb";
            this.name_tb.Size = new System.Drawing.Size(133, 30);
            this.name_tb.TabIndex = 1;
            // 
            // Age
            // 
            this.Age.AutoSize = true;
            this.Age.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Age.Location = new System.Drawing.Point(271, 251);
            this.Age.Name = "Age";
            this.Age.Size = new System.Drawing.Size(38, 20);
            this.Age.TabIndex = 2;
            this.Age.Text = "Age";
            // 
            // age_tb
            // 
            this.age_tb.Location = new System.Drawing.Point(315, 241);
            this.age_tb.Multiline = true;
            this.age_tb.Name = "age_tb";
            this.age_tb.Size = new System.Drawing.Size(77, 30);
            this.age_tb.TabIndex = 3;
            // 
            // address
            // 
            this.address.AutoSize = true;
            this.address.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address.Location = new System.Drawing.Point(424, 251);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(68, 20);
            this.address.TabIndex = 4;
            this.address.Text = "Address";
            // 
            // adrs_tb
            // 
            this.adrs_tb.Location = new System.Drawing.Point(498, 241);
            this.adrs_tb.Multiline = true;
            this.adrs_tb.Name = "adrs_tb";
            this.adrs_tb.Size = new System.Drawing.Size(133, 30);
            this.adrs_tb.TabIndex = 5;
            // 
            // contact
            // 
            this.contact.AutoSize = true;
            this.contact.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contact.Location = new System.Drawing.Point(25, 310);
            this.contact.Name = "contact";
            this.contact.Size = new System.Drawing.Size(65, 20);
            this.contact.TabIndex = 6;
            this.contact.Text = "Contact";
            // 
            // contact_tb
            // 
            this.contact_tb.Location = new System.Drawing.Point(111, 300);
            this.contact_tb.Multiline = true;
            this.contact_tb.Name = "contact_tb";
            this.contact_tb.Size = new System.Drawing.Size(133, 30);
            this.contact_tb.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.checkout_btn);
            this.panel1.Controls.Add(this.save_btn);
            this.panel1.Controls.Add(this.groupnumber_cb);
            this.panel1.Controls.Add(this.total_tb);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.hour_tb);
            this.panel1.Controls.Add(this.hour);
            this.panel1.Controls.Add(this.outTime_tb);
            this.panel1.Controls.Add(this.out_time);
            this.panel1.Controls.Add(this.inTime_tb);
            this.panel1.Controls.Add(this.in_time);
            this.panel1.Controls.Add(this.group_rb);
            this.panel1.Controls.Add(this.individual_rb);
            this.panel1.Controls.Add(this.type);
            this.panel1.Location = new System.Drawing.Point(1, 365);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 256);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.adult_tb);
            this.panel2.Controls.Add(this.adult);
            this.panel2.Controls.Add(this.child_tb);
            this.panel2.Controls.Add(this.child);
            this.panel2.Location = new System.Drawing.Point(361, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(253, 97);
            this.panel2.TabIndex = 26;
            // 
            // adult_tb
            // 
            this.adult_tb.Location = new System.Drawing.Point(159, 51);
            this.adult_tb.Multiline = true;
            this.adult_tb.Name = "adult_tb";
            this.adult_tb.Size = new System.Drawing.Size(77, 30);
            this.adult_tb.TabIndex = 22;
            this.adult_tb.Text = "0";
            // 
            // adult
            // 
            this.adult.AutoSize = true;
            this.adult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adult.Location = new System.Drawing.Point(14, 61);
            this.adult.Name = "adult";
            this.adult.Size = new System.Drawing.Size(124, 20);
            this.adult.TabIndex = 21;
            this.adult.Text = "Number of Adult";
            // 
            // child_tb
            // 
            this.child_tb.Location = new System.Drawing.Point(159, 14);
            this.child_tb.Multiline = true;
            this.child_tb.Name = "child_tb";
            this.child_tb.Size = new System.Drawing.Size(77, 30);
            this.child_tb.TabIndex = 20;
            this.child_tb.Text = "0";
            // 
            // child
            // 
            this.child.AutoSize = true;
            this.child.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.child.Location = new System.Drawing.Point(14, 24);
            this.child.Name = "child";
            this.child.Size = new System.Drawing.Size(122, 20);
            this.child.TabIndex = 19;
            this.child.Text = "Number of Child";
            // 
            // checkout_btn
            // 
            this.checkout_btn.Location = new System.Drawing.Point(522, 181);
            this.checkout_btn.Name = "checkout_btn";
            this.checkout_btn.Size = new System.Drawing.Size(75, 23);
            this.checkout_btn.TabIndex = 25;
            this.checkout_btn.Text = "Checkout";
            this.checkout_btn.UseVisualStyleBackColor = true;
            this.checkout_btn.Click += new System.EventHandler(this.checkout_btn_Click);
            // 
            // save_btn
            // 
            this.save_btn.Location = new System.Drawing.Point(379, 183);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(75, 23);
            this.save_btn.TabIndex = 24;
            this.save_btn.Text = "Save";
            this.save_btn.UseVisualStyleBackColor = true;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // groupnumber_cb
            // 
            this.groupnumber_cb.FormattingEnabled = true;
            this.groupnumber_cb.Items.AddRange(new object[] {
            "5",
            "10",
            "15",
            "20",
            "25"});
            this.groupnumber_cb.Location = new System.Drawing.Point(292, 38);
            this.groupnumber_cb.Name = "groupnumber_cb";
            this.groupnumber_cb.Size = new System.Drawing.Size(48, 21);
            this.groupnumber_cb.TabIndex = 23;
            // 
            // total_tb
            // 
            this.total_tb.Location = new System.Drawing.Point(156, 183);
            this.total_tb.Multiline = true;
            this.total_tb.Name = "total_tb";
            this.total_tb.Size = new System.Drawing.Size(77, 30);
            this.total_tb.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Total";
            // 
            // hour_tb
            // 
            this.hour_tb.Location = new System.Drawing.Point(156, 147);
            this.hour_tb.Multiline = true;
            this.hour_tb.Name = "hour_tb";
            this.hour_tb.Size = new System.Drawing.Size(77, 30);
            this.hour_tb.TabIndex = 16;
            // 
            // hour
            // 
            this.hour.AutoSize = true;
            this.hour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hour.Location = new System.Drawing.Point(47, 157);
            this.hour.Name = "hour";
            this.hour.Size = new System.Drawing.Size(44, 20);
            this.hour.TabIndex = 15;
            this.hour.Text = "Hour";
            // 
            // outTime_tb
            // 
            this.outTime_tb.Location = new System.Drawing.Point(156, 111);
            this.outTime_tb.Multiline = true;
            this.outTime_tb.Name = "outTime_tb";
            this.outTime_tb.Size = new System.Drawing.Size(77, 30);
            this.outTime_tb.TabIndex = 14;
            // 
            // out_time
            // 
            this.out_time.AutoSize = true;
            this.out_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.out_time.Location = new System.Drawing.Point(47, 121);
            this.out_time.Name = "out_time";
            this.out_time.Size = new System.Drawing.Size(73, 20);
            this.out_time.TabIndex = 13;
            this.out_time.Text = "Out Time";
            // 
            // inTime_tb
            // 
            this.inTime_tb.Location = new System.Drawing.Point(156, 74);
            this.inTime_tb.Multiline = true;
            this.inTime_tb.Name = "inTime_tb";
            this.inTime_tb.Size = new System.Drawing.Size(77, 30);
            this.inTime_tb.TabIndex = 9;
            // 
            // in_time
            // 
            this.in_time.AutoSize = true;
            this.in_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.in_time.Location = new System.Drawing.Point(47, 84);
            this.in_time.Name = "in_time";
            this.in_time.Size = new System.Drawing.Size(61, 20);
            this.in_time.TabIndex = 12;
            this.in_time.Text = "In Time";
            // 
            // group_rb
            // 
            this.group_rb.AutoSize = true;
            this.group_rb.Location = new System.Drawing.Point(232, 38);
            this.group_rb.Name = "group_rb";
            this.group_rb.Size = new System.Drawing.Size(54, 17);
            this.group_rb.TabIndex = 11;
            this.group_rb.Text = "Group";
            this.group_rb.UseVisualStyleBackColor = true;
            this.group_rb.CheckedChanged += new System.EventHandler(this.group_rb_CheckedChanged);
            // 
            // individual_rb
            // 
            this.individual_rb.AutoSize = true;
            this.individual_rb.Checked = true;
            this.individual_rb.Location = new System.Drawing.Point(156, 39);
            this.individual_rb.Name = "individual_rb";
            this.individual_rb.Size = new System.Drawing.Size(70, 17);
            this.individual_rb.TabIndex = 10;
            this.individual_rb.TabStop = true;
            this.individual_rb.Text = "Individual";
            this.individual_rb.UseVisualStyleBackColor = true;
            this.individual_rb.CheckedChanged += new System.EventHandler(this.individual_rb_CheckedChanged);
            // 
            // type
            // 
            this.type.AutoSize = true;
            this.type.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.type.Location = new System.Drawing.Point(47, 36);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(84, 20);
            this.type.TabIndex = 9;
            this.type.Text = "Entry Type";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(775, 206);
            this.dataGridView1.TabIndex = 9;
            // 
            // backbtn
            // 
            this.backbtn.Location = new System.Drawing.Point(29, 631);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(75, 23);
            this.backbtn.TabIndex = 27;
            this.backbtn.Text = "Back";
            this.backbtn.UseVisualStyleBackColor = true;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // CustomerCheckout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 666);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.contact_tb);
            this.Controls.Add(this.contact);
            this.Controls.Add(this.adrs_tb);
            this.Controls.Add(this.address);
            this.Controls.Add(this.age_tb);
            this.Controls.Add(this.Age);
            this.Controls.Add(this.name_tb);
            this.Controls.Add(this.name);
            this.Name = "CustomerCheckout";
            this.Text = "CustomerCheckout";
            this.Load += new System.EventHandler(this.CustomerCheckout_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label name;
        private System.Windows.Forms.TextBox name_tb;
        private System.Windows.Forms.Label Age;
        private System.Windows.Forms.TextBox age_tb;
        private System.Windows.Forms.Label address;
        private System.Windows.Forms.TextBox adrs_tb;
        private System.Windows.Forms.Label contact;
        private System.Windows.Forms.TextBox contact_tb;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox outTime_tb;
        private System.Windows.Forms.Label out_time;
        private System.Windows.Forms.TextBox inTime_tb;
        private System.Windows.Forms.Label in_time;
        private System.Windows.Forms.RadioButton group_rb;
        private System.Windows.Forms.RadioButton individual_rb;
        private System.Windows.Forms.Label type;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.TextBox total_tb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox hour_tb;
        private System.Windows.Forms.Label hour;
        private System.Windows.Forms.ComboBox groupnumber_cb;
        private System.Windows.Forms.TextBox adult_tb;
        private System.Windows.Forms.Label adult;
        private System.Windows.Forms.TextBox child_tb;
        private System.Windows.Forms.Label child;
        private System.Windows.Forms.Button checkout_btn;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button backbtn;
    }
}