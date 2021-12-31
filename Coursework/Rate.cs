using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coursework
{
    public partial class Rate : Form
    {
        public Rate()
        {
            InitializeComponent();
        }
        string path = "childandadultrates.csv";
        string group = "grouprates.csv";

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Save_Click(object sender, EventArgs e)
        {
            bool validationstatus = true;

            string childone_hr = one_hr.Text;
            string childtwo_hr = two_hr.Text;
            string childthree_hr = three_hr.Text;
            string childfour_hr = four_hr.Text;
            string childfive_hr = five_hr.Text;
            string childsix_hr = six_hr.Text;
            string childseven_hr = seven_hr.Text;
            string childeight_hr = eight_hr.Text;
            if(childone_hr == ""|| childtwo_hr == "" || childthree_hr == "" || childfour_hr == "" || childfive_hr == "" || childsix_hr == "" || childseven_hr == "" || childeight_hr == "")
            {
                MessageBox.Show("Child Rates cant be empty");
                validationstatus = false;
                return;
            }

            string adultone_hr = adultOneHr_tb.Text;
            string adulttwo_hr = adultTwoHr_tb.Text;
            string adultthree_hr = adultThreeHr_tb.Text;
            string adultfour_hr = adultFourHr_tb.Text;
            string adultfive_hr = adultFiveHr_tb.Text;
            string adultsix_hr = adultSixHr_tb.Text;
            string adultseven_hr = adultSevenHr_tb.Text;
            string adulteight_hr = adultEightHr_tb.Text;
            if (adultone_hr == "" || adulttwo_hr == "" || adultthree_hr == "" || adultfour_hr == "" || adultfive_hr == "" || adultsix_hr == "" || adultseven_hr == "" || adulteight_hr == "")
            {
                MessageBox.Show("Adult Rates cant be empty");
                validationstatus = false;
                return;
            }
            string group5 = group5rate_tb.Text;
            string group10 = group10rate_tb.Text;
            string group15 = group15rate_tb.Text;
            string group20 = group20rate_tb.Text;
            string group25 = group25rate_tb.Text;

            if (group5 == "" || group10 == "" || group15 == "" || group20 == "" || group25 == "")
            {
                MessageBox.Show("Group Rates cant be empty");
                validationstatus = false;
                return;
            }

            if(validationstatus == true)
            {

          
            var csv = new StringBuilder();
            var csv2 = new StringBuilder();
         
            string individualheading = string.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8}","Child/Adult", "One hr", "Two hr", "Three hr", "Four hr", "Five hr", "Six hr", "Seven hr", "Eight hr");          
            csv.AppendLine(individualheading);
          
      
            string groupheading = string.Format("{0},{1},{2},{3},{4},{5}", "Groups", "Group 5", "Group 10", "Group 15", "Group 20", "Group 25");
            csv2.AppendLine(groupheading);

        

            string childrates = string.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8}","ChildRates", childone_hr, childtwo_hr,childthree_hr,childfour_hr,childfive_hr,childsix_hr,childseven_hr,childeight_hr);
            string adultrates = string.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8}","AdultRates", adultone_hr, adulttwo_hr, adultthree_hr, adultfour_hr, adultfive_hr, adultsix_hr, adultseven_hr, adulteight_hr);
            string grouprates = string.Format("{0},{1},{2},{3},{4},{5}", "Rates Per Hour", group5, group10, group15, group20, group25);
            csv.AppendLine(childrates);
            csv.AppendLine(adultrates);
            csv2.AppendLine(grouprates);
            File.WriteAllText(path, csv.ToString());
            File.WriteAllText(group, csv2.ToString());
            MessageBox.Show("Successfully saved");
            readData();
            readGroupData();
            }
        }


        public void readData()
        {
            
            if (File.Exists(path))
            {
                string[] lines = File.ReadAllLines(path);
                if (lines.Length > 0)
                {

                    string childfirstLine = lines[1];
                    string[] childrates = childfirstLine.Split(',');
                    string adultfirstLine = lines[2];
                    string[] adultrates = adultfirstLine.Split(',');


                    one_hr.Text = childrates[1];
                    two_hr.Text = childrates[2];
                    three_hr.Text = childrates[3];
                    four_hr.Text = childrates[4];
                    five_hr.Text = childrates[5];
                    six_hr.Text = childrates[6];
                    seven_hr.Text = childrates[7];
                    eight_hr.Text = childrates[8];

                    adultOneHr_tb.Text = adultrates[1];
                    adultTwoHr_tb.Text = adultrates[2];
                    adultThreeHr_tb.Text = adultrates[3];
                    adultFourHr_tb.Text = adultrates[4];
                    adultFiveHr_tb.Text = adultrates[5];
                    adultSixHr_tb.Text = adultrates[6];
                    adultSevenHr_tb.Text = adultrates[7];
                    adultEightHr_tb.Text = adultrates[8];
                }
            }
            
           
        }


        public void readGroupData()
        {
       
            if (File.Exists(group))
            {
                string[] lines = File.ReadAllLines(group);
                if (lines.Length > 0)
                {

                    string groupfirstline = lines[1];
                    string[] grouprates = groupfirstline.Split(',');
                   


                    group5rate_tb.Text = grouprates[1];
                    group10rate_tb.Text = grouprates[2];
                    group15rate_tb.Text = grouprates[3];
                    group20rate_tb.Text = grouprates[4];
                    group25rate_tb.Text = grouprates[5];
           

                }
            }


        }


        private void Rate_Load(object sender, EventArgs e)
        {
            readData();
            readGroupData();
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            mainPage main = new mainPage();
            this.Hide();
            main.Show();
            main.homepanel.BringToFront();
        }
    }
}
