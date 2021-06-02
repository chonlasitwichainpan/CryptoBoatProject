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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            DB db = new DB();

            MySqlCommand command1 = new MySqlCommand("SELECT * FROM `crypto` WHERE `name`='" + label1.Text + "'", db.GetConnection());
            db.openConnection();
            MySqlDataReader dataReader1 = command1.ExecuteReader();
            if (dataReader1.Read())
            {
                textBox1.Text = dataReader1.GetValue(2).ToString();
            }
            db.closeConnection();

            MySqlCommand command2 = new MySqlCommand("SELECT * FROM `crypto` WHERE `name`='" + label2.Text + "'", db.GetConnection());
            db.openConnection();
            MySqlDataReader dataReader2 = command2.ExecuteReader();
            if (dataReader2.Read())
            {
                textBox2.Text = dataReader2.GetValue(2).ToString();
            }
            db.closeConnection();

            MySqlCommand command3 = new MySqlCommand("SELECT * FROM `crypto` WHERE `name`='" + label3.Text + "'", db.GetConnection());
            db.openConnection();
            MySqlDataReader dataReader3 = command3.ExecuteReader();
            if (dataReader3.Read())
            {
                textBox3.Text = dataReader3.GetValue(2).ToString();
            }
            db.closeConnection();

            MySqlCommand command4 = new MySqlCommand("SELECT * FROM `crypto` WHERE `name`='" + label4.Text + "'", db.GetConnection());
            db.openConnection();
            MySqlDataReader dataReader4 = command4.ExecuteReader();
            if (dataReader4.Read())
            {
                textBox4.Text = dataReader4.GetValue(2).ToString();
            }
            db.closeConnection();

            MySqlCommand command5 = new MySqlCommand("SELECT * FROM `crypto` WHERE `name`='" + label5.Text + "'", db.GetConnection());
            db.openConnection();
            MySqlDataReader dataReader5 = command5.ExecuteReader();
            if (dataReader5.Read())
            {
                textBox5.Text = dataReader5.GetValue(2).ToString();
            }
            db.closeConnection();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Form4 = new Form4();
            Form4.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox6.Text == "")
            {
                MessageBox.Show("Input a new Price");
            }
            else
            {
                DB db = new DB();

                MySqlCommand command = new MySqlCommand("UPDATE `crypto` SET `price`= @price WHERE `name`='" + label1.Text + "'", db.GetConnection()); //

                int newprice = int.Parse(textBox6.Text); //

                command.Parameters.Add("@price", MySqlDbType.VarChar).Value = newprice;

                db.openConnection();
                if (command.ExecuteNonQuery() == 1)
                {
                    MySqlCommand command0 = new MySqlCommand("SELECT * FROM `crypto` WHERE `name`='" + label1.Text + "'", db.GetConnection()); //
                    db.openConnection();
                    MySqlDataReader dataReader0 = command0.ExecuteReader();
                    if (dataReader0.Read())
                    {
                        textBox1.Text = dataReader0.GetValue(2).ToString(); //
                    }
                    db.closeConnection();

                    textBox6.Text = ""; //

                    MessageBox.Show("Update BTC price successful.");
                }
            } 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox7.Text == "")
            {
                MessageBox.Show("Input a new Price");
            }
            else
            {
                DB db = new DB();

                MySqlCommand command = new MySqlCommand("UPDATE `crypto` SET `price`= @price WHERE `name`='" + label2.Text + "'", db.GetConnection()); //

                int newprice = int.Parse(textBox7.Text); //

                command.Parameters.Add("@price", MySqlDbType.VarChar).Value = newprice;

                db.openConnection();
                if (command.ExecuteNonQuery() == 1)
                {
                    MySqlCommand command0 = new MySqlCommand("SELECT * FROM `crypto` WHERE `name`='" + label2.Text + "'", db.GetConnection()); //
                    db.openConnection();
                    MySqlDataReader dataReader0 = command0.ExecuteReader();
                    if (dataReader0.Read())
                    {
                        textBox2.Text = dataReader0.GetValue(2).ToString(); //
                    }
                    db.closeConnection();

                    textBox7.Text = ""; //

                    MessageBox.Show("Update ETH price successful.");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox8.Text == "")
            {
                MessageBox.Show("Input a new Price");
            }
            else
            {
                DB db = new DB();

                MySqlCommand command = new MySqlCommand("UPDATE `crypto` SET `price`= @price WHERE `name`='" + label3.Text + "'", db.GetConnection()); //

                int newprice = int.Parse(textBox8.Text); //

                command.Parameters.Add("@price", MySqlDbType.VarChar).Value = newprice;

                db.openConnection();
                if (command.ExecuteNonQuery() == 1)
                {
                    MySqlCommand command0 = new MySqlCommand("SELECT * FROM `crypto` WHERE `name`='" + label3.Text + "'", db.GetConnection()); //
                    db.openConnection();
                    MySqlDataReader dataReader0 = command0.ExecuteReader();
                    if (dataReader0.Read())
                    {
                        textBox3.Text = dataReader0.GetValue(2).ToString(); //
                    }
                    db.closeConnection();

                    textBox8.Text = ""; //

                    MessageBox.Show("Update BNB price successful.");
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox9.Text == "")
            {
                MessageBox.Show("Input a new Price");
            }
            else
            {
                DB db = new DB();

                MySqlCommand command = new MySqlCommand("UPDATE `crypto` SET `price`= @price WHERE `name`='" + label4.Text + "'", db.GetConnection()); //

                int newprice = int.Parse(textBox9.Text); //

                command.Parameters.Add("@price", MySqlDbType.VarChar).Value = newprice;

                db.openConnection();
                if (command.ExecuteNonQuery() == 1)
                {
                    MySqlCommand command0 = new MySqlCommand("SELECT * FROM `crypto` WHERE `name`='" + label4.Text + "'", db.GetConnection()); //
                    db.openConnection();
                    MySqlDataReader dataReader0 = command0.ExecuteReader();
                    if (dataReader0.Read())
                    {
                        textBox4.Text = dataReader0.GetValue(2).ToString(); //
                    }
                    db.closeConnection();

                    textBox9.Text = ""; //

                    MessageBox.Show("Update UNI price successful.");
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox10.Text == "")
            {
                MessageBox.Show("Input a new Price");
            }
            else
            {
                DB db = new DB();

                MySqlCommand command = new MySqlCommand("UPDATE `crypto` SET `price`= @price WHERE `name`='" + label5.Text + "'", db.GetConnection()); //

                int newprice = int.Parse(textBox10.Text); //

                command.Parameters.Add("@price", MySqlDbType.VarChar).Value = newprice;

                db.openConnection();
                if (command.ExecuteNonQuery() == 1)
                {
                    MySqlCommand command0 = new MySqlCommand("SELECT * FROM `crypto` WHERE `name`='" + label5.Text + "'", db.GetConnection()); //
                    db.openConnection();
                    MySqlDataReader dataReader0 = command0.ExecuteReader();
                    if (dataReader0.Read())
                    {
                        textBox5.Text = dataReader0.GetValue(2).ToString(); //
                    }
                    db.closeConnection();

                    textBox10.Text = ""; //

                    MessageBox.Show("Update DOGE price successful.");
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://localhost/phpmyadmin/index.php?route=/sql&server=1&db=project&table=user&pos=0");
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar != 8))
            {
                MessageBox.Show("Price must be a number only.");
                e.Handled = true;
            }
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar != 8))
            {
                MessageBox.Show("Price must be a number only.");
                e.Handled = true;
            }
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar != 8))
            {
                MessageBox.Show("Price must be a number only.");
                e.Handled = true;
            }
        }

        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar != 8))
            {
                MessageBox.Show("Price must be a number only.");
                e.Handled = true;
            }
        }

        private void textBox10_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar != 8))
            {
                MessageBox.Show("Price must be a number only.");
                e.Handled = true;
            }
        }
    }
}
