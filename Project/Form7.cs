using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Project
{
    public partial class Form7 : Form
    {
        float btc;
        float eth;
        float bnb;
        float uni;
        float doge;
        private void Form7_Load(object sender, EventArgs e)
        {
            DB db = new DB();

            MySqlCommand command1 = new MySqlCommand("SELECT * FROM `crypto` WHERE `name`='" + label8.Text + "'", db.GetConnection());
            db.openConnection();
            MySqlDataReader dataReader1 = command1.ExecuteReader();
            if (dataReader1.Read())
            {
                textBox7.Text = dataReader1.GetValue(2).ToString();
            }
            db.closeConnection();

            MySqlCommand command2 = new MySqlCommand("SELECT * FROM `crypto` WHERE `name`='" + label9.Text + "'", db.GetConnection());
            db.openConnection();
            MySqlDataReader dataReader2 = command2.ExecuteReader();
            if (dataReader2.Read())
            {
                textBox8.Text = dataReader2.GetValue(2).ToString();
            }
            db.closeConnection();

            MySqlCommand command3 = new MySqlCommand("SELECT * FROM `crypto` WHERE `name`='" + label10.Text + "'", db.GetConnection());
            db.openConnection();
            MySqlDataReader dataReader3 = command3.ExecuteReader();
            if (dataReader3.Read())
            {
                textBox9.Text = dataReader3.GetValue(2).ToString();
            }
            db.closeConnection();

            MySqlCommand command4 = new MySqlCommand("SELECT * FROM `crypto` WHERE `name`='" + label11.Text + "'", db.GetConnection());
            db.openConnection();
            MySqlDataReader dataReader4 = command4.ExecuteReader();
            if (dataReader4.Read())
            {
                textBox10.Text = dataReader4.GetValue(2).ToString();
            }
            db.closeConnection();

            MySqlCommand command5 = new MySqlCommand("SELECT * FROM `crypto` WHERE `name`='" + label12.Text + "'", db.GetConnection());
            db.openConnection();
            MySqlDataReader dataReader5 = command5.ExecuteReader();
            if (dataReader5.Read())
            {
                textBox11.Text = dataReader5.GetValue(2).ToString();
            }
            db.closeConnection();
        }
        public Form7()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float thb = int.Parse(textBox1.Text);
            float pbtc = int.Parse(textBox7.Text);
            float peth = int.Parse(textBox8.Text);
            float pbnb = int.Parse(textBox9.Text);
            float puni = int.Parse(textBox10.Text);
            float pdoge = int.Parse(textBox11.Text);
            btc = thb / pbtc;
            eth = thb / peth;
            bnb = thb / pbnb;
            uni = thb / puni;
            doge = thb / pdoge;
            if (btc>=0.0001)
            {
                textBox4.Text = Convert.ToString(btc);
            }
            if (eth >= 0.0001)
            {
                textBox2.Text = Convert.ToString(eth);
            }
            if (bnb >= 0.0001)
            {
                textBox5.Text = Convert.ToString(bnb);
            }
            if (uni >= 0.0001)
            {
                textBox3.Text = Convert.ToString(uni);
            }
            if (doge >= 0.0001)
            {
                textBox6.Text = Convert.ToString(doge);
            }
            if (btc < 0.0001)
            {
                textBox4.Text = "0";
            }
            if (eth < 0.0001)
            {
                textBox2.Text = "0";
            }
            if (bnb < 0.0001)
            {
                textBox5.Text = "0";
            }
            if (uni < 0.0001)
            {
                textBox3.Text = "0";
            }
            if (doge < 0.0001)
            {
                textBox6.Text = "0";
            }
            if (btc > 9999999)
            {
                textBox4.Text = "> 10000000";
            }
            if (eth > 9999999)
            {
                textBox2.Text = "> 10000000";
            }
            if (bnb > 9999999)
            {
                textBox5.Text = "> 10000000";
            }
            if (uni > 9999999)
            {
                textBox3.Text = "> 10000000";
            }
            if (doge > 9999999)
            {
                textBox6.Text = "> 10000000";
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Form4 = new Form4();
            Form4.ShowDialog();
            this.Close();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar != 8))
            {
                MessageBox.Show("Thai Baht is Number Only");
                e.Handled = true;
            }
        }
    }
}
