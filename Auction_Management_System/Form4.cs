using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.Shared;

namespace Auction_Management_System
{
    public partial class Form4 : Form
    {
        Report1 report1;
        Report2 report2;
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            report1 = new Report1();
            report2 = new Report2();
            foreach (ParameterDiscreteValue v in report1.ParameterFields[0].DefaultValues)
            {
                categoryName_cmb.Items.Add(v.Value);
            }
        }

        private void viewItems_btn_Click(object sender, EventArgs e)
        {
            report1.SetParameterValue(0, categoryName_cmb.Text);
            crystalReportViewer1.ReportSource = report1;
        }

        private void viewTransaction_btn_Click(object sender, EventArgs e)
        {
            crystalReportViewer1.ReportSource = report2;
        }

        private void createAuctionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainForm f = new mainForm();
            f.Show();
        }

        private void createAuctionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
        }

        private void showHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
        }

        private void searchForItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3(4);
            f.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
