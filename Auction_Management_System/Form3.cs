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
    public partial class Form3 : Form
    {
        int UserID;
        OracleDataAdapter adapter;
        DataSet ds;
        OracleConnection conn;
        string ordb;
        public Form3(int idd)
        {
            InitializeComponent();
            this.UserID = idd;
            ordb = "data source=oracle; user id=scott; password=tiger;";
            textBox1.Enabled = false;
            comboBox1.Enabled = false;
            conn = new OracleConnection(ordb);
            conn.Open();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            OracleCommand cmd1 = new OracleCommand();
            cmd1.Connection = conn;
            cmd1.CommandText = "UPDATE AUCTION_ITEMS set AUCTION_STATUS=\'finished\' where deadline<SYSDATE";
            cmd1.ExecuteNonQuery();
            string str = "select item_id, item_name,current_price,DEADLINE,CATEGORYNAME FROM auction_items au, categories cat where au.AUCTION_STATUS = 'pending' and au.CATEGORYID = cat.CATEGORYID";
            adapter = new OracleDataAdapter(str, ordb);
            ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];


            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "GETITEMCAT";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("items", OracleDbType.RefCursor, ParameterDirection.Output);
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr[0]);
            }
            dr.Close();
            itemID_cmp.Items.Clear();
            itemID_cmp.Text = "";
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                itemID_cmp.Items.Add(row["item_id"]);
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            comboBox1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "GETCURRENTPRICE";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("id", itemID_cmp.SelectedItem);
            cmd.Parameters.Add("currentPrice", OracleDbType.Int32, ParameterDirection.Output);
            cmd.ExecuteNonQuery();
            int currentPrice = Convert.ToInt32(cmd.Parameters["currentPrice"].Value.ToString());
            if (currentPrice >= Convert.ToInt32(bidPrice.Text))
            {
                MessageBox.Show("Please Enter price more than " + currentPrice);
            }
            else
            {
                OracleCommand cmd1 = new OracleCommand();
                cmd1.Connection = conn;
                cmd1.CommandText = "UPDATE AUCTION_ITEMS set current_price=:currentPrice,buyer_id=:UserId where item_id=:id";
                cmd1.Parameters.Add("price", Convert.ToInt32(bidPrice.Text));
                cmd1.Parameters.Add("userid", UserID);
                cmd1.Parameters.Add("id", itemID_cmp.SelectedItem);
                cmd1.ExecuteNonQuery();
                MessageBox.Show("Bid Successful");
                string str = "select item_id, item_name,current_price,DEADLINE,CATEGORYNAME FROM auction_items au, categories cat where au.AUCTION_STATUS = 'pending' and au.CATEGORYID = cat.CATEGORYID";
                adapter = new OracleDataAdapter(str, ordb);
                ds = new DataSet();
                adapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str;
            if (radioButton1.Checked)
            {
                //category

                str = "select item_id, item_name,current_price ,DEADLINE,CATEGORYNAME FROM auction_items au, categories cat where au.CATEGORYID = cat.CATEGORYID and cat.CATEGORYNAME = :cat and au.AUCTION_STATUS = 'pending'";
                adapter = new OracleDataAdapter(str, ordb);
                adapter.SelectCommand.Parameters.Add("cat", comboBox1.SelectedItem);

            }
            else
            {
                // By name
                str = "select item_id, item_name,current_price,DEADLINE,CATEGORYNAME FROM auction_items au, categories cat where au.item_name = :name and au.AUCTION_STATUS = 'pending' and  au.CATEGORYID = cat.CATEGORYID";
                adapter = new OracleDataAdapter(str, ordb);
                adapter.SelectCommand.Parameters.Add("name", textBox1.Text);

            }
            ds = new DataSet();
            adapter.Fill(ds);
            if (ds.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("Not found");
            }
            else
            {
                dataGridView1.DataSource = ds.Tables[0];
                itemID_cmp.Items.Clear();
                itemID_cmp.Text = "";
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    itemID_cmp.Items.Add(row["item_id"]);
                }
            }
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            comboBox1.Enabled = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

        private void showHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
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
    }
}
