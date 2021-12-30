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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Save_Click(object sender, EventArgs e)
        {
            
            string childone_hr = one_hr.Text;
            string childtwo_hr = two_hr.Text;
            string childthree_hr = three_hr.Text;
            string childfour_hr = four_hr.Text;
            string childfive_hr = five_hr.Text;
            string childsix_hr = six_hr.Text;
            string childseven_hr = seven_hr.Text;
            string childeight_hr = eight_hr.Text;

            string adultone_hr = adultOneHr_tb.Text;
            string adulttwo_hr = adultTwoHr_tb.Text;
            string adultthree_hr = adultThreeHr_tb.Text;
            string adultfour_hr = adultFourHr_tb.Text;
            string adultfive_hr = adultFiveHr_tb.Text;
            string adultsix_hr = adultSixHr_tb.Text;
            string adultseven_hr = adultSevenHr_tb.Text;
            string adulteight_hr = adultEightHr_tb.Text;




            var csv = new StringBuilder();
            if (!File.Exists(path))
            {
                string headings = string.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8}","Hour", "One hr", "Two hr", "Three hr", "Four hr", "Five hr", "Six hr", "Seven hr", "Eight hr");
                csv.AppendLine(headings);
            }


            string childrates = string.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8}","ChildRates", childone_hr, childtwo_hr,childthree_hr,childfour_hr,childfive_hr,childsix_hr,childseven_hr,childeight_hr);
            string adultrates = string.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8}","AdultRates", adultone_hr, adulttwo_hr, adultthree_hr, adultfour_hr, adultfive_hr, adultsix_hr, adultseven_hr, adulteight_hr);
            csv.AppendLine(childrates);
            csv.AppendLine(adultrates);
            File.WriteAllText(path, csv.ToString());
            MessageBox.Show("Successfully saved");
        }


        public void readData()
        {
            DataTable dt = new DataTable();
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

        private void Rate_Load(object sender, EventArgs e)
        {
            readData();
        }

       
    }
}
