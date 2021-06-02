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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `user` WHERE `phone`='"+textBox1.Text+"'", db.GetConnection());
            db.openConnection();
            MySqlDataReader dataReader = command.ExecuteReader();
            
            if (dataReader.Read())
            {
                textBox2.Text = dataReader.GetValue(2).ToString();
                textBox3.Text = dataReader.GetValue(3).ToString();
                textBox4.Text = dataReader.GetValue(5).ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("UPDATE `user` SET `password`= @pass WHERE `phone`='" + textBox1.Text + "'", db.GetConnection());

            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = textBox7.Text;

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Password changed successfully", "Password Reset");
            }
            else
            {
                MessageBox.Show("Error");
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