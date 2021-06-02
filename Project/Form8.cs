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
    public partial class Form8 : Form
    {
        private void Form8_Load(object sender, EventArgs e)
        {
            textBox1.Text = Form1.setusernametext;
            groupBox2.Hide();
            groupBox3.Hide();

            DB db = new DB();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `user` WHERE `username`='" + textBox1.Text + "'", db.GetConnection());
            db.openConnection();
            MySqlDataReader dataReader = command.ExecuteReader();
            if (dataReader.Read())
            {
                textBox3.Text = dataReader.GetValue(6).ToString();
            }
        }
        public Form8()
        {
            InitializeComponent();
        }
        private void button8_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            MySqlCommand command = new MySqlCommand("UPDATE `user` SET `bth`= @bth WHERE `username`='" + textBox1.Text + "'", db.GetConnection());

            int bth = int.Parse(textBox3.Text);
            int addbth = int.Parse(textBox2.Text);
            int volbth;
            volbth = bth + addbth;
            
            command.Parameters.Add("@bth", MySqlDbType.VarChar).Value = volbth;

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                MySqlCommand command0 = new MySqlCommand("SELECT * FROM `user` WHERE `username`='" + textBox1.Text + "'", db.GetConnection());
                db.openConnection();
                MySqlDataReader dataReader0 = command0.ExecuteReader();
                if (dataReader0.Read())
                {
                    textBox3.Text = dataReader0.GetValue(6).ToString();
                }
                db.closeConnection();

                textBox2.Text = "0";

                MessageBox.Show("Your balance is "+textBox3.Text+" Baht", "Deposit successfully");
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            MySqlCommand command = new MySqlCommand("UPDATE `user` SET `bth`= @bth WHERE `username`='" + textBox1.Text + "'", db.GetConnection());

            int bth = int.Parse(textBox3.Text);
            int disbth = int.Parse(textBox4.Text);

            if (bth<disbth)
            {
                MessageBox.Show("Not enough balance");
            }
            else
            {
                int volbth;
                volbth = bth - disbth;

                command.Parameters.Add("@bth", MySqlDbType.VarChar).Value = volbth;

                db.openConnection();

                if (command.ExecuteNonQuery() == 1)
                {
                    MySqlCommand command0 = new MySqlCommand("SELECT * FROM `user` WHERE `username`='" + textBox1.Text + "'", db.GetConnection());
                    db.openConnection();
                    MySqlDataReader dataReader0 = command0.ExecuteReader();
                    if (dataReader0.Read())
                    {
                        textBox3.Text = dataReader0.GetValue(6).ToString();
                    }
                    db.closeConnection();

                    textBox4.Text = "0";

                    MessageBox.Show("Your balance is " + textBox3.Text + " Baht", "Withdraw successfully");
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            groupBox2.Show();
            groupBox3.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            groupBox2.Hide();
            groupBox3.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Form4 = new Form4();
            Form4.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "100";
            }
            else
            {
                int bth = int.Parse(textBox2.Text);
                int addbth100;
                addbth100 = bth + 100;
                textBox2.Text = Convert.ToString(addbth100);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "1000";
            }
            else
            {
                int bth = int.Parse(textBox2.Text);
                int addbth100;
                addbth100 = bth + 1000;
                textBox2.Text = Convert.ToString(addbth100);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "10000";
            }
            else
            {
                int bth = int.Parse(textBox2.Text);
                int addbth100;
                addbth100 = bth + 10000;
                textBox2.Text = Convert.ToString(addbth100);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "100000";
            }
            else
            {
                int bth = int.Parse(textBox2.Text);
                int addbth100;
                addbth100 = bth + 100000;
                textBox2.Text = Convert.ToString(addbth100);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "1000000";
            }
            else
            {
                int bth = int.Parse(textBox2.Text);
                int addbth100;
                addbth100 = bth + 1000000;
                textBox2.Text = Convert.ToString(addbth100);
            }
        }
    }
}
