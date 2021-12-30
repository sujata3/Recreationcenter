using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coursework
{
    public partial class CustomerCheckout : Form
    {
        public CustomerCheckout()
        {
            InitializeComponent();
        }


        int childonehrrate = 0;
        int adultonehrrate = 0;

        IDictionary<int, string> childratecollection = new Dictionary<int, string>();
        IDictionary<int, string> adultratecollection = new Dictionary<int, string>();
        //IDictionary<int, string> groupcount = new Dictionary<int, string>();


        double hourscalcualation = 0;
        double totalamount = 0;
        int totalperson = 0;
        int groupnumber = 0;

        public void receiveticketprice()
        {
            string path = "childandadultrates.csv";
            //string filepath2 = "C:\\Users\\Toshiba\\Desktop\\College Final Year\\Application Development\\CourseWork\\GroupRates.csv";

            string[] line = null;

            
            if (File.Exists(path))
            {
                line = File.ReadAllLines(path);

                if (line.Length == 3)
                {
                    string childrates = line[1];
                    string[] childratearray = childrates.Split(',');

                    string adultrates = line[2];
                    string[] adultratearray = adultrates.Split(',');


                    childonehrrate = Int32.Parse(childratearray[1]);
                    adultonehrrate = Int32.Parse(adultratearray[1]);


                }
            }
        }
        private void checkout_btn_Click(object sender, EventArgs e)
        {
            string childcount = child_tb.Text;
            string adultcount = adult_tb.Text;
            string intime = inTime_tb.Text;
            string outtime = outTime_tb.Text;

            DateTime enter = DateTime.Parse(intime);
            DateTime end = DateTime.Parse(outtime);

            string integervaluepattern = @"(^[0-9]{1,2}$)";
            Regex regex1 = new Regex(integervaluepattern);

            string timepattern = @"(^[0-9]{1,2}:[0-9]{1,2}$)";
            Regex regex2 = new Regex(timepattern);

            if (individual_rb.Checked)
            {
                if (!regex1.IsMatch(childcount))
                {
                    MessageBox.Show("Value for child is invalid");
                    return;
                }
                else if (!regex1.IsMatch(adultcount))
                {
                    MessageBox.Show("Value for child is invalid");
                    return;
                }
            }

            if (!regex2.IsMatch(intime))
            {
                MessageBox.Show("Invalid time format");
                return;
            }
            else if (!regex2.IsMatch(outtime))
            {
                MessageBox.Show("Invalid time format");
                return;
            }

            else
            {

                hourscalcualation = (end - enter).TotalHours;

                hour_tb.Text = hourscalcualation.ToString();


                if (group_rb.Checked)
                {
                    //int groupnumber = Int32.Parse(groupnumbercombo.Text);
                    //double discount = ((Int32.Parse(groupcount[groupnumber]) * hours) * (groupnumber / 100d));

                    //totalprice = Math.Round((Int32.Parse(groupcount[groupnumber]) * hours) - discount);
                    //totaltxt.Text = totalprice.ToString();
                    //personCount = Int32.Parse(groupnumbercombo.Text);
                    //personingroup = personCount;

                }
                else
                {
                    int totalnumberofchild = Int32.Parse(childcount);
                    int totalnumberofadult = Int32.Parse(adultcount);


                    if (childonehrrate != 0 && adultonehrrate != 0)
                    {

                        totalamount = Math.Round((hourscalcualation * totalnumberofchild * childonehrrate) + (hourscalcualation * totalnumberofadult * adultonehrrate));
                        total_tb.Text = totalamount.ToString();
                        totalperson = totalnumberofchild + totalnumberofadult;
                        groupnumber = 0;
                        MessageBox.Show("Saved Successffully");
                    }
                    else
                    {
                        MessageBox.Show("Please set ticket price before calculation");
                    }
                }
            }
        }

        private void CustomerCheckout_Load(object sender, EventArgs e)
        {
            receiveticketprice();

            if (individual_rb.Checked)
            {
                panel2.Show();
                groupnumber_cb.Hide();
            }
          
        }

        private void individual_rb_CheckedChanged(object sender, EventArgs e)
        {
            panel2.Show();
            groupnumber_cb.Hide();
        }

        private void group_rb_CheckedChanged(object sender, EventArgs e)
        {
            panel2.Hide();
            groupnumber_cb.Show();
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            string childcount = child_tb.Text;
            string adultcount = adult_tb.Text;
            string intime = inTime_tb.Text;
            string outtime = outTime_tb.Text;

            string visitorName = name_tb.Text;
            string visitorAge = age_tb.Text;
            string visitorAddress = adrs_tb.Text;
            string visitorContact = contact_tb.Text;

            var customerId = Guid.NewGuid().ToString();

            var visitdate = DateTime.Now.ToString();

            string entrrytype = "";

            if (individual_rb.Checked)
            {
                entrrytype = "Individual";
            }
            else
            {
                entrrytype = "Group";
            }


            if (string.IsNullOrEmpty(visitorName) || string.IsNullOrEmpty(visitorAge) || string.IsNullOrEmpty(visitorAddress) || string.IsNullOrEmpty(visitorContact))
            {
                MessageBox.Show("Visitor details cant be empty");
                return;
            }

            string path = "checkout.csv";
            string path2 = "visitordetails.csv";
            var line1 = string.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10}", customerId, adultcount, childcount, groupnumber, entrrytype, totalperson, intime, outtime, hourscalcualation, totalamount, visitdate);
            var line2 = string.Format("{0},{1},{2},{3},{4}", customerId, visitorName, visitorAge, visitorAddress, visitorContact);

            var stringBuilder1 = new StringBuilder();
            var stringBuilder2 = new StringBuilder();

            if (!File.Exists(path) && !File.Exists(path2))
            {
                var heading1 = string.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10}", "Customer ID", "Adult", "Child", "Group", "Type", "Person count", "In Time", "Out Time", "Total Hours", "Amount", "Visit Date");
                var heading2 = string.Format("{0},{1},{2},{3},{4}", "Customer ID", "Name", "Age", "Address", "Contact");

                stringBuilder1.AppendLine(heading1);
                stringBuilder2.AppendLine(heading2);

            }

            stringBuilder1.AppendLine(line1);
            stringBuilder2.AppendLine(line2);

            File.AppendAllText(path, stringBuilder1.ToString());
            File.AppendAllText(path2, stringBuilder2.ToString());

            inTime_tb.Clear();
            outTime_tb.Clear();
            hour_tb.Clear();
            total_tb.Clear();
            hour_tb.Clear();
            child_tb.Text = "0";
            adult_tb.Text = "0";
        }
    }
}
