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
    public partial class Form5 : Form
    {
        private void Form5_Load(object sender, EventArgs e)
        {
            textBox11.Text = Form1.setusernametext;

            DB db = new DB();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `user` WHERE `username`='" + textBox11.Text + "'", db.GetConnection());
            db.openConnection();
            MySqlDataReader dataReader = command.ExecuteReader();
            if (dataReader.Read())
            {
                textBox14.Text = dataReader.GetValue(6).ToString();
                textBox15.Text = dataReader.GetValue(7).ToString();
                textBox16.Text = dataReader.GetValue(8).ToString();
                textBox17.Text = dataReader.GetValue(9).ToString();
                textBox18.Text = dataReader.GetValue(10).ToString();
                textBox19.Text = dataReader.GetValue(11).ToString();
            }
            db.closeConnection();

            MySqlCommand command1 = new MySqlCommand("SELECT * FROM `crypto` WHERE `name`='" + label12.Text + "'", db.GetConnection());
            db.openConnection();
            MySqlDataReader dataReader1 = command1.ExecuteReader();
            if (dataReader1.Read())
            {
                label2.Text = dataReader1.GetValue(2).ToString();
            }
            db.closeConnection();

            MySqlCommand command2 = new MySqlCommand("SELECT * FROM `crypto` WHERE `name`='" + label17.Text + "'", db.GetConnection());
            db.openConnection();
            MySqlDataReader dataReader2 = command2.ExecuteReader();
            if (dataReader2.Read())
            {
                label3.Text = dataReader2.GetValue(2).ToString();
            }
            db.closeConnection();

            MySqlCommand command3 = new MySqlCommand("SELECT * FROM `crypto` WHERE `name`='" + label21.Text + "'", db.GetConnection());
            db.openConnection();
            MySqlDataReader dataReader3 = command3.ExecuteReader();
            if (dataReader3.Read())
            {
                label5.Text = dataReader3.GetValue(2).ToString();
            }
            db.closeConnection();

            MySqlCommand command4 = new MySqlCommand("SELECT * FROM `crypto` WHERE `name`='" + label25.Text + "'", db.GetConnection());
            db.openConnection();
            MySqlDataReader dataReader4 = command4.ExecuteReader();
            if (dataReader4.Read())
            {
                label7.Text = dataReader4.GetValue(2).ToString();
            }
            db.closeConnection();

            MySqlCommand command5 = new MySqlCommand("SELECT * FROM `crypto` WHERE `name`='" + label29.Text + "'", db.GetConnection());
            db.openConnection();
            MySqlDataReader dataReader5 = command5.ExecuteReader();
            if (dataReader5.Read())
            {
                label9.Text = dataReader5.GetValue(2).ToString();
            }
            db.closeConnection();

            groupBox1.Show();
            groupBox2.Show();
            groupBox3.Show();
            groupBox4.Show();
            groupBox5.Show();

            button6.Hide();
            button7.Hide();
            button8.Hide();
            button9.Hide();
            button10.Hide();

            button12.Hide();
            button13.Hide();
            button14.Hide();
            button15.Hide();
            button16.Hide();

            groupBox1.Hide();
            groupBox2.Hide();
            groupBox3.Hide();
            groupBox4.Hide();
            groupBox5.Hide();

            textBox1.Enabled = false;
            textBox4.Enabled = false;
            textBox6.Enabled = false;
            textBox8.Enabled = false;
            textBox10.Enabled = false;

            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox5.Enabled = false;
            textBox7.Enabled = false;
            textBox9.Enabled = false;

            pictureBox2.Hide();
            pictureBox3.Hide();
        }
        public Form5()
        {
            InitializeComponent();
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
            groupBox1.Show();
            groupBox2.Hide();
            groupBox3.Hide();
            groupBox4.Hide();
            groupBox5.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            groupBox1.Hide();
            groupBox2.Show();
            groupBox3.Hide();
            groupBox4.Hide();
            groupBox5.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            groupBox1.Hide();
            groupBox2.Hide();
            groupBox3.Show();
            groupBox4.Hide();
            groupBox5.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            groupBox1.Hide();
            groupBox2.Hide();
            groupBox3.Hide();
            groupBox4.Show();
            groupBox5.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            groupBox1.Hide();
            groupBox2.Hide();
            groupBox3.Hide();
            groupBox4.Hide();
            groupBox5.Show();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            button6.Hide();
            button7.Hide();
            button8.Hide();
            button9.Hide();
            button10.Hide();

            button12.Hide();
            button13.Hide();
            button14.Hide();
            button15.Hide();
            button16.Hide();

            textBox1.Enabled = true;
            textBox4.Enabled = true;
            textBox6.Enabled = true;
            textBox8.Enabled = true;
            textBox10.Enabled = true;

            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox5.Enabled = false;
            textBox7.Enabled = false;
            textBox9.Enabled = false;

            textBox1.Text = "";
            textBox4.Text = "";
            textBox6.Text = "";
            textBox8.Text = "";
            textBox10.Text = "";

            textBox2.Text = "";
            textBox3.Text = "";
            textBox5.Text = "";
            textBox7.Text = "";
            textBox9.Text = "";

            pictureBox2.Show();
            pictureBox3.Hide();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            button6.Hide();
            button7.Hide();
            button8.Hide();
            button9.Hide();
            button10.Hide();

            button12.Hide();
            button13.Hide();
            button14.Hide();
            button15.Hide();
            button16.Hide();

            textBox1.Enabled = false;
            textBox4.Enabled = false;
            textBox6.Enabled = false;
            textBox8.Enabled = false;
            textBox10.Enabled = false;

            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox5.Enabled = true;
            textBox7.Enabled = true;
            textBox9.Enabled = true;

            textBox1.Text = "";
            textBox4.Text = "";
            textBox6.Text = "";
            textBox8.Text = "";
            textBox10.Text = "";

            textBox2.Text = "";
            textBox3.Text = "";
            textBox5.Text = "";
            textBox7.Text = "";
            textBox9.Text = "";

            pictureBox2.Hide();
            pictureBox3.Show();
        }
        private void button17_Click(object sender, EventArgs e) //check btc
        {
            if (radioButton1.Checked == true) //buy radio
            {
                if (textBox1.Text == "")
                {
                    MessageBox.Show("Please complete all information.\nกรุณากรอกจำนวนให้ครบถ้วน");
                }
                else
                {
                    float bth = int.Parse(textBox1.Text); //THB textbox
                    float pbtc = int.Parse(label2.Text); //Price Btc label
                    float btc;
                    btc = bth / pbtc;
                    if (btc >= 0.0001)
                    {
                        button6.Show(); //buy show
                        textBox2.Text = Convert.ToString(btc); //BTC textbox
                    }
                    if (btc < 0.0001)
                    {
                        MessageBox.Show("Can not Buy, BTC Must > 0.0001.\nBTCต่ำที่สุดในการซื้อคือ 0.0001", "Can not Buy");
                    }
                }
            }
            if (radioButton2.Checked == true)//sell radio
            {
                float btc = float.Parse(textBox2.Text); //BTC textbox
                int pbtc = int.Parse(label2.Text); //Price Btc label
                float bth;
                bth = btc * pbtc;
                if (textBox2.Text == "")
                {
                    MessageBox.Show("Please complete all information.\nกรุณากรอกจำนวนให้ครบถ้วน");
                }
                if ( btc < 0.0001 || btc > 5)
                {
                    MessageBox.Show("Minimum is 0.00011 Maximum is 5.\nBTCต่ำที่สุดในการขายคือ 0.00011 สูงที่สุดคือ 5", "Can not Sell");
                }
                else
                {
                    button12.Show(); //sell show
                    textBox1.Text = Convert.ToString(bth); //THB textbox
                }
            }
        }
        private void button6_Click(object sender, EventArgs e) //buy btc
        {
            DB db = new DB();

            MySqlCommand command = new MySqlCommand("UPDATE `user` SET `btc`= @btc WHERE `username`='" + textBox11.Text + "'", db.GetConnection());

            float btc = float.Parse(textBox15.Text); //BTC textbox user database
            float addbtc = float.Parse(textBox2.Text); //BTC textbox
            float volbtc;
            volbtc = btc + addbtc;
            command.Parameters.Add("@btc", MySqlDbType.VarChar).Value = volbtc; //add @btc to database (SET btc = @btc

            MySqlCommand command1 = new MySqlCommand("UPDATE `user` SET `bth`= @bth WHERE `username`='" + textBox11.Text + "'", db.GetConnection());

            int bth = int.Parse(textBox14.Text); //THB textbox user database
            int disbth = int.Parse(textBox1.Text); //THB textbox
            int volbth;
            volbth = bth - disbth;
            command1.Parameters.Add("@bth", MySqlDbType.VarChar).Value = volbth; //add @thb to database

            db.openConnection();

            if (disbth > bth)//check money ว่าเงินพอจ่าย(ซื้อ)(buy)มั้ย
            {
                MessageBox.Show("Not enough money\nจำนวนเงินไม่เพียงพอ");
            }
            else
            {
                if (command.ExecuteNonQuery() == 1)
                {
                    if (command1.ExecuteNonQuery() == 1)
                    {
                        MySqlCommand command0 = new MySqlCommand("SELECT * FROM `user` WHERE `username`='" + textBox11.Text + "'", db.GetConnection());
                        db.openConnection();
                        MySqlDataReader dataReader0 = command0.ExecuteReader();
                        if (dataReader0.Read())
                        {
                            textBox15.Text = dataReader0.GetValue(7).ToString(); //BTC textbox database update to program
                            textBox14.Text = dataReader0.GetValue(6).ToString(); //THB textbox database update to program
                        }
                        db.closeConnection();

                        textBox2.Text = ""; //clear BTC textbox
                        textBox1.Text = ""; //clear THB textbox
                        button6.Hide();

                        MessageBox.Show("Buy Successfully");
                    }
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
        }
        private void button12_Click(object sender, EventArgs e) //sell btc
        {
            DB db = new DB();

            MySqlCommand command = new MySqlCommand("UPDATE `user` SET `btc`= @btc WHERE `username`='" + textBox11.Text + "'", db.GetConnection());

            float btc = float.Parse(textBox15.Text); // btc database
            float disbtc = float.Parse(textBox2.Text); // btc textbox
            float volbtc;
            volbtc = btc - disbtc;
            command.Parameters.Add("@btc", MySqlDbType.VarChar).Value = volbtc;

            MySqlCommand command1 = new MySqlCommand("UPDATE `user` SET `bth`= @bth WHERE `username`='" + textBox11.Text + "'", db.GetConnection());

            int bth = int.Parse(textBox14.Text); //THB textbox database
            int addbth = int.Parse(textBox1.Text); //THB textbox
            int volbth;
            volbth = bth + addbth;
            command1.Parameters.Add("@bth", MySqlDbType.VarChar).Value = volbth;//add @thb to database

            db.openConnection();

            if (disbtc > btc)//chech ว่ามี btc พอที่จะขาย(sell) มั้ย
            {
                MessageBox.Show("Not enough BTC\nBTC ไม่เพียงพอที่จะขาย");
            }
            else
            {
                if (command.ExecuteNonQuery() == 1)
                {
                    if (command1.ExecuteNonQuery() == 1)
                    {
                        MySqlCommand command0 = new MySqlCommand("SELECT * FROM `user` WHERE `username`='" + textBox11.Text + "'", db.GetConnection());
                        db.openConnection();
                        MySqlDataReader dataReader0 = command0.ExecuteReader();
                        if (dataReader0.Read())
                        {
                            textBox15.Text = dataReader0.GetValue(7).ToString();//update BTC database to program
                            textBox14.Text = dataReader0.GetValue(6).ToString();//update THB database to program
                        }
                        db.closeConnection();

                        textBox2.Text = "";//clear BTC textbox
                        textBox1.Text = "";//clear THB textbox
                        button12.Hide();


                        MessageBox.Show("Sell Successfully");
                    }
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
        }

        private void button18_Click(object sender, EventArgs e) //check eth
        {
            if (radioButton1.Checked == true) //buy radio
            {
                if (textBox4.Text == "")
                {
                    MessageBox.Show("Please complete all information.\nกรุณากรอกจำนวนให้ครบถ้วน");
                }
                else
                {
                    float bth = int.Parse(textBox4.Text); //THB textbox
                    float pbtc = int.Parse(label3.Text); //Price Btc label
                    float btc;
                    btc = bth / pbtc;
                    if (btc >= 0.0001)
                    {
                        button7.Show(); //buy show
                        textBox3.Text = Convert.ToString(btc); //BTC textbox
                    }
                    if (btc < 0.0001)
                    {
                        MessageBox.Show("Can not Buy, ETH Must > 0.0001.\nETHต่ำที่สุดในการซื้อคือ 0.0001", "Can not Buy");
                    }
                }
            }
            if (radioButton2.Checked == true)//sell radio
            {
                float btc = float.Parse(textBox3.Text); //BTC textbox
                int pbtc = int.Parse(label3.Text); //Price Btc label
                float bth;
                bth = btc * pbtc;
                if (textBox3.Text == "")
                {
                    MessageBox.Show("Please complete all information.\nกรุณากรอกจำนวนให้ครบถ้วน");
                }
                if (btc < 0.0001 || btc > 50)
                {
                    MessageBox.Show("Minimum is 0.00011 Maximum is 50.\nETHต่ำที่สุดในการขายคือ 0.00011 สูงที่สุดคือ 50", "Can not Sell");
                }
                else
                {
                    button13.Show(); //sell show
                    textBox4.Text = Convert.ToString(bth); //THB textbox
                }
            }
        }

        private void button7_Click(object sender, EventArgs e) //buy eth
        {
            DB db = new DB();

            MySqlCommand command = new MySqlCommand("UPDATE `user` SET `eth`= @eth WHERE `username`='" + textBox11.Text + "'", db.GetConnection());

            float btc = float.Parse(textBox16.Text); //BTC textbox user database
            float addbtc = float.Parse(textBox3.Text); //BTC textbox
            float volbtc;
            volbtc = btc + addbtc;
            command.Parameters.Add("@eth", MySqlDbType.VarChar).Value = volbtc; //add @btc to database (SET btc = @btc

            MySqlCommand command1 = new MySqlCommand("UPDATE `user` SET `bth`= @bth WHERE `username`='" + textBox11.Text + "'", db.GetConnection());

            int bth = int.Parse(textBox14.Text); //THB textbox user database
            int disbth = int.Parse(textBox4.Text); //THB textbox
            int volbth;
            volbth = bth - disbth;
            command1.Parameters.Add("@bth", MySqlDbType.VarChar).Value = volbth; //add @thb to database

            db.openConnection();

            if (disbth > bth)//check money ว่าเงินพอจ่าย(ซื้อ)(buy)มั้ย
            {
                MessageBox.Show("Not enough money\nจำนวนเงินไม่เพียงพอ");
            }
            else
            {
                if (command.ExecuteNonQuery() == 1)
                {
                    if (command1.ExecuteNonQuery() == 1)
                    {
                        MySqlCommand command0 = new MySqlCommand("SELECT * FROM `user` WHERE `username`='" + textBox11.Text + "'", db.GetConnection());
                        db.openConnection();
                        MySqlDataReader dataReader0 = command0.ExecuteReader();
                        if (dataReader0.Read())
                        {
                            textBox16.Text = dataReader0.GetValue(8).ToString(); //BTC textbox database update to program
                            textBox14.Text = dataReader0.GetValue(6).ToString(); //THB textbox database update to program
                        }
                        db.closeConnection();

                        textBox3.Text = ""; //clear BTC textbox
                        textBox4.Text = ""; //clear THB textbox
                        button7.Hide();

                        MessageBox.Show("Buy Successfully");
                    }
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
        }

        private void button13_Click(object sender, EventArgs e) //sell eth
        {
            DB db = new DB();

            MySqlCommand command = new MySqlCommand("UPDATE `user` SET `eth`= @eth WHERE `username`='" + textBox11.Text + "'", db.GetConnection());

            float btc = float.Parse(textBox16.Text); // btc database
            float disbtc = float.Parse(textBox3.Text); // btc textbox
            float volbtc;
            volbtc = btc - disbtc;
            command.Parameters.Add("@eth", MySqlDbType.VarChar).Value = volbtc;

            MySqlCommand command1 = new MySqlCommand("UPDATE `user` SET `bth`= @bth WHERE `username`='" + textBox11.Text + "'", db.GetConnection());

            int bth = int.Parse(textBox14.Text); //THB textbox database
            int addbth = int.Parse(textBox4.Text); //THB textbox
            int volbth;
            volbth = bth + addbth;
            command1.Parameters.Add("@bth", MySqlDbType.VarChar).Value = volbth;//add @thb to database

            db.openConnection();

            if (disbtc > btc)//chech ว่ามี btc พอที่จะขาย(sell) มั้ย
            {
                MessageBox.Show("Not enough ETH\nETH ไม่เพียงพอที่จะขาย");
            }
            else
            {
                if (command.ExecuteNonQuery() == 1)
                {
                    if (command1.ExecuteNonQuery() == 1)
                    {
                        MySqlCommand command0 = new MySqlCommand("SELECT * FROM `user` WHERE `username`='" + textBox11.Text + "'", db.GetConnection());
                        db.openConnection();
                        MySqlDataReader dataReader0 = command0.ExecuteReader();
                        if (dataReader0.Read())
                        {
                            textBox16.Text = dataReader0.GetValue(8).ToString();//update BTC database to program
                            textBox14.Text = dataReader0.GetValue(6).ToString();//update THB database to program
                        }
                        db.closeConnection();

                        textBox3.Text = "";//clear BTC textbox
                        textBox4.Text = "";//clear THB textbox
                        button13.Hide();

                        MessageBox.Show("Sell Successfully");
                    }
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
        }

        private void button20_Click(object sender, EventArgs e) //check bnb
        {
            if (radioButton1.Checked == true) //buy radio
            {
                if (textBox6.Text == "")
                {
                    MessageBox.Show("Please complete all information.\nกรุณากรอกจำนวนให้ครบถ้วน");
                }
                else
                {
                    float bth = int.Parse(textBox6.Text); //THB textbox
                    float pbtc = int.Parse(label5.Text); //Price Btc label
                    float btc;
                    btc = bth / pbtc;
                    if (btc >= 0.0001)
                    {
                        button8.Show(); //buy show
                        textBox5.Text = Convert.ToString(btc); //BTC textbox
                    }
                    if (btc < 0.0001)
                    {
                        MessageBox.Show("Can not Buy, BNB Must > 0.0001.\nBNBต่ำที่สุดในการซื้อคือ 0.0001", "Can not Buy");
                    }
                }
            }
            if (radioButton2.Checked == true)//sell radio
            {
                float btc = float.Parse(textBox5.Text); //BTC textbox
                int pbtc = int.Parse(label5.Text); //Price Btc label
                float bth;
                bth = btc * pbtc;
                if (textBox5.Text == "")
                {
                    MessageBox.Show("Please complete all information.\nกรุณากรอกจำนวนให้ครบถ้วน");
                }
                if (btc < 0.0001 || btc > 400)
                {
                    MessageBox.Show("Minimum is 0.00011 Maximum is 400.\nBNBต่ำที่สุดในการขายคือ 0.00011 สูงที่สุดคือ 400", "Can not Sell");
                }
                else
                {
                    button14.Show(); //sell show
                    textBox6.Text = Convert.ToString(bth); //THB textbox
                }
            }
        }

        private void button8_Click(object sender, EventArgs e) //buy bnb
        {
            DB db = new DB();

            MySqlCommand command = new MySqlCommand("UPDATE `user` SET `bnb`= @bnb WHERE `username`='" + textBox11.Text + "'", db.GetConnection());

            float btc = float.Parse(textBox17.Text); //BTC textbox user database
            float addbtc = float.Parse(textBox5.Text); //BTC textbox
            float volbtc;
            volbtc = btc + addbtc;
            command.Parameters.Add("@bnb", MySqlDbType.VarChar).Value = volbtc; //add @btc to database (SET btc = @btc

            MySqlCommand command1 = new MySqlCommand("UPDATE `user` SET `bth`= @bth WHERE `username`='" + textBox11.Text + "'", db.GetConnection());

            int bth = int.Parse(textBox14.Text); //THB textbox user database
            int disbth = int.Parse(textBox6.Text); //THB textbox
            int volbth;
            volbth = bth - disbth;
            command1.Parameters.Add("@bth", MySqlDbType.VarChar).Value = volbth; //add @thb to database

            db.openConnection();

            if (disbth > bth)//check money ว่าเงินพอจ่าย(ซื้อ)(buy)มั้ย
            {
                MessageBox.Show("Not enough money\nจำนวนเงินไม่เพียงพอ");
            }
            else
            {
                if (command.ExecuteNonQuery() == 1)
                {
                    if (command1.ExecuteNonQuery() == 1)
                    {
                        MySqlCommand command0 = new MySqlCommand("SELECT * FROM `user` WHERE `username`='" + textBox11.Text + "'", db.GetConnection());
                        db.openConnection();
                        MySqlDataReader dataReader0 = command0.ExecuteReader();
                        if (dataReader0.Read())
                        {
                            textBox17.Text = dataReader0.GetValue(9).ToString(); //BTC textbox database update to program
                            textBox14.Text = dataReader0.GetValue(6).ToString(); //THB textbox database update to program
                        }
                        db.closeConnection();

                        textBox5.Text = ""; //clear BTC textbox
                        textBox6.Text = ""; //clear THB textbox
                        button8.Hide();

                        MessageBox.Show("Buy Successfully");
                    }
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
        }

        private void button14_Click(object sender, EventArgs e) //sell bnb
        {
            DB db = new DB();

            MySqlCommand command = new MySqlCommand("UPDATE `user` SET `bnb`= @bnb WHERE `username`='" + textBox11.Text + "'", db.GetConnection());

            float btc = float.Parse(textBox17.Text); // btc database
            float disbtc = float.Parse(textBox5.Text); // btc textbox
            float volbtc;
            volbtc = btc - disbtc;
            command.Parameters.Add("@bnb", MySqlDbType.VarChar).Value = volbtc;

            MySqlCommand command1 = new MySqlCommand("UPDATE `user` SET `bth`= @bth WHERE `username`='" + textBox11.Text + "'", db.GetConnection());

            int bth = int.Parse(textBox14.Text); //THB textbox database
            int addbth = int.Parse(textBox6.Text); //THB textbox
            int volbth;
            volbth = bth + addbth;
            command1.Parameters.Add("@bth", MySqlDbType.VarChar).Value = volbth;//add @thb to database

            db.openConnection();

            if (disbtc > btc)//chech ว่ามี btc พอที่จะขาย(sell) มั้ย
            {
                MessageBox.Show("Not enough BNB\nBNB ไม่เพียงพอที่จะขาย");
            }
            else
            {
                if (command.ExecuteNonQuery() == 1)
                {
                    if (command1.ExecuteNonQuery() == 1)
                    {
                        MySqlCommand command0 = new MySqlCommand("SELECT * FROM `user` WHERE `username`='" + textBox11.Text + "'", db.GetConnection());
                        db.openConnection();
                        MySqlDataReader dataReader0 = command0.ExecuteReader();
                        if (dataReader0.Read())
                        {
                            textBox17.Text = dataReader0.GetValue(9).ToString();//update BTC database to program
                            textBox14.Text = dataReader0.GetValue(6).ToString();//update THB database to program
                        }
                        db.closeConnection();

                        textBox5.Text = "";//clear BTC textbox
                        textBox6.Text = "";//clear THB textbox
                        button14.Hide();

                        MessageBox.Show("Sell Successfully");
                    }
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
        }

        private void button19_Click(object sender, EventArgs e) //check uni
        {
            if (radioButton1.Checked == true) //buy radio
            {
                if (textBox8.Text == "")
                {
                    MessageBox.Show("Please complete all information.\nกรุณากรอกจำนวนให้ครบถ้วน");
                }
                else
                {
                    float bth = int.Parse(textBox8.Text); //THB textbox
                    float pbtc = int.Parse(label7.Text); //Price Btc label
                    float btc;
                    btc = bth / pbtc;
                    if (btc >= 0.0001)
                    {
                        button9.Show(); //buy show
                        textBox7.Text = Convert.ToString(btc); //BTC textbox
                    }
                    if (btc < 0.0001)
                    {
                        MessageBox.Show("Can not Buy, UNI Must > 0.0001.\nUNIต่ำที่สุดในการซื้อคือ 0.0001", "Can not Buy");
                    }
                }
            }
            if (radioButton2.Checked == true)//sell radio
            {
                float btc = float.Parse(textBox7.Text); //BTC textbox
                int pbtc = int.Parse(label7.Text); //Price Btc label
                float bth;
                bth = btc * pbtc;
                if (textBox7.Text == "")
                {
                    MessageBox.Show("Please complete all information.\nกรุณากรอกจำนวนให้ครบถ้วน");
                }
                if (btc < 0.0001 || btc > 5000)
                {
                    MessageBox.Show("Minimum is 0.00011 Maximum is 5000.\nUNIต่ำที่สุดในการขายคือ 0.00011 สูงที่สุดคือ 5000", "Can not Sell");
                }
                else
                {
                    button15.Show(); //sell show
                    textBox8.Text = Convert.ToString(bth); //THB textbox
                }
            }
        }

        private void button9_Click(object sender, EventArgs e) //buy uni
        {
            DB db = new DB();

            MySqlCommand command = new MySqlCommand("UPDATE `user` SET `uni`= @uni WHERE `username`='" + textBox11.Text + "'", db.GetConnection());

            float btc = float.Parse(textBox18.Text); //BTC textbox user database
            float addbtc = float.Parse(textBox7.Text); //BTC textbox
            float volbtc;
            volbtc = btc + addbtc;
            command.Parameters.Add("@uni", MySqlDbType.VarChar).Value = volbtc; //add @btc to database (SET btc = @btc

            MySqlCommand command1 = new MySqlCommand("UPDATE `user` SET `bth`= @bth WHERE `username`='" + textBox11.Text + "'", db.GetConnection());

            int bth = int.Parse(textBox14.Text); //THB textbox user database
            int disbth = int.Parse(textBox8.Text); //THB textbox
            int volbth;
            volbth = bth - disbth;
            command1.Parameters.Add("@bth", MySqlDbType.VarChar).Value = volbth; //add @thb to database

            db.openConnection();

            if (disbth > bth)//check money ว่าเงินพอจ่าย(ซื้อ)(buy)มั้ย
            {
                MessageBox.Show("Not enough money\nจำนวนเงินไม่เพียงพอ");
            }
            else
            {
                if (command.ExecuteNonQuery() == 1)
                {
                    if (command1.ExecuteNonQuery() == 1)
                    {
                        MySqlCommand command0 = new MySqlCommand("SELECT * FROM `user` WHERE `username`='" + textBox11.Text + "'", db.GetConnection());
                        db.openConnection();
                        MySqlDataReader dataReader0 = command0.ExecuteReader();
                        if (dataReader0.Read())
                        {
                            textBox18.Text = dataReader0.GetValue(10).ToString(); //BTC textbox database update to program
                            textBox14.Text = dataReader0.GetValue(6).ToString(); //THB textbox database update to program
                        }
                        db.closeConnection();

                        textBox7.Text = ""; //clear BTC textbox
                        textBox8.Text = ""; //clear THB textbox
                        button9.Hide();

                        MessageBox.Show("Buy Successfully");
                    }
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
        }

        private void button15_Click(object sender, EventArgs e) //sell uni
        {
            DB db = new DB();

            MySqlCommand command = new MySqlCommand("UPDATE `user` SET `uni`= @uni WHERE `username`='" + textBox11.Text + "'", db.GetConnection());

            float btc = float.Parse(textBox18.Text); // btc database
            float disbtc = float.Parse(textBox7.Text); // btc textbox
            float volbtc;
            volbtc = btc - disbtc;
            command.Parameters.Add("@uni", MySqlDbType.VarChar).Value = volbtc;

            MySqlCommand command1 = new MySqlCommand("UPDATE `user` SET `bth`= @bth WHERE `username`='" + textBox11.Text + "'", db.GetConnection());

            int bth = int.Parse(textBox14.Text); //THB textbox database
            int addbth = int.Parse(textBox8.Text); //THB textbox
            int volbth;
            volbth = bth + addbth;
            command1.Parameters.Add("@bth", MySqlDbType.VarChar).Value = volbth;//add @thb to database

            db.openConnection();

            if (disbtc > btc)//chech ว่ามี btc พอที่จะขาย(sell) มั้ย
            {
                MessageBox.Show("Not enough UNI\nUNI ไม่เพียงพอที่จะขาย");
            }
            else
            {
                if (command.ExecuteNonQuery() == 1)
                {
                    if (command1.ExecuteNonQuery() == 1)
                    {
                        MySqlCommand command0 = new MySqlCommand("SELECT * FROM `user` WHERE `username`='" + textBox11.Text + "'", db.GetConnection());
                        db.openConnection();
                        MySqlDataReader dataReader0 = command0.ExecuteReader();
                        if (dataReader0.Read())
                        {
                            textBox18.Text = dataReader0.GetValue(10).ToString();//update BTC database to program
                            textBox14.Text = dataReader0.GetValue(6).ToString();//update THB database to program
                        }
                        db.closeConnection();

                        textBox7.Text = "";//clear BTC textbox
                        textBox8.Text = "";//clear THB textbox
                        button15.Hide();

                        MessageBox.Show("Sell Successfully");
                    }
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
        }

        private void button21_Click(object sender, EventArgs e) //check doge
        {
            if (radioButton1.Checked == true) //buy radio
            {
                if (textBox10.Text == "")
                {
                    MessageBox.Show("Please complete all information.\nกรุณากรอกจำนวนให้ครบถ้วน");
                }
                else
                {
                    float bth = int.Parse(textBox10.Text); //THB textbox
                    float pbtc = int.Parse(label9.Text); //Price Btc label
                    float btc;
                    btc = bth / pbtc;
                    if (btc >= 0.0001)
                    {
                        button10.Show(); //buy show
                        textBox9.Text = Convert.ToString(btc); //BTC textbox
                    }
                    if (btc < 0.0001)
                    {
                        MessageBox.Show("Can not Buy, DOGE Must > 0.0001.\nDOGEต่ำที่สุดในการซื้อคือ 0.0001", "Can not Buy");
                    }
                }
            }
            if (radioButton2.Checked == true)//sell radio
            {
                float btc = float.Parse(textBox9.Text); //BTC textbox
                int pbtc = int.Parse(label9.Text); //Price Btc label
                float bth;
                bth = btc * pbtc;
                if (textBox9.Text == "")
                {
                    MessageBox.Show("Please complete all information.\nกรุณากรอกจำนวนให้ครบถ้วน");
                }
                if (btc < 0.0001 || btc > 500000)
                {
                    MessageBox.Show("Minimum is 0.00011 Maximum is 500000.\nDOGEต่ำที่สุดในการขายคือ 0.00011 สูงที่สุดคือ 500000", "Can not Sell");
                }
                else
                {
                    button16.Show(); //sell show
                    textBox10.Text = Convert.ToString(bth); //THB textbox
                }
            }
        }

        private void button10_Click(object sender, EventArgs e) //buy doge
        {
            DB db = new DB();

            MySqlCommand command = new MySqlCommand("UPDATE `user` SET `doge`= @doge WHERE `username`='" + textBox11.Text + "'", db.GetConnection());

            float btc = float.Parse(textBox19.Text); //BTC textbox user database
            float addbtc = float.Parse(textBox9.Text); //BTC textbox
            float volbtc;
            volbtc = btc + addbtc;
            command.Parameters.Add("@doge", MySqlDbType.VarChar).Value = volbtc; //add @btc to database (SET btc = @btc

            MySqlCommand command1 = new MySqlCommand("UPDATE `user` SET `bth`= @bth WHERE `username`='" + textBox11.Text + "'", db.GetConnection());

            int bth = int.Parse(textBox14.Text); //THB textbox user database
            int disbth = int.Parse(textBox10.Text); //THB textbox
            int volbth;
            volbth = bth - disbth;
            command1.Parameters.Add("@bth", MySqlDbType.VarChar).Value = volbth; //add @thb to database

            db.openConnection();

            if (disbth > bth)//check money ว่าเงินพอจ่าย(ซื้อ)(buy)มั้ย
            {
                MessageBox.Show("Not enough money\nจำนวนเงินไม่เพียงพอ");
            }
            else
            {
                if (command.ExecuteNonQuery() == 1)
                {
                    if (command1.ExecuteNonQuery() == 1)
                    {
                        MySqlCommand command0 = new MySqlCommand("SELECT * FROM `user` WHERE `username`='" + textBox11.Text + "'", db.GetConnection());
                        db.openConnection();
                        MySqlDataReader dataReader0 = command0.ExecuteReader();
                        if (dataReader0.Read())
                        {
                            textBox19.Text = dataReader0.GetValue(11).ToString(); //BTC textbox database update to program
                            textBox14.Text = dataReader0.GetValue(6).ToString(); //THB textbox database update to program
                        }
                        db.closeConnection();

                        textBox9.Text = ""; //clear BTC textbox
                        textBox10.Text = ""; //clear THB textbox
                        button9.Hide();

                        MessageBox.Show("Buy Successfully");
                    }
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
        }

        private void button16_Click(object sender, EventArgs e) //sell doge
        {
            DB db = new DB();

            MySqlCommand command = new MySqlCommand("UPDATE `user` SET `doge`= @doge WHERE `username`='" + textBox11.Text + "'", db.GetConnection());

            float btc = float.Parse(textBox19.Text); // btc database
            float disbtc = float.Parse(textBox9.Text); // btc textbox
            float volbtc;
            volbtc = btc - disbtc;
            command.Parameters.Add("@doge", MySqlDbType.VarChar).Value = volbtc;

            MySqlCommand command1 = new MySqlCommand("UPDATE `user` SET `bth`= @bth WHERE `username`='" + textBox11.Text + "'", db.GetConnection());

            int bth = int.Parse(textBox14.Text); //THB textbox database
            int addbth = int.Parse(textBox10.Text); //THB textbox
            int volbth;
            volbth = bth + addbth;
            command1.Parameters.Add("@bth", MySqlDbType.VarChar).Value = volbth;//add @thb to database

            db.openConnection();

            if (disbtc > btc)//chech ว่ามี btc พอที่จะขาย(sell) มั้ย
            {
                MessageBox.Show("Not enough DOGE\nDOGE ไม่เพียงพอที่จะขาย");
            }
            else
            {
                if (command.ExecuteNonQuery() == 1)
                {
                    if (command1.ExecuteNonQuery() == 1)
                    {
                        MySqlCommand command0 = new MySqlCommand("SELECT * FROM `user` WHERE `username`='" + textBox11.Text + "'", db.GetConnection());
                        db.openConnection();
                        MySqlDataReader dataReader0 = command0.ExecuteReader();
                        if (dataReader0.Read())
                        {
                            textBox19.Text = dataReader0.GetValue(11).ToString();//update BTC database to program
                            textBox14.Text = dataReader0.GetValue(6).ToString();//update THB database to program
                        }
                        db.closeConnection();

                        textBox9.Text = "";//clear BTC textbox
                        textBox10.Text = "";//clear THB textbox
                        button16.Hide();

                        MessageBox.Show("Sell Successfully");
                    }
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar != 8 && e.KeyChar != 46))
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar != 8 && e.KeyChar != 46))
            {
                e.Handled = true;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar != 8 && e.KeyChar != 46))
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar != 8 && e.KeyChar != 46))
            {
                e.Handled = true;
            }
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar != 8 && e.KeyChar != 46))
            {
                e.Handled = true;
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar != 8 && e.KeyChar != 46))
            {
                e.Handled = true;
            }
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar != 8 && e.KeyChar != 46))
            {
                e.Handled = true;
            }
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar != 8 && e.KeyChar != 46))
            {
                e.Handled = true;
            }
        }

        private void textBox10_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar != 8 && e.KeyChar != 46))
            {
                e.Handled = true;
            }
        }

        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar != 8 && e.KeyChar != 46))
            {
                e.Handled = true;
            }
        }
    }
}
