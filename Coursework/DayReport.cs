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
    public partial class DayReport : Form
    {
        public DayReport()
        {
            InitializeComponent();
        }

        private void DayReport_Load(object sender, EventArgs e)
        {
            string path = "checkout.csv";
            DataTable datatable = new DataTable();
            if (File.Exists(path))
            {
                string[] data = File.ReadAllLines(path);
                if (data.Length > 0)
                {
                    string firstLine = data[0];
                    string[] headerlabels = { "No of Child", "No Of Adult", "Person in Group" };
                    foreach (string headerword in headerlabels)
                    {
                        datatable.Columns.Add(new DataColumn(headerword));
                    }
                    for (int i = 1; i < data.Length; i++)
                    {
                        string[] datawords = data[i].Split(',');
                        DataRow dr = datatable.NewRow();

                        dr["No Of Adult"] = datawords[1];
                        dr["No of Child"] = datawords[2];
                        dr["Person in Group"] = datawords[3];

                        datatable.Rows.Add(dr);
                    }
                }

                if (datatable.Rows.Count > 0)
                {
                    dailyReport.DataSource = datatable;
                }
            }
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
