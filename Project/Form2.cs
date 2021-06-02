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
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `user`(`username`, `password`, `name`, `age`, `phone`, `email`, `bth`, `btc`, `eth`, `bnb`, `uni`, `doge`) VALUES (@usn, @pass, @name, @age, @phone, @email, @bth, @btc, @eth, @bnb, @uni, @doge)", db.GetConnection());

            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = textBox1.Text;
            command.Parameters.Add("@age", MySqlDbType.VarChar).Value = textBox2.Text;
            command.Parameters.Add("@phone", MySqlDbType.VarChar).Value = textBox3.Text;
            command.Parameters.Add("@email", MySqlDbType.VarChar).Value = textBox4.Text;
            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = textBox5.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = textBox6.Text;
            command.Parameters.Add("@bth", MySqlDbType.VarChar).Value = 0;
            command.Parameters.Add("@btc", MySqlDbType.VarChar).Value = 0;
            command.Parameters.Add("@eth", MySqlDbType.VarChar).Value = 0;
            command.Parameters.Add("@bnb", MySqlDbType.VarChar).Value = 0;
            command.Parameters.Add("@uni", MySqlDbType.VarChar).Value = 0;
            command.Parameters.Add("@doge", MySqlDbType.VarChar).Value = 0;

            db.openConnection();

            if (!checkinfor())
            {
                if (checkphone())
                {
                    MessageBox.Show("This Phone Number is Already in use","Phone Number");
                }
                else
                {
                    if (checkusername())
                    {
                        MessageBox.Show("This Username is Already in use","Username");
                    }
                    else
                    {
                        if (command.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("You can capture this screen to save your account information","Account Created");
                            textBox1.Enabled = false;
                            textBox2.Enabled = false;
                            textBox3.Enabled = false;
                            textBox4.Enabled = false;
                            textBox5.Enabled = false;
                            textBox6.Enabled = false;
                            textBox7.Enabled = false;

                        }
                        else
                        {
                            MessageBox.Show("Error");
                        }
                    }
                }
            }

            db.closeConnection();
        }
        public Boolean checkinfor()
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "" || textBox7.Text == "")
            {
                MessageBox.Show("Please complete all information.");
                return true;
            }
            int age = Convert.ToInt32(textBox2.Text);
            if (age < 18 || age > 60)
            {
                MessageBox.Show("Users must be 18-60 years old.","Age");
                textBox2.Text = "";
                return true;
            }
            if (textBox6.Text != textBox7.Text)
            {
                MessageBox.Show("The Password verification is invalid.","Confirm Password");
                return true;
            }
            else
            {
                return false;
            }
        }

        public Boolean checkusername()
        {
            DB db = new DB();
            String username = textBox5.Text;

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `user` WHERE `username` = @usn", db.GetConnection());

            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = username;

            adapter.SelectCommand = command;

            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public Boolean checkphone()
        {
            DB db = new DB();
            String phone = textBox3.Text;

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `user` WHERE `phone` = @phone", db.GetConnection());

            command.Parameters.Add("@phone", MySqlDbType.VarChar).Value = phone;

            adapter.SelectCommand = command;

            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar != 8))
            {
                MessageBox.Show("Age must be a number only.");
                e.Handled = true;
            }
        }
        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar != 8))
            {
                MessageBox.Show("Phone number must be a number only.");
                e.Handled = true;
            }
        }
        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar != 8))
            {
                MessageBox.Show("Password must be a number only.");
                e.Handled = true;
            }
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar != 8))
            {
                MessageBox.Show("Confirm password must be a number only.");
                e.Handled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}
