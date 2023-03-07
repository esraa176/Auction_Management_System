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
    public partial class Form1 : Form
    {
        string ordb = "Data source=oracle;User Id=scott;Password=tiger;"; 
        OracleConnection conn;        OracleDataAdapter adapter;
        OracleCommandBuilder c;
        DataSet ds;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand c = new OracleCommand();            c.Connection = conn;
            c.CommandText = "select CATEGORYNAME from categories";
            c.CommandType = CommandType.Text;
            OracleDataReader dr = c.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr[0]);
            }
            dr.Close();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now.AddDays(10);
            OracleCommand cmd = new OracleCommand();            cmd.Connection = conn;            cmd.CommandText = "insert into AUCTION_ITEMS (ITEM_ID,initial_price,item_name,CURRENT_PRICE,SELLER_ID,deadline,categoryid,auction_status)values (ITEM_ID.nextval,:initial_price,:item_name,:CURRENT_PRICE,:SELLER_ID,:deadline,:categoryid,'pending')";            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("initial_price", textBox2.Text);
            cmd.Parameters.Add("item_name", textBox1.Text);
            cmd.Parameters.Add("CURRENT_PRICE", textBox2.Text);
            cmd.Parameters.Add("SELLER_ID", id_textbox.Text);
            cmd.Parameters.Add("deadline", date);
            if (comboBox1.SelectedItem.ToString() == "cars")
            {
                cmd.Parameters.Add("categoryid", '1');
            }
            else if (comboBox1.SelectedItem.ToString() == "furniture")
            {
                cmd.Parameters.Add("categoryid", '2');
            }
            else if (comboBox1.SelectedItem.ToString() == "jewelery")
            {
                cmd.Parameters.Add("categoryid", '3');
            }
            else if (comboBox1.SelectedItem.ToString() == "antiques")
            {
                cmd.Parameters.Add("categoryid", '4');
            }
            else if (comboBox1.SelectedItem.ToString() == "paintings")
            {
                cmd.Parameters.Add("categoryid", '5');
            }
            else if (comboBox1.SelectedItem.ToString() == "clothes")
            {
                cmd.Parameters.Add("categoryid", '6');
            }

            int r = cmd.ExecuteNonQuery();
            if(r!=-1)
            {
                MessageBox.Show("Creating Auction is Successed!");
            }
            OracleCommand cm = new OracleCommand();            cm.Connection = conn;
            cm.CommandType = CommandType.Text;
            cm.CommandText = "insert into users_history (USER_ID,ITEM_ID,USER_TYPE) values(:user_id,item_id.currval,'seller')";
            cm.Parameters.Add("user_id", id_textbox.Text);
            int rr = cm.ExecuteNonQuery();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void id_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void mainFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainForm f = new mainForm();
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
