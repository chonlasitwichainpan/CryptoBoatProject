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
    public partial class Form4 : Form
    {
        private void Form4_Load(object sender, EventArgs e)
        {
            textBox1.Text = Form1.setusernametext;

            DB db = new DB();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `user` WHERE `username`='" + textBox1.Text + "'", db.GetConnection());
            db.openConnection();
            MySqlDataReader dataReader = command.ExecuteReader();
            if (dataReader.Read())
            {
                textBox2.Text = dataReader.GetValue(2).ToString();
                textBox3.Text = dataReader.GetValue(3).ToString();
                textBox4.Text = dataReader.GetValue(5).ToString();

                textBox5.Text = dataReader.GetValue(6).ToString();
                textBox6.Text = dataReader.GetValue(7).ToString();
                textBox7.Text = dataReader.GetValue(8).ToString();
                textBox8.Text = dataReader.GetValue(9).ToString();
                textBox9.Text = dataReader.GetValue(10).ToString();
                textBox10.Text = dataReader.GetValue(11).ToString();
            }
            db.closeConnection();

            MySqlCommand command1 = new MySqlCommand("SELECT * FROM `crypto` WHERE `name`='" + label21.Text + "'", db.GetConnection());
            db.openConnection();
            MySqlDataReader dataReader1 = command1.ExecuteReader();
            if (dataReader1.Read())
            {
                textBox26.Text = dataReader1.GetValue(2).ToString();
            }
            db.closeConnection();

            MySqlCommand command2 = new MySqlCommand("SELECT * FROM `crypto` WHERE `name`='" + label18.Text + "'", db.GetConnection());
            db.openConnection();
            MySqlDataReader dataReader2 = command2.ExecuteReader();
            if (dataReader2.Read())
            {
                textBox21.Text = dataReader2.GetValue(2).ToString();
            }
            db.closeConnection();

            MySqlCommand command3 = new MySqlCommand("SELECT * FROM `crypto` WHERE `name`='" + label19.Text + "'", db.GetConnection());
            db.openConnection();
            MySqlDataReader dataReader3 = command3.ExecuteReader();
            if (dataReader3.Read())
            {
                textBox22.Text = dataReader3.GetValue(2).ToString();
            }
            db.closeConnection();

            MySqlCommand command4 = new MySqlCommand("SELECT * FROM `crypto` WHERE `name`='" + label20.Text + "'", db.GetConnection());
            db.openConnection();
            MySqlDataReader dataReader4 = command4.ExecuteReader();
            if (dataReader4.Read())
            {
                textBox23.Text = dataReader4.GetValue(2).ToString();
            }
            db.closeConnection();

            MySqlCommand command5 = new MySqlCommand("SELECT * FROM `crypto` WHERE `name`='" + label22.Text + "'", db.GetConnection());
            db.openConnection();
            MySqlDataReader dataReader5 = command5.ExecuteReader();
            if (dataReader5.Read())
            {
                textBox24.Text = dataReader5.GetValue(2).ToString();
            }
            db.closeConnection();

            textBox26.Hide();
            button8.Hide();
            if (textBox1.Text == "admin")
            {
                button8.Show();
                button2.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
            }
            
        }
        public Form4()
        {
            InitializeComponent();
            Width = 700;
            Height = 400;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float btc = float.Parse(textBox6.Text);
            float pbtc = int.Parse(textBox21.Text);
            float btctothb;
            btctothb = btc * pbtc;
            textBox12.Text = Convert.ToString(btctothb);

            float eth = float.Parse(textBox7.Text);
            float peth = int.Parse(textBox22.Text);
            float ethtothb;
            ethtothb = eth * peth;
            textBox13.Text = Convert.ToString(ethtothb);

            float bnb = float.Parse(textBox8.Text);
            float pbnb = int.Parse(textBox23.Text);
            float bnbtothb;
            bnbtothb = bnb * pbnb;
            textBox14.Text = Convert.ToString(bnbtothb);

            float uni = float.Parse(textBox9.Text);
            float puni = int.Parse(textBox26.Text);
            float unitothb;
            unitothb = uni * 1300;
            textBox15.Text = Convert.ToString(unitothb);

            float doge = float.Parse(textBox10.Text);
            float pdoge = int.Parse(textBox24.Text);
            float dogetothb;
            dogetothb = doge * 15;
            textBox16.Text = Convert.ToString(dogetothb);

            if (btctothb > 10000000)
            {
                textBox12.Text = "> 10M";
            }
            if (ethtothb > 10000000)
            {
                textBox13.Text = "> 10M";
            }
            if (bnbtothb > 10000000)
            {
                textBox14.Text = "> 10M";
            }
            if (unitothb > 10000000)
            {
                textBox15.Text = "> 10M";
            }
            if (dogetothb > 10000000)
            {
                textBox16.Text = "> 10M";
            }

            if (Width == 700)
            {
                Width = 900;
                return;
            }
            else
            {
                Width = 700;
                return;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Form1 = new Form1();
            Form1.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Form5 = new Form5();
            Form5.ShowDialog();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Form6 = new Form6();
            Form6.ShowDialog();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Form7 = new Form7();
            Form7.ShowDialog();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Form8 = new Form8();
            Form8.ShowDialog();
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Form9 = new Form9();
            Form9.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/chonlasitgood");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://instagram.com/boat_elevenpro?r=nametag");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.tiktok.com/@bboatboatt/video/6960908378117917954?lang=en&is_copy_url=0&is_from_webapp=v1&sender_device=pc&sender_web_id=6857779361007044098");
        }
    }
}
