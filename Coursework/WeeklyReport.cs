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
    public partial class WeeklyReport : Form
    {
        public WeeklyReport()
        {
            InitializeComponent();
        }
        string path = "checkout.csv";
     
        int daypointer = 0;
        int perdayamount = 0;
        string[] readline = null;
        int personcount = 0;
        private void WeeklyReport_Load(object sender, EventArgs e)
        {
            string[] firstrow = null;


            if (File.Exists(path))
            {
                readline = File.ReadAllLines(path);
                if (readline.Length > 1)
                {
                    firstrow = readline[1].Split(',');
                    string datepointer = firstrow[10];

                    DateTime stringtodate = DateTime.Parse(datepointer);
                    
                    for (int a = 1; a < readline.Length; a++)
                    {
                        string[] datawords = readline[a].Split(',');
                        

                        DateTime visitorsdate = DateTime.Parse(datawords[10]);

                        TimeSpan difference = visitorsdate.Subtract(stringtodate);
                        int dayscount = (int)difference.TotalDays;
                        if (dayscount == 0)
                        {
                            personcount += Int32.Parse(datawords[5]);
                            perdayamount += Int32.Parse(datawords[9]);
                            if (a == readline.Length - 1)
                            {
                             

                                weeklychart.Series["Visitors"].Points.AddXY(stringtodate.ToShortDateString(), personcount);
                                weeklychart.Series["Earning"].Points.AddXY(stringtodate.ToShortDateString(), perdayamount);
                            }
                        }


                        else
                        {


                      
                            weeklychart.Series["Visitors"].Points.AddXY(stringtodate.ToShortDateString(), personcount);
                            weeklychart.Series["Earning"].Points.AddXY(stringtodate.ToShortDateString(), perdayamount);
                            personcount = 0;
                            perdayamount = 0;
                            stringtodate = visitorsdate;

                            daypointer++;
                            if (daypointer == 7)
                            {
                                daypointer = 0;
                            }
                            if (a == readline.Length - 1)
                            {
                                personcount += Int32.Parse(datawords[5]);
                                perdayamount += Int32.Parse(datawords[9]);
                              

                                weeklychart.Series["Visitors"].Points.AddXY(stringtodate.ToShortDateString(), personcount);
                                weeklychart.Series["Earning"].Points.AddXY(stringtodate.ToShortDateString(), perdayamount);
                                return;
                            }
                            a--;



                        }


                    }
                }

            }

        }
    }
}
