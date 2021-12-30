using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coursework
{
    public partial class mainPage : Form
    {
        public mainPage()
        {
            InitializeComponent();
        }
        string role = "";

        private void logIn_Click(object sender, EventArgs e)
        {
            string adminusername = "sujata";
            string adminpassword = "acharya";

            string staffusername = "staff";
            string staffpassword = "test";

            string username = username_tb.Text;
            string password = password_tb.Text;

            if (username.Equals(""))
            {
                MessageBox.Show("Enter username");
                username_tb.Focus();
                return;

            }
            else if (password.Equals(""))
            {
                MessageBox.Show("Enter password");
                password_tb.Focus();
                return;

            }
            else if (role.Equals(""))
            {
                MessageBox.Show("Select your role");
                rolecombo.Focus();
                return;
            }
            else
            {
                if (username.Equals(adminusername) && password.Equals(adminpassword) && role.Equals("Admin") || username.Equals(staffusername) && password.Equals(staffpassword) && role.Equals("Staff"))
                {

                    homepanel.BringToFront();
                }
                else
                {
                    MessageBox.Show("Invalid login attempt");
                }
            }

        }

        private void rolecombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            role = "";
            role += rolecombo.SelectedItem;
        }

        private void mainPage_Load(object sender, EventArgs e)
        {
            loginpanel.BringToFront();

        }

        private void customercheckoutlbl_Click(object sender, EventArgs e)
        {
            CustomerCheckout customerCheckout = new CustomerCheckout();
            customerCheckout.Show();
            
        }

        private void ticketpricing_Click(object sender, EventArgs e)
        {
            Rate rate = new Rate();
            rate.Show();
        }

        private void reportlbl_Click(object sender, EventArgs e)
        {
            WeeklyReport weekly = new WeeklyReport();
            weekly.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            DayReport dayReport = new DayReport();
            dayReport.Show();
        }
    }   
}
