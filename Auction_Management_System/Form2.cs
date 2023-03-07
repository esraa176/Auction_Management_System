using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace Auction_Management_System
{
    public partial class Form2 : Form
    {
        OracleDataAdapter adapter;
        OracleDataAdapter adapter1;
        DataSet ds;
        DataSet ds1;
        string ord = "Data Source=oracle;User Id=scott;Password=tiger;";
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string estr = "select ITEM_NAME,categoryName,USER_TYPE from Auction_items a,users_history uh,categories where categories.categoryid=a.categoryid  and a.item_id=uh.item_id and uh.user_id=:n and (a.seller_id=uh.user_id OR a.buyer_id=uh.user_id)";
            adapter = new OracleDataAdapter(estr, ord);
            adapter.SelectCommand.Parameters.Add("n", textBox1.Text);
            ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string estrm = "select Item_Name,ITEM_ID,deadline from auction_items a where a.seller_id=:id and auction_status='pending'";
            adapter1 = new OracleDataAdapter(estrm, ord);
            adapter1.SelectCommand.Parameters.Add("n", textBox1.Text);
            ds1 = new DataSet();
            adapter1.Fill(ds1);
            dataGridView1.DataSource = ds1.Tables[0];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OracleCommandBuilder c = new OracleCommandBuilder(adapter1);
            adapter1.Update(ds1.Tables[0]);
        }

        private void mainFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainForm f = new mainForm();
            f.Show();
        }

        private void createAuctionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
        }

        private void searchForItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3(4);
            f.Show();
        }

        private void showReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 f = new Form4();
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

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
