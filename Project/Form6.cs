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
    public partial class Form6 : Form
    {
        private void Form6_Load(object sender, EventArgs e)
        {
            textBox16.Text = Form1.setusernametext;

            DB db = new DB();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `user` WHERE `username`='" + textBox16.Text + "'", db.GetConnection());
            db.openConnection();
            MySqlDataReader dataReader = command.ExecuteReader();
            if (dataReader.Read())
            {
                textBox1.Text = dataReader.GetValue(7).ToString();
                textBox4.Text = dataReader.GetValue(8).ToString();
                textBox6.Text = dataReader.GetValue(9).ToString();
                textBox8.Text = dataReader.GetValue(10).ToString();
                textBox10.Text = dataReader.GetValue(11).ToString();

                textBox21.Text = dataReader.GetValue(7).ToString();
                textBox20.Text = dataReader.GetValue(8).ToString();
                textBox19.Text = dataReader.GetValue(9).ToString();
                textBox18.Text = dataReader.GetValue(10).ToString();
                textBox17.Text = dataReader.GetValue(11).ToString();
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

            MySqlCommand command2 = new MySqlCommand("SELECT * FROM `crypto` WHERE `name`='" + label22.Text + "'", db.GetConnection());
            db.openConnection();
            MySqlDataReader dataReader2 = command2.ExecuteReader();
            if (dataReader2.Read())
            {
                textBox25.Text = dataReader2.GetValue(2).ToString();
            }
            db.closeConnection();

            MySqlCommand command3 = new MySqlCommand("SELECT * FROM `crypto` WHERE `name`='" + label23.Text + "'", db.GetConnection());
            db.openConnection();
            MySqlDataReader dataReader3 = command3.ExecuteReader();
            if (dataReader3.Read())
            {
                textBox24.Text = dataReader3.GetValue(2).ToString();
            }
            db.closeConnection();

            MySqlCommand command4 = new MySqlCommand("SELECT * FROM `crypto` WHERE `name`='" + label24.Text + "'", db.GetConnection());
            db.openConnection();
            MySqlDataReader dataReader4 = command4.ExecuteReader();
            if (dataReader4.Read())
            {
                textBox23.Text = dataReader4.GetValue(2).ToString();
            }
            db.closeConnection();

            MySqlCommand command5 = new MySqlCommand("SELECT * FROM `crypto` WHERE `name`='" + label25.Text + "'", db.GetConnection());
            db.openConnection();
            MySqlDataReader dataReader5 = command5.ExecuteReader();
            if (dataReader5.Read())
            {
                textBox22.Text = dataReader5.GetValue(2).ToString();
            }
            db.closeConnection();

            button4.Hide();
            button1.Hide();
            button2.Hide();
            button3.Hide();
            button5.Hide();
        }
        public Form6()
        {
            InitializeComponent();
            groupBox1.Hide();
            groupBox2.Hide();
            groupBox3.Hide();
            groupBox4.Hide();
            groupBox5.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Bitcoin(BTC)")
            {
                groupBox1.Show();
                groupBox2.Hide();
                groupBox3.Hide();
                groupBox4.Hide();
                groupBox5.Hide();

                textBox2.Text = "";
                textBox15.Text = "";
                textBox14.Text = "";
                textBox13.Text = "";
                textBox12.Text = "";
                textBox11.Text = "";

                button4.Hide();
                button1.Hide();
                button2.Hide();
                button3.Hide();
                button5.Hide();
            }
            if (comboBox1.Text == "Ethereum(ETH)")
            {
                groupBox1.Hide();
                groupBox2.Show();
                groupBox3.Hide();
                groupBox4.Hide();
                groupBox5.Hide();

                textBox3.Text = "";
                textBox15.Text = "";
                textBox14.Text = "";
                textBox13.Text = "";
                textBox12.Text = "";
                textBox11.Text = "";

                button4.Hide();
                button1.Hide();
                button2.Hide();
                button3.Hide();
                button5.Hide();
            }
            if (comboBox1.Text == "Binance(BNB)")
            {
                groupBox1.Hide();
                groupBox2.Hide();
                groupBox3.Show();
                groupBox4.Hide();
                groupBox5.Hide();

                textBox5.Text = "";
                textBox15.Text = "";
                textBox14.Text = "";
                textBox13.Text = "";
                textBox12.Text = "";
                textBox11.Text = "";

                button4.Hide();
                button1.Hide();
                button2.Hide();
                button3.Hide();
                button5.Hide();
            }
            if (comboBox1.Text == "Uniswap(UNI)")
            {
                groupBox1.Hide();
                groupBox2.Hide();
                groupBox3.Hide();
                groupBox4.Show();
                groupBox5.Hide();

                textBox7.Text = "";
                textBox15.Text = "";
                textBox14.Text = "";
                textBox13.Text = "";
                textBox12.Text = "";
                textBox11.Text = "";

                button4.Hide();
                button1.Hide();
                button2.Hide();
                button3.Hide();
                button5.Hide();
            }
            if (comboBox1.Text == "DogeCoin(DOGE)")
            {
                groupBox1.Hide();
                groupBox2.Hide();
                groupBox3.Hide();
                groupBox4.Hide();
                groupBox5.Show();

                textBox9.Text = "";
                textBox15.Text = "";
                textBox14.Text = "";
                textBox13.Text = "";
                textBox12.Text = "";
                textBox11.Text = "";

                button4.Hide();
                button1.Hide();
                button2.Hide();
                button3.Hide();
                button5.Hide();
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Form4 = new Form4();
            Form4.ShowDialog();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            float pricebtc = int.Parse(textBox26.Text);
            float priceeth = int.Parse(textBox25.Text);
            float pricebnb = int.Parse(textBox24.Text);
            float priceuni = int.Parse(textBox23.Text);
            float pricedoge = int.Parse(textBox22.Text);

            
            if (comboBox1.Text == "Bitcoin(BTC)")
            {
                button4.Hide();
                button1.Hide();
                button2.Hide();
                button3.Hide();
                button5.Hide();

                if (textBox2.Text == "")
                {
                    MessageBox.Show("Please complete all information.\nกรุณากรอกจำนวนให้ครบถ้วน");
                }
                else
                {
                    float yourbtc = float.Parse(textBox1.Text);
                    float exbtc = float.Parse(textBox2.Text);
                    if (exbtc <= yourbtc)
                    {
                        float recivebtc;
                        recivebtc = (exbtc * pricebtc) / pricebtc;
                        if (recivebtc > 0.001)
                        {
                            textBox11.Text = Convert.ToString(recivebtc);
                            button4.Show();
                        }
                        else
                        {
                            textBox11.Text = "Lower then 0.001";
                            button4.Hide();
                        }

                        float reciveeth;
                        reciveeth = (exbtc * pricebtc) / priceeth;
                        if (reciveeth > 0.001)
                        {
                            textBox12.Text = Convert.ToString(reciveeth);
                            button1.Show();
                        }
                        else
                        {
                            textBox12.Text = "Lower then 0.001";
                            button1.Hide();
                        }

                        float recivebnb;
                        recivebnb = (exbtc * pricebtc) / pricebnb;
                        if (recivebnb > 0.001)
                        {
                            textBox13.Text = Convert.ToString(recivebnb);
                            button2.Show();
                        }
                        else
                        {
                            textBox13.Text = "Lower then 0.001";
                            button2.Hide();
                        }

                        float reciveuni;
                        reciveuni = (exbtc * pricebtc) / priceuni;
                        if (reciveuni > 0.001)
                        {
                            textBox14.Text = Convert.ToString(reciveuni);
                            button3.Show();
                        }
                        else
                        {
                            textBox14.Text = "Lower then 0.001";
                            button3.Hide();
                        }

                        float recivedoge;
                        recivedoge = (exbtc * pricebtc) / pricedoge;
                        if (recivedoge >0.001)
                        {
                            textBox15.Text = Convert.ToString(recivedoge);
                            button5.Show();
                        }
                        else
                        {
                            textBox15.Text = "Lower then 0.001";
                            button5.Hide();
                        }
                        
                    }
                    if (exbtc > 5)
                    {
                        textBox2.Text = "";
                        textBox3.Text = "";
                        textBox5.Text = "";
                        textBox7.Text = "";
                        textBox9.Text = "";
                        textBox11.Text = "";
                        textBox12.Text = "";
                        textBox13.Text = "";
                        textBox14.Text = "";
                        textBox15.Text = "";
                        button4.Hide();
                        button1.Hide();
                        button2.Hide();
                        button3.Hide();
                        button5.Hide();
                        MessageBox.Show("Meximum BTC to Exchange is 5 BTC\nBTCสูงสุดที่แลกเปลี่ยนได้คือ 5 BTC");
                    }
                    if (exbtc > yourbtc)
                    {
                        MessageBox.Show("Not enough BTC in your wallet");
                    }
                }
            }
            if (comboBox1.Text == "Ethereum(ETH)")
            {
                if (textBox3.Text == "")
                {
                    MessageBox.Show("Please complete all information.\nกรุณากรอกจำนวนให้ครบถ้วน");
                }
                else
                {
                    float your = float.Parse(textBox4.Text);
                    float ex = float.Parse(textBox3.Text);
                    if (ex <= your)
                    {
                        float recivebtc;
                        recivebtc = (ex * priceeth) / pricebtc;
                        if (recivebtc > 0.001)
                        {
                            textBox11.Text = Convert.ToString(recivebtc);
                            button4.Show();
                        }
                        else
                        {
                            textBox11.Text = "Lower then 0.001";
                            button4.Hide();
                        }

                        float reciveeth;
                        reciveeth = (ex * priceeth) / priceeth;
                        if (reciveeth > 0.001)
                        {
                            textBox12.Text = Convert.ToString(reciveeth);
                            button1.Show();
                        }
                        else
                        {
                            textBox12.Text = "Lower then 0.001";
                            button1.Hide();
                        }

                        float recivebnb;
                        recivebnb = (ex * priceeth) / pricebnb;
                        if (recivebnb > 0.001)
                        {
                            textBox13.Text = Convert.ToString(recivebnb);
                            button2.Show();
                        }
                        else
                        {
                            textBox13.Text = "Lower then 0.001";
                            button2.Hide();
                        }

                        float reciveuni;
                        reciveuni = (ex * priceeth) / priceuni;
                        if (reciveuni > 0.001)
                        {
                            textBox14.Text = Convert.ToString(reciveuni);
                            button3.Show();
                        }
                        else
                        {
                            textBox14.Text = "Lower then 0.001";
                            button3.Hide();
                        }

                        float recivedoge;
                        recivedoge = (ex * priceeth) / pricedoge;
                        if (recivedoge > 0.001)
                        {
                            textBox15.Text = Convert.ToString(recivedoge);
                            button5.Show();
                        }
                        else
                        {
                            textBox15.Text = "Lower then 0.001";
                            button5.Hide();
                        }
                    }
                    if (ex > 50)
                    {
                        textBox2.Text = "";
                        textBox3.Text = "";
                        textBox5.Text = "";
                        textBox7.Text = "";
                        textBox9.Text = "";
                        textBox11.Text = "";
                        textBox12.Text = "";
                        textBox13.Text = "";
                        textBox14.Text = "";
                        textBox15.Text = "";
                        button4.Hide();
                        button1.Hide();
                        button2.Hide();
                        button3.Hide();
                        button5.Hide();
                        MessageBox.Show("Meximum ETH to Exchange is 50 ETH\nBTCสูงสุดที่แลกเปลี่ยนได้คือ 50 ETH");
                    }
                    if (ex > your)
                    {
                        MessageBox.Show("Not enough ETH in your wallet");
                    }
                }
            }
            if (comboBox1.Text == "Binance(BNB)")
            {
                if (textBox5.Text == "")
                {
                    MessageBox.Show("Please complete all information.\nกรุณากรอกจำนวนให้ครบถ้วน");
                }
                else
                {
                    float your = float.Parse(textBox6.Text);
                    float ex = float.Parse(textBox5.Text);
                    if (ex <= your)
                    {
                        float recivebtc;
                        recivebtc = (ex * pricebnb) / pricebtc;
                        if (recivebtc > 0.001)
                        {
                            textBox11.Text = Convert.ToString(recivebtc);
                            button4.Show();
                        }
                        else
                        {
                            textBox11.Text = "Lower then 0.001";
                            button4.Hide();
                        }

                        float reciveeth;
                        reciveeth = (ex * pricebnb) / priceeth;
                        if (reciveeth > 0.001)
                        {
                            textBox12.Text = Convert.ToString(reciveeth);
                            button1.Show();
                        }
                        else
                        {
                            textBox12.Text = "Lower then 0.001";
                            button1.Hide();
                        }

                        float recivebnb;
                        recivebnb = (ex * pricebnb) / pricebnb;
                        if (recivebnb > 0.001)
                        {
                            textBox13.Text = Convert.ToString(recivebnb);
                            button2.Show();
                        }
                        else
                        {
                            textBox13.Text = "Lower then 0.001";
                            button2.Hide();
                        }

                        float reciveuni;
                        reciveuni = (ex * pricebnb) / priceuni;
                        if (reciveuni > 0.001)
                        {
                            textBox14.Text = Convert.ToString(reciveuni);
                            button3.Show();
                        }
                        else
                        {
                            textBox14.Text = "Lower then 0.001";
                            button3.Hide();
                        }

                        float recivedoge;
                        recivedoge = (ex * pricebnb) / pricedoge;
                        if (recivedoge > 0.001)
                        {
                            textBox15.Text = Convert.ToString(recivedoge);
                            button5.Show();
                        }
                        else
                        {
                            textBox15.Text = "Lower then 0.001";
                            button5.Hide();
                        }
                    }
                    if (ex > 400)
                    {
                        textBox2.Text = "";
                        textBox3.Text = "";
                        textBox5.Text = "";
                        textBox7.Text = "";
                        textBox9.Text = "";
                        textBox11.Text = "";
                        textBox12.Text = "";
                        textBox13.Text = "";
                        textBox14.Text = "";
                        textBox15.Text = "";
                        button4.Hide();
                        button1.Hide();
                        button2.Hide();
                        button3.Hide();
                        button5.Hide();
                        MessageBox.Show("Meximum BNB to Exchange is 400 BNB\nBTCสูงสุดที่แลกเปลี่ยนได้คือ 400 BNB");
                    }
                    if (ex > your)
                    {
                        MessageBox.Show("Not enough BNB in your wallet");
                    }
                }
            }
            if (comboBox1.Text == "Uniswap(UNI)")
            {
                if (textBox7.Text == "")
                {
                    MessageBox.Show("Please complete all information.\nกรุณากรอกจำนวนให้ครบถ้วน");
                }
                else
                {
                    float your = float.Parse(textBox8.Text);
                    float ex = float.Parse(textBox7.Text);
                    if (ex <= your)
                    {
                        float recivebtc;
                        recivebtc = (ex * priceuni) / pricebtc;
                        if (recivebtc > 0.001)
                        {
                            textBox11.Text = Convert.ToString(recivebtc);
                            button4.Show();
                        }
                        else
                        {
                            textBox11.Text = "Lower then 0.001";
                            button4.Hide();
                        }

                        float reciveeth;
                        reciveeth = (ex * priceuni) / priceeth;
                        if (reciveeth > 0.001)
                        {
                            textBox12.Text = Convert.ToString(reciveeth);
                            button1.Show();
                        }
                        else
                        {
                            textBox12.Text = "Lower then 0.001";
                            button1.Hide();
                        }

                        float recivebnb;
                        recivebnb = (ex * priceuni) / pricebnb;
                        if (recivebnb > 0.001)
                        {
                            textBox13.Text = Convert.ToString(recivebnb);
                            button2.Show();
                        }
                        else
                        {
                            textBox13.Text = "Lower then 0.001";
                            button2.Hide();
                        }

                        float reciveuni;
                        reciveuni = (ex * priceuni) / priceuni;
                        if (reciveuni > 0.001)
                        {
                            textBox14.Text = Convert.ToString(reciveuni);
                            button3.Show();
                        }
                        else
                        {
                            textBox14.Text = "Lower then 0.001";
                            button3.Hide();
                        }

                        float recivedoge;
                        recivedoge = (ex * priceuni) / pricedoge;
                        if (recivedoge > 0.001)
                        {
                            textBox15.Text = Convert.ToString(recivedoge);
                            button5.Show();
                        }
                        else
                        {
                            textBox15.Text = "Lower then 0.001";
                            button5.Hide();
                        }
                    }
                    if (ex > 5000)
                    {
                        textBox2.Text = "";
                        textBox3.Text = "";
                        textBox5.Text = "";
                        textBox7.Text = "";
                        textBox9.Text = "";
                        textBox11.Text = "";
                        textBox12.Text = "";
                        textBox13.Text = "";
                        textBox14.Text = "";
                        textBox15.Text = "";
                        button4.Hide();
                        button1.Hide();
                        button2.Hide();
                        button3.Hide();
                        button5.Hide();
                        MessageBox.Show("Meximum UNI to Exchange is UNI 5000\nBTCสูงสุดที่แลกเปลี่ยนได้คือ UNI 5000");
                    }
                    if (ex > your)
                    {
                        MessageBox.Show("Not enough UNI in your wallet");
                    }
                }
            }
            if (comboBox1.Text == "DogeCoin(DOGE)")
            {
                if (textBox9.Text == "")
                {
                    MessageBox.Show("Please complete all information.\nกรุณากรอกจำนวนให้ครบถ้วน");
                }
                else
                {
                    float your = float.Parse(textBox10.Text);
                    float ex = float.Parse(textBox9.Text);
                    if (ex <= your)
                    {
                        float recivebtc;
                        recivebtc = (ex * pricedoge) / pricebtc;
                        if (recivebtc > 0.001)
                        {
                            textBox11.Text = Convert.ToString(recivebtc);
                            button4.Show();
                        }
                        else
                        {
                            textBox11.Text = "Lower then 0.001";
                            button4.Hide();
                        }

                        float reciveeth;
                        reciveeth = (ex * pricedoge) / priceeth;
                        if (reciveeth > 0.001)
                        {
                            textBox12.Text = Convert.ToString(reciveeth);
                            button1.Show();
                        }
                        else
                        {
                            textBox12.Text = "Lower then 0.001";
                            button1.Hide();
                        }

                        float recivebnb;
                        recivebnb = (ex * pricedoge) / pricebnb;
                        if (recivebnb > 0.001)
                        {
                            textBox13.Text = Convert.ToString(recivebnb);
                            button2.Show();
                        }
                        else
                        {
                            textBox13.Text = "Lower then 0.001";
                            button2.Hide();
                        }

                        float reciveuni;
                        reciveuni = (ex * pricedoge) / priceuni;
                        if (reciveuni > 0.001)
                        {
                            textBox14.Text = Convert.ToString(reciveuni);
                            button3.Show();
                        }
                        else
                        {
                            textBox14.Text = "Lower then 0.001";
                            button3.Hide();
                        }

                        float recivedoge;
                        recivedoge = (ex * pricedoge) / pricedoge;
                        if (recivedoge > 0.001)
                        {
                            textBox15.Text = Convert.ToString(recivedoge);
                            button5.Show();
                        }
                        else
                        {
                            textBox15.Text = "Lower then 0.001";
                            button5.Hide();
                        }
                    }
                    if (ex > 500000)
                    {
                        textBox2.Text = "";
                        textBox3.Text = "";
                        textBox5.Text = "";
                        textBox7.Text = "";
                        textBox9.Text = "";
                        textBox11.Text = "";
                        textBox12.Text = "";
                        textBox13.Text = "";
                        textBox14.Text = "";
                        textBox15.Text = "";
                        button4.Hide();
                        button1.Hide();
                        button2.Hide();
                        button3.Hide();
                        button5.Hide();
                        MessageBox.Show("Meximum DOGE to Exchange is DOGE 500000\nBTCสูงสุดที่แลกเปลี่ยนได้คือDOGE 500000");

                    }
                    if (ex > your)
                    {
                        MessageBox.Show("Not enough DOGE in your wallet");
                    }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Bitcoin(BTC)")
            {
                MessageBox.Show("You can not Exchange the same Crypto coin.");
            }
            if (comboBox1.Text == "Ethereum(ETH)")
            {
                DB db = new DB();

                MySqlCommand command = new MySqlCommand("UPDATE `user` SET `btc`= @btc WHERE `username`='" + textBox16.Text + "'", db.GetConnection());
                float recive = float.Parse(textBox11.Text); //ช่อง recive
                float walletadd = float.Parse(textBox21.Text); //wallet
                float recivetotal;
                recivetotal = walletadd + recive;
                command.Parameters.Add("@btc", MySqlDbType.VarChar).Value = recivetotal;

                MySqlCommand command1 = new MySqlCommand("UPDATE `user` SET `eth`= @eth WHERE `username`='" + textBox16.Text + "'", db.GetConnection());
                float exchange = float.Parse(textBox3.Text); //ช่อง exchange
                float walletdis = float.Parse(textBox20.Text);//wallet
                float extotal;
                extotal = walletdis - exchange;
                command1.Parameters.Add("@eth", MySqlDbType.VarChar).Value = extotal;

                db.openConnection();
                if (command.ExecuteNonQuery() == 1)
                {
                    if (command1.ExecuteNonQuery() == 1)
                    {
                        MySqlCommand command0 = new MySqlCommand("SELECT * FROM `user` WHERE `username`='" + textBox16.Text + "'", db.GetConnection());
                        db.openConnection();
                        MySqlDataReader dataReader = command0.ExecuteReader();
                        if (dataReader.Read())
                        {
                            textBox21.Text = dataReader.GetValue(7).ToString();
                            textBox1.Text = dataReader.GetValue(7).ToString();

                            textBox20.Text = dataReader.GetValue(8).ToString();
                            textBox4.Text = dataReader.GetValue(8).ToString();

                            textBox19.Text = dataReader.GetValue(9).ToString();
                            textBox6.Text = dataReader.GetValue(9).ToString();

                            textBox18.Text = dataReader.GetValue(10).ToString();
                            textBox8.Text = dataReader.GetValue(10).ToString();

                            textBox17.Text = dataReader.GetValue(11).ToString();
                            textBox10.Text = dataReader.GetValue(11).ToString();

                            MessageBox.Show("Exchange Successfully.");

                            button4.Hide();
                            button1.Hide();
                            button2.Hide();
                            button3.Hide();
                            button5.Hide();
                        }
                        db.closeConnection();

                        textBox2.Text = "";
                        textBox3.Text = "";
                        textBox5.Text = "";
                        textBox7.Text = "";
                        textBox9.Text = "";
                        textBox15.Text = "";
                        textBox14.Text = "";
                        textBox13.Text = "";
                        textBox12.Text = "";
                        textBox11.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
            if (comboBox1.Text == "Binance(BNB)")
            {
                DB db = new DB();

                MySqlCommand command = new MySqlCommand("UPDATE `user` SET `btc`= @btc WHERE `username`='" + textBox16.Text + "'", db.GetConnection());
                float recive = float.Parse(textBox11.Text); //ช่อง recive
                float walletadd = float.Parse(textBox21.Text); //wallet
                float recivetotal;
                recivetotal = walletadd + recive;
                command.Parameters.Add("@btc", MySqlDbType.VarChar).Value = recivetotal;

                MySqlCommand command1 = new MySqlCommand("UPDATE `user` SET `bnb`= @bnb WHERE `username`='" + textBox16.Text + "'", db.GetConnection());
                float exchange = float.Parse(textBox5.Text); //ช่อง exchange
                float walletdis = float.Parse(textBox19.Text);//wallet
                float extotal;
                extotal = walletdis - exchange;
                command1.Parameters.Add("@bnb", MySqlDbType.VarChar).Value = extotal;

                db.openConnection();
                if (command.ExecuteNonQuery() == 1)
                {
                    if (command1.ExecuteNonQuery() == 1)
                    {
                        MySqlCommand command0 = new MySqlCommand("SELECT * FROM `user` WHERE `username`='" + textBox16.Text + "'", db.GetConnection());
                        db.openConnection();
                        MySqlDataReader dataReader = command0.ExecuteReader();
                        if (dataReader.Read())
                        {
                            textBox21.Text = dataReader.GetValue(7).ToString();
                            textBox1.Text = dataReader.GetValue(7).ToString();

                            textBox20.Text = dataReader.GetValue(8).ToString();
                            textBox4.Text = dataReader.GetValue(8).ToString();

                            textBox19.Text = dataReader.GetValue(9).ToString();
                            textBox6.Text = dataReader.GetValue(9).ToString();

                            textBox18.Text = dataReader.GetValue(10).ToString();
                            textBox8.Text = dataReader.GetValue(10).ToString();

                            textBox17.Text = dataReader.GetValue(11).ToString();
                            textBox10.Text = dataReader.GetValue(11).ToString();

                            MessageBox.Show("Exchange Successfully.");

                            button4.Hide();
                            button1.Hide();
                            button2.Hide();
                            button3.Hide();
                            button5.Hide();
                        }
                        db.closeConnection();

                        textBox2.Text = "";
                        textBox3.Text = "";
                        textBox5.Text = "";
                        textBox7.Text = "";
                        textBox9.Text = "";
                        textBox15.Text = "";
                        textBox14.Text = "";
                        textBox13.Text = "";
                        textBox12.Text = "";
                        textBox11.Text = "";

                    }
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
            if (comboBox1.Text == "Uniswap(UNI)")
            {
                DB db = new DB();

                MySqlCommand command = new MySqlCommand("UPDATE `user` SET `btc`= @btc WHERE `username`='" + textBox16.Text + "'", db.GetConnection());
                float recive = float.Parse(textBox11.Text); //ช่อง recive
                float walletadd = float.Parse(textBox21.Text); //wallet
                float recivetotal;
                recivetotal = walletadd + recive;
                command.Parameters.Add("@btc", MySqlDbType.VarChar).Value = recivetotal;

                MySqlCommand command1 = new MySqlCommand("UPDATE `user` SET `uni`= @uni WHERE `username`='" + textBox16.Text + "'", db.GetConnection());
                float exchange = float.Parse(textBox7.Text); //ช่อง exchange
                float walletdis = float.Parse(textBox18.Text);//wallet
                float extotal;
                extotal = walletdis - exchange;
                command1.Parameters.Add("@uni", MySqlDbType.VarChar).Value = extotal;

                db.openConnection();
                if (command.ExecuteNonQuery() == 1)
                {
                    if (command1.ExecuteNonQuery() == 1)
                    {
                        MySqlCommand command0 = new MySqlCommand("SELECT * FROM `user` WHERE `username`='" + textBox16.Text + "'", db.GetConnection());
                        db.openConnection();
                        MySqlDataReader dataReader = command0.ExecuteReader();
                        if (dataReader.Read())
                        {
                            textBox21.Text = dataReader.GetValue(7).ToString();
                            textBox1.Text = dataReader.GetValue(7).ToString();

                            textBox20.Text = dataReader.GetValue(8).ToString();
                            textBox4.Text = dataReader.GetValue(8).ToString();

                            textBox19.Text = dataReader.GetValue(9).ToString();
                            textBox6.Text = dataReader.GetValue(9).ToString();

                            textBox18.Text = dataReader.GetValue(10).ToString();
                            textBox8.Text = dataReader.GetValue(10).ToString();

                            textBox17.Text = dataReader.GetValue(11).ToString();
                            textBox10.Text = dataReader.GetValue(11).ToString();

                            MessageBox.Show("Exchange Successfully.");

                            button4.Hide();
                            button1.Hide();
                            button2.Hide();
                            button3.Hide();
                            button5.Hide();
                        }
                        db.closeConnection();

                        textBox2.Text = "";
                        textBox3.Text = "";
                        textBox5.Text = "";
                        textBox7.Text = "";
                        textBox9.Text = "";
                        textBox15.Text = "";
                        textBox14.Text = "";
                        textBox13.Text = "";
                        textBox12.Text = "";
                        textBox11.Text = "";

                    }
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
            if (comboBox1.Text == "DogeCoin(DOGE)")
            {
                DB db = new DB();

                MySqlCommand command = new MySqlCommand("UPDATE `user` SET `btc`= @btc WHERE `username`='" + textBox16.Text + "'", db.GetConnection());
                float recive = float.Parse(textBox11.Text); //ช่อง recive
                float walletadd = float.Parse(textBox21.Text); //wallet
                float recivetotal;
                recivetotal = walletadd + recive;
                command.Parameters.Add("@btc", MySqlDbType.VarChar).Value = recivetotal;

                MySqlCommand command1 = new MySqlCommand("UPDATE `user` SET `doge`= @doge WHERE `username`='" + textBox16.Text + "'", db.GetConnection());
                float exchange = float.Parse(textBox9.Text); //ช่อง exchange
                float walletdis = float.Parse(textBox17.Text);//wallet
                float extotal;
                extotal = walletdis - exchange;
                command1.Parameters.Add("@doge", MySqlDbType.VarChar).Value = extotal;

                db.openConnection();
                if (command.ExecuteNonQuery() == 1)
                {
                    if (command1.ExecuteNonQuery() == 1)
                    {
                        MySqlCommand command0 = new MySqlCommand("SELECT * FROM `user` WHERE `username`='" + textBox16.Text + "'", db.GetConnection());
                        db.openConnection();
                        MySqlDataReader dataReader = command0.ExecuteReader();
                        if (dataReader.Read())
                        {
                            textBox21.Text = dataReader.GetValue(7).ToString();
                            textBox1.Text = dataReader.GetValue(7).ToString();

                            textBox20.Text = dataReader.GetValue(8).ToString();
                            textBox4.Text = dataReader.GetValue(8).ToString();

                            textBox19.Text = dataReader.GetValue(9).ToString();
                            textBox6.Text = dataReader.GetValue(9).ToString();

                            textBox18.Text = dataReader.GetValue(10).ToString();
                            textBox8.Text = dataReader.GetValue(10).ToString();

                            textBox17.Text = dataReader.GetValue(11).ToString();
                            textBox10.Text = dataReader.GetValue(11).ToString();

                            MessageBox.Show("Exchange Successfully.");

                            button4.Hide();
                            button1.Hide();
                            button2.Hide();
                            button3.Hide();
                            button5.Hide();
                        }
                        db.closeConnection();

                        textBox2.Text = "";
                        textBox3.Text = "";
                        textBox5.Text = "";
                        textBox7.Text = "";
                        textBox9.Text = "";
                        textBox15.Text = "";
                        textBox14.Text = "";
                        textBox13.Text = "";
                        textBox12.Text = "";
                        textBox11.Text = "";

                    }
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Bitcoin(BTC)")
            {
                DB db = new DB();

                MySqlCommand command = new MySqlCommand("UPDATE `user` SET `eth`= @eth WHERE `username`='" + textBox16.Text + "'", db.GetConnection());
                float recive = float.Parse(textBox12.Text); //ช่อง recive
                float walletadd = float.Parse(textBox20.Text); //wallet
                float recivetotal;
                recivetotal = walletadd + recive;
                command.Parameters.Add("@eth", MySqlDbType.VarChar).Value = recivetotal;

                MySqlCommand command1 = new MySqlCommand("UPDATE `user` SET `btc`= @btc WHERE `username`='" + textBox16.Text + "'", db.GetConnection());
                float exchange = float.Parse(textBox2.Text); //ช่อง exchange
                float walletdis = float.Parse(textBox21.Text);//wallet
                float extotal;
                extotal = walletdis - exchange;
                command1.Parameters.Add("@btc", MySqlDbType.VarChar).Value = extotal;

                db.openConnection();
                if (command.ExecuteNonQuery() == 1)
                {
                    if (command1.ExecuteNonQuery() == 1)
                    {
                        MySqlCommand command0 = new MySqlCommand("SELECT * FROM `user` WHERE `username`='" + textBox16.Text + "'", db.GetConnection());
                        db.openConnection();
                        MySqlDataReader dataReader = command0.ExecuteReader();
                        if (dataReader.Read())
                        {
                            textBox21.Text = dataReader.GetValue(7).ToString();
                            textBox1.Text = dataReader.GetValue(7).ToString();

                            textBox20.Text = dataReader.GetValue(8).ToString();
                            textBox4.Text = dataReader.GetValue(8).ToString();

                            textBox19.Text = dataReader.GetValue(9).ToString();
                            textBox6.Text = dataReader.GetValue(9).ToString();

                            textBox18.Text = dataReader.GetValue(10).ToString();
                            textBox8.Text = dataReader.GetValue(10).ToString();

                            textBox17.Text = dataReader.GetValue(11).ToString();
                            textBox10.Text = dataReader.GetValue(11).ToString();

                            MessageBox.Show("Exchange Successfully.");

                            button4.Hide();
                            button1.Hide();
                            button2.Hide();
                            button3.Hide();
                            button5.Hide();
                        }
                        db.closeConnection();

                        textBox2.Text = "";
                        textBox3.Text = "";
                        textBox5.Text = "";
                        textBox7.Text = "";
                        textBox9.Text = "";
                        textBox15.Text = "";
                        textBox14.Text = "";
                        textBox13.Text = "";
                        textBox12.Text = "";
                        textBox11.Text = "";

                    }
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
            if (comboBox1.Text == "Ethereum(ETH)")
            {
                MessageBox.Show("You can not Exchange the same Crypto coin.");
            }
            if (comboBox1.Text == "Binance(BNB)")
            {
                DB db = new DB();

                MySqlCommand command = new MySqlCommand("UPDATE `user` SET `eth`= @eth WHERE `username`='" + textBox16.Text + "'", db.GetConnection());
                float recive = float.Parse(textBox12.Text); //ช่อง recive
                float walletadd = float.Parse(textBox20.Text); //wallet
                float recivetotal;
                recivetotal = walletadd + recive;
                command.Parameters.Add("@eth", MySqlDbType.VarChar).Value = recivetotal;

                MySqlCommand command1 = new MySqlCommand("UPDATE `user` SET `bnb`= @bnb WHERE `username`='" + textBox16.Text + "'", db.GetConnection());
                float exchange = float.Parse(textBox5.Text); //ช่อง exchange
                float walletdis = float.Parse(textBox19.Text);//wallet
                float extotal;
                extotal = walletdis - exchange;
                command1.Parameters.Add("@bnb", MySqlDbType.VarChar).Value = extotal;

                db.openConnection();
                if (command.ExecuteNonQuery() == 1)
                {
                    if (command1.ExecuteNonQuery() == 1)
                    {
                        MySqlCommand command0 = new MySqlCommand("SELECT * FROM `user` WHERE `username`='" + textBox16.Text + "'", db.GetConnection());
                        db.openConnection();
                        MySqlDataReader dataReader = command0.ExecuteReader();
                        if (dataReader.Read())
                        {
                            textBox21.Text = dataReader.GetValue(7).ToString();
                            textBox1.Text = dataReader.GetValue(7).ToString();

                            textBox20.Text = dataReader.GetValue(8).ToString();
                            textBox4.Text = dataReader.GetValue(8).ToString();

                            textBox19.Text = dataReader.GetValue(9).ToString();
                            textBox6.Text = dataReader.GetValue(9).ToString();

                            textBox18.Text = dataReader.GetValue(10).ToString();
                            textBox8.Text = dataReader.GetValue(10).ToString();

                            textBox17.Text = dataReader.GetValue(11).ToString();
                            textBox10.Text = dataReader.GetValue(11).ToString();

                            MessageBox.Show("Exchange Successfully.");

                            button4.Hide();
                            button1.Hide();
                            button2.Hide();
                            button3.Hide();
                            button5.Hide();
                        }
                        db.closeConnection();

                        textBox2.Text = "";
                        textBox3.Text = "";
                        textBox5.Text = "";
                        textBox7.Text = "";
                        textBox9.Text = "";
                        textBox15.Text = "";
                        textBox14.Text = "";
                        textBox13.Text = "";
                        textBox12.Text = "";
                        textBox11.Text = "";

                    }
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
            if (comboBox1.Text == "Uniswap(UNI)")
            {
                DB db = new DB();

                MySqlCommand command = new MySqlCommand("UPDATE `user` SET `eth`= @eth WHERE `username`='" + textBox16.Text + "'", db.GetConnection());
                float recive = float.Parse(textBox12.Text); //ช่อง recive
                float walletadd = float.Parse(textBox20.Text); //wallet
                float recivetotal;
                recivetotal = walletadd + recive;
                command.Parameters.Add("@eth", MySqlDbType.VarChar).Value = recivetotal;

                MySqlCommand command1 = new MySqlCommand("UPDATE `user` SET `uni`= @uni WHERE `username`='" + textBox16.Text + "'", db.GetConnection());
                float exchange = float.Parse(textBox7.Text); //ช่อง exchange
                float walletdis = float.Parse(textBox18.Text);//wallet
                float extotal;
                extotal = walletdis - exchange;
                command1.Parameters.Add("@uni", MySqlDbType.VarChar).Value = extotal;

                db.openConnection();
                if (command.ExecuteNonQuery() == 1)
                {
                    if (command1.ExecuteNonQuery() == 1)
                    {
                        MySqlCommand command0 = new MySqlCommand("SELECT * FROM `user` WHERE `username`='" + textBox16.Text + "'", db.GetConnection());
                        db.openConnection();
                        MySqlDataReader dataReader = command0.ExecuteReader();
                        if (dataReader.Read())
                        {
                            textBox21.Text = dataReader.GetValue(7).ToString();
                            textBox1.Text = dataReader.GetValue(7).ToString();

                            textBox20.Text = dataReader.GetValue(8).ToString();
                            textBox4.Text = dataReader.GetValue(8).ToString();

                            textBox19.Text = dataReader.GetValue(9).ToString();
                            textBox6.Text = dataReader.GetValue(9).ToString();

                            textBox18.Text = dataReader.GetValue(10).ToString();
                            textBox8.Text = dataReader.GetValue(10).ToString();

                            textBox17.Text = dataReader.GetValue(11).ToString();
                            textBox10.Text = dataReader.GetValue(11).ToString();

                            MessageBox.Show("Exchange Successfully.");

                            button4.Hide();
                            button1.Hide();
                            button2.Hide();
                            button3.Hide();
                            button5.Hide();
                        }
                        db.closeConnection();

                        textBox2.Text = "";
                        textBox3.Text = "";
                        textBox5.Text = "";
                        textBox7.Text = "";
                        textBox9.Text = "";
                        textBox15.Text = "";
                        textBox14.Text = "";
                        textBox13.Text = "";
                        textBox12.Text = "";
                        textBox11.Text = "";

                    }
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
            if (comboBox1.Text == "DogeCoin(DOGE)")
            {
                DB db = new DB();

                MySqlCommand command = new MySqlCommand("UPDATE `user` SET `eth`= @eth WHERE `username`='" + textBox16.Text + "'", db.GetConnection());
                float recive = float.Parse(textBox12.Text); //ช่อง recive
                float walletadd = float.Parse(textBox20.Text); //wallet
                float recivetotal;
                recivetotal = walletadd + recive;
                command.Parameters.Add("@eth", MySqlDbType.VarChar).Value = recivetotal;

                MySqlCommand command1 = new MySqlCommand("UPDATE `user` SET `doge`= @doge WHERE `username`='" + textBox16.Text + "'", db.GetConnection());
                float exchange = float.Parse(textBox9.Text); //ช่อง exchange
                float walletdis = float.Parse(textBox17.Text);//wallet
                float extotal;
                extotal = walletdis - exchange;
                command1.Parameters.Add("@doge", MySqlDbType.VarChar).Value = extotal;

                db.openConnection();
                if (command.ExecuteNonQuery() == 1)
                {
                    if (command1.ExecuteNonQuery() == 1)
                    {
                        MySqlCommand command0 = new MySqlCommand("SELECT * FROM `user` WHERE `username`='" + textBox16.Text + "'", db.GetConnection());
                        db.openConnection();
                        MySqlDataReader dataReader = command0.ExecuteReader();
                        if (dataReader.Read())
                        {
                            textBox21.Text = dataReader.GetValue(7).ToString();
                            textBox1.Text = dataReader.GetValue(7).ToString();

                            textBox20.Text = dataReader.GetValue(8).ToString();
                            textBox4.Text = dataReader.GetValue(8).ToString();

                            textBox19.Text = dataReader.GetValue(9).ToString();
                            textBox6.Text = dataReader.GetValue(9).ToString();

                            textBox18.Text = dataReader.GetValue(10).ToString();
                            textBox8.Text = dataReader.GetValue(10).ToString();

                            textBox17.Text = dataReader.GetValue(11).ToString();
                            textBox10.Text = dataReader.GetValue(11).ToString();

                            MessageBox.Show("Exchange Successfully.");

                            button4.Hide();
                            button1.Hide();
                            button2.Hide();
                            button3.Hide();
                            button5.Hide();
                        }
                        db.closeConnection();

                        textBox2.Text = "";
                        textBox3.Text = "";
                        textBox5.Text = "";
                        textBox7.Text = "";
                        textBox9.Text = "";
                        textBox15.Text = "";
                        textBox14.Text = "";
                        textBox13.Text = "";
                        textBox12.Text = "";
                        textBox11.Text = "";

                    }
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Bitcoin(BTC)")
            {
                DB db = new DB();

                MySqlCommand command = new MySqlCommand("UPDATE `user` SET `bnb`= @bnb WHERE `username`='" + textBox16.Text + "'", db.GetConnection());
                float recive = float.Parse(textBox13.Text); //ช่อง recive
                float walletadd = float.Parse(textBox19.Text); //wallet
                float recivetotal;
                recivetotal = walletadd + recive;
                command.Parameters.Add("@bnb", MySqlDbType.VarChar).Value = recivetotal;

                MySqlCommand command1 = new MySqlCommand("UPDATE `user` SET `btc`= @btc WHERE `username`='" + textBox16.Text + "'", db.GetConnection());
                float exchange = float.Parse(textBox2.Text); //ช่อง exchange
                float walletdis = float.Parse(textBox21.Text);//wallet
                float extotal;
                extotal = walletdis - exchange;
                command1.Parameters.Add("@btc", MySqlDbType.VarChar).Value = extotal;

                db.openConnection();
                if (command.ExecuteNonQuery() == 1)
                {
                    if (command1.ExecuteNonQuery() == 1)
                    {
                        MySqlCommand command0 = new MySqlCommand("SELECT * FROM `user` WHERE `username`='" + textBox16.Text + "'", db.GetConnection());
                        db.openConnection();
                        MySqlDataReader dataReader = command0.ExecuteReader();
                        if (dataReader.Read())
                        {
                            textBox21.Text = dataReader.GetValue(7).ToString();
                            textBox1.Text = dataReader.GetValue(7).ToString();

                            textBox20.Text = dataReader.GetValue(8).ToString();
                            textBox4.Text = dataReader.GetValue(8).ToString();

                            textBox19.Text = dataReader.GetValue(9).ToString();
                            textBox6.Text = dataReader.GetValue(9).ToString();

                            textBox18.Text = dataReader.GetValue(10).ToString();
                            textBox8.Text = dataReader.GetValue(10).ToString();

                            textBox17.Text = dataReader.GetValue(11).ToString();
                            textBox10.Text = dataReader.GetValue(11).ToString();

                            MessageBox.Show("Exchange Successfully.");

                            button4.Hide();
                            button1.Hide();
                            button2.Hide();
                            button3.Hide();
                            button5.Hide();
                        }
                        db.closeConnection();

                        textBox2.Text = "";
                        textBox3.Text = "";
                        textBox5.Text = "";
                        textBox7.Text = "";
                        textBox9.Text = "";
                        textBox15.Text = "";
                        textBox14.Text = "";
                        textBox13.Text = "";
                        textBox12.Text = "";
                        textBox11.Text = "";

                    }
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
            if (comboBox1.Text == "Ethereum(ETH)")
            {
                DB db = new DB();

                MySqlCommand command = new MySqlCommand("UPDATE `user` SET `bnb`= @bnb WHERE `username`='" + textBox16.Text + "'", db.GetConnection());
                float recive = float.Parse(textBox13.Text); //ช่อง recive
                float walletadd = float.Parse(textBox19.Text); //wallet
                float recivetotal;
                recivetotal = walletadd + recive;
                command.Parameters.Add("@bnb", MySqlDbType.VarChar).Value = recivetotal;

                MySqlCommand command1 = new MySqlCommand("UPDATE `user` SET `eth`= @eth WHERE `username`='" + textBox16.Text + "'", db.GetConnection());
                float exchange = float.Parse(textBox3.Text); //ช่อง exchange
                float walletdis = float.Parse(textBox20.Text);//wallet
                float extotal;
                extotal = walletdis - exchange;
                command1.Parameters.Add("@eth", MySqlDbType.VarChar).Value = extotal;

                db.openConnection();
                if (command.ExecuteNonQuery() == 1)
                {
                    if (command1.ExecuteNonQuery() == 1)
                    {
                        MySqlCommand command0 = new MySqlCommand("SELECT * FROM `user` WHERE `username`='" + textBox16.Text + "'", db.GetConnection());
                        db.openConnection();
                        MySqlDataReader dataReader = command0.ExecuteReader();
                        if (dataReader.Read())
                        {
                            textBox21.Text = dataReader.GetValue(7).ToString();
                            textBox1.Text = dataReader.GetValue(7).ToString();

                            textBox20.Text = dataReader.GetValue(8).ToString();
                            textBox4.Text = dataReader.GetValue(8).ToString();

                            textBox19.Text = dataReader.GetValue(9).ToString();
                            textBox6.Text = dataReader.GetValue(9).ToString();

                            textBox18.Text = dataReader.GetValue(10).ToString();
                            textBox8.Text = dataReader.GetValue(10).ToString();

                            textBox17.Text = dataReader.GetValue(11).ToString();
                            textBox10.Text = dataReader.GetValue(11).ToString();

                            MessageBox.Show("Exchange Successfully.");

                            button4.Hide();
                            button1.Hide();
                            button2.Hide();
                            button3.Hide();
                            button5.Hide();
                        }
                        db.closeConnection();

                        textBox2.Text = "";
                        textBox3.Text = "";
                        textBox5.Text = "";
                        textBox7.Text = "";
                        textBox9.Text = "";
                        textBox15.Text = "";
                        textBox14.Text = "";
                        textBox13.Text = "";
                        textBox12.Text = "";
                        textBox11.Text = "";

                    }
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
            if (comboBox1.Text == "Binance(BNB)")
            {
                MessageBox.Show("You can not Exchange the same Crypto coin.");
            }
            if (comboBox1.Text == "Uniswap(UNI)")
            {
                DB db = new DB();

                MySqlCommand command = new MySqlCommand("UPDATE `user` SET `bnb`= @bnb WHERE `username`='" + textBox16.Text + "'", db.GetConnection());
                float recive = float.Parse(textBox13.Text); //ช่อง recive
                float walletadd = float.Parse(textBox19.Text); //wallet
                float recivetotal;
                recivetotal = walletadd + recive;
                command.Parameters.Add("@bnb", MySqlDbType.VarChar).Value = recivetotal;

                MySqlCommand command1 = new MySqlCommand("UPDATE `user` SET `uni`= @uni WHERE `username`='" + textBox16.Text + "'", db.GetConnection());
                float exchange = float.Parse(textBox7.Text); //ช่อง exchange
                float walletdis = float.Parse(textBox18.Text);//wallet
                float extotal;
                extotal = walletdis - exchange;
                command1.Parameters.Add("@uni", MySqlDbType.VarChar).Value = extotal;

                db.openConnection();
                if (command.ExecuteNonQuery() == 1)
                {
                    if (command1.ExecuteNonQuery() == 1)
                    {
                        MySqlCommand command0 = new MySqlCommand("SELECT * FROM `user` WHERE `username`='" + textBox16.Text + "'", db.GetConnection());
                        db.openConnection();
                        MySqlDataReader dataReader = command0.ExecuteReader();
                        if (dataReader.Read())
                        {
                            textBox21.Text = dataReader.GetValue(7).ToString();
                            textBox1.Text = dataReader.GetValue(7).ToString();

                            textBox20.Text = dataReader.GetValue(8).ToString();
                            textBox4.Text = dataReader.GetValue(8).ToString();

                            textBox19.Text = dataReader.GetValue(9).ToString();
                            textBox6.Text = dataReader.GetValue(9).ToString();

                            textBox18.Text = dataReader.GetValue(10).ToString();
                            textBox8.Text = dataReader.GetValue(10).ToString();

                            textBox17.Text = dataReader.GetValue(11).ToString();
                            textBox10.Text = dataReader.GetValue(11).ToString();

                            MessageBox.Show("Exchange Successfully.");

                            button4.Hide();
                            button1.Hide();
                            button2.Hide();
                            button3.Hide();
                            button5.Hide();
                        }
                        db.closeConnection();

                        textBox2.Text = "";
                        textBox3.Text = "";
                        textBox5.Text = "";
                        textBox7.Text = "";
                        textBox9.Text = "";
                        textBox15.Text = "";
                        textBox14.Text = "";
                        textBox13.Text = "";
                        textBox12.Text = "";
                        textBox11.Text = "";

                    }
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
            if (comboBox1.Text == "DogeCoin(DOGE)")
            {
                DB db = new DB();

                MySqlCommand command = new MySqlCommand("UPDATE `user` SET `bnb`= @bnb WHERE `username`='" + textBox16.Text + "'", db.GetConnection());
                float recive = float.Parse(textBox13.Text); //ช่อง recive
                float walletadd = float.Parse(textBox19.Text); //wallet
                float recivetotal;
                recivetotal = walletadd + recive;
                command.Parameters.Add("@bnb", MySqlDbType.VarChar).Value = recivetotal;

                MySqlCommand command1 = new MySqlCommand("UPDATE `user` SET `doge`= @doge WHERE `username`='" + textBox16.Text + "'", db.GetConnection());
                float exchange = float.Parse(textBox9.Text); //ช่อง exchange
                float walletdis = float.Parse(textBox17.Text);//wallet
                float extotal;
                extotal = walletdis - exchange;
                command1.Parameters.Add("@doge", MySqlDbType.VarChar).Value = extotal;

                db.openConnection();
                if (command.ExecuteNonQuery() == 1)
                {
                    if (command1.ExecuteNonQuery() == 1)
                    {
                        MySqlCommand command0 = new MySqlCommand("SELECT * FROM `user` WHERE `username`='" + textBox16.Text + "'", db.GetConnection());
                        db.openConnection();
                        MySqlDataReader dataReader = command0.ExecuteReader();
                        if (dataReader.Read())
                        {
                            textBox21.Text = dataReader.GetValue(7).ToString();
                            textBox1.Text = dataReader.GetValue(7).ToString();

                            textBox20.Text = dataReader.GetValue(8).ToString();
                            textBox4.Text = dataReader.GetValue(8).ToString();

                            textBox19.Text = dataReader.GetValue(9).ToString();
                            textBox6.Text = dataReader.GetValue(9).ToString();

                            textBox18.Text = dataReader.GetValue(10).ToString();
                            textBox8.Text = dataReader.GetValue(10).ToString();

                            textBox17.Text = dataReader.GetValue(11).ToString();
                            textBox10.Text = dataReader.GetValue(11).ToString();

                            MessageBox.Show("Exchange Successfully.");

                            button4.Hide();
                            button1.Hide();
                            button2.Hide();
                            button3.Hide();
                            button5.Hide();
                        }
                        db.closeConnection();

                        textBox2.Text = "";
                        textBox3.Text = "";
                        textBox5.Text = "";
                        textBox7.Text = "";
                        textBox9.Text = "";
                        textBox15.Text = "";
                        textBox14.Text = "";
                        textBox13.Text = "";
                        textBox12.Text = "";
                        textBox11.Text = "";

                    }
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Bitcoin(BTC)")
            {
                DB db = new DB();

                MySqlCommand command = new MySqlCommand("UPDATE `user` SET `uni`= @uni WHERE `username`='" + textBox16.Text + "'", db.GetConnection());
                float recive = float.Parse(textBox14.Text); //ช่อง recive
                float walletadd = float.Parse(textBox18.Text); //wallet
                float recivetotal;
                recivetotal = walletadd + recive;
                command.Parameters.Add("@uni", MySqlDbType.VarChar).Value = recivetotal;

                MySqlCommand command1 = new MySqlCommand("UPDATE `user` SET `btc`= @btc WHERE `username`='" + textBox16.Text + "'", db.GetConnection());
                float exchange = float.Parse(textBox2.Text); //ช่อง exchange
                float walletdis = float.Parse(textBox21.Text);//wallet
                float extotal;
                extotal = walletdis - exchange;
                command1.Parameters.Add("@btc", MySqlDbType.VarChar).Value = extotal;

                db.openConnection();
                if (command.ExecuteNonQuery() == 1)
                {
                    if (command1.ExecuteNonQuery() == 1)
                    {
                        MySqlCommand command0 = new MySqlCommand("SELECT * FROM `user` WHERE `username`='" + textBox16.Text + "'", db.GetConnection());
                        db.openConnection();
                        MySqlDataReader dataReader = command0.ExecuteReader();
                        if (dataReader.Read())
                        {
                            textBox21.Text = dataReader.GetValue(7).ToString();
                            textBox1.Text = dataReader.GetValue(7).ToString();

                            textBox20.Text = dataReader.GetValue(8).ToString();
                            textBox4.Text = dataReader.GetValue(8).ToString();

                            textBox19.Text = dataReader.GetValue(9).ToString();
                            textBox6.Text = dataReader.GetValue(9).ToString();

                            textBox18.Text = dataReader.GetValue(10).ToString();
                            textBox8.Text = dataReader.GetValue(10).ToString();

                            textBox17.Text = dataReader.GetValue(11).ToString();
                            textBox10.Text = dataReader.GetValue(11).ToString();

                            MessageBox.Show("Exchange Successfully.");

                            button4.Hide();
                            button1.Hide();
                            button2.Hide();
                            button3.Hide();
                            button5.Hide();
                        }
                        db.closeConnection();

                        textBox2.Text = "";
                        textBox3.Text = "";
                        textBox5.Text = "";
                        textBox7.Text = "";
                        textBox9.Text = "";
                        textBox15.Text = "";
                        textBox14.Text = "";
                        textBox13.Text = "";
                        textBox12.Text = "";
                        textBox11.Text = "";

                    }
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
            if (comboBox1.Text == "Ethereum(ETH)")
            {
                DB db = new DB();

                MySqlCommand command = new MySqlCommand("UPDATE `user` SET `uni`= @uni WHERE `username`='" + textBox16.Text + "'", db.GetConnection());
                float recive = float.Parse(textBox14.Text); //ช่อง recive
                float walletadd = float.Parse(textBox18.Text); //wallet
                float recivetotal;
                recivetotal = walletadd + recive;
                command.Parameters.Add("@uni", MySqlDbType.VarChar).Value = recivetotal;

                MySqlCommand command1 = new MySqlCommand("UPDATE `user` SET `eth`= @eth WHERE `username`='" + textBox16.Text + "'", db.GetConnection());
                float exchange = float.Parse(textBox3.Text); //ช่อง exchange
                float walletdis = float.Parse(textBox20.Text);//wallet
                float extotal;
                extotal = walletdis - exchange;
                command1.Parameters.Add("@eth", MySqlDbType.VarChar).Value = extotal;

                db.openConnection();
                if (command.ExecuteNonQuery() == 1)
                {
                    if (command1.ExecuteNonQuery() == 1)
                    {
                        MySqlCommand command0 = new MySqlCommand("SELECT * FROM `user` WHERE `username`='" + textBox16.Text + "'", db.GetConnection());
                        db.openConnection();
                        MySqlDataReader dataReader = command0.ExecuteReader();
                        if (dataReader.Read())
                        {
                            textBox21.Text = dataReader.GetValue(7).ToString();
                            textBox1.Text = dataReader.GetValue(7).ToString();

                            textBox20.Text = dataReader.GetValue(8).ToString();
                            textBox4.Text = dataReader.GetValue(8).ToString();

                            textBox19.Text = dataReader.GetValue(9).ToString();
                            textBox6.Text = dataReader.GetValue(9).ToString();

                            textBox18.Text = dataReader.GetValue(10).ToString();
                            textBox8.Text = dataReader.GetValue(10).ToString();

                            textBox17.Text = dataReader.GetValue(11).ToString();
                            textBox10.Text = dataReader.GetValue(11).ToString();

                            MessageBox.Show("Exchange Successfully.");

                            button4.Hide();
                            button1.Hide();
                            button2.Hide();
                            button3.Hide();
                            button5.Hide();
                        }
                        db.closeConnection();

                        textBox2.Text = "";
                        textBox3.Text = "";
                        textBox5.Text = "";
                        textBox7.Text = "";
                        textBox9.Text = "";
                        textBox15.Text = "";
                        textBox14.Text = "";
                        textBox13.Text = "";
                        textBox12.Text = "";
                        textBox11.Text = "";

                    }
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
            if (comboBox1.Text == "Binance(BNB)")
            {
                DB db = new DB();

                MySqlCommand command = new MySqlCommand("UPDATE `user` SET `uni`= @uni WHERE `username`='" + textBox16.Text + "'", db.GetConnection());
                float recive = float.Parse(textBox14.Text); //ช่อง recive
                float walletadd = float.Parse(textBox18.Text); //wallet
                float recivetotal;
                recivetotal = walletadd + recive;
                command.Parameters.Add("@uni", MySqlDbType.VarChar).Value = recivetotal;

                MySqlCommand command1 = new MySqlCommand("UPDATE `user` SET `bnb`= @bnb WHERE `username`='" + textBox16.Text + "'", db.GetConnection());
                float exchange = float.Parse(textBox5.Text); //ช่อง exchange
                float walletdis = float.Parse(textBox19.Text);//wallet
                float extotal;
                extotal = walletdis - exchange;
                command1.Parameters.Add("@bnb", MySqlDbType.VarChar).Value = extotal;

                db.openConnection();
                if (command.ExecuteNonQuery() == 1)
                {
                    if (command1.ExecuteNonQuery() == 1)
                    {
                        MySqlCommand command0 = new MySqlCommand("SELECT * FROM `user` WHERE `username`='" + textBox16.Text + "'", db.GetConnection());
                        db.openConnection();
                        MySqlDataReader dataReader = command0.ExecuteReader();
                        if (dataReader.Read())
                        {
                            textBox21.Text = dataReader.GetValue(7).ToString();
                            textBox1.Text = dataReader.GetValue(7).ToString();

                            textBox20.Text = dataReader.GetValue(8).ToString();
                            textBox4.Text = dataReader.GetValue(8).ToString();

                            textBox19.Text = dataReader.GetValue(9).ToString();
                            textBox6.Text = dataReader.GetValue(9).ToString();

                            textBox18.Text = dataReader.GetValue(10).ToString();
                            textBox8.Text = dataReader.GetValue(10).ToString();

                            textBox17.Text = dataReader.GetValue(11).ToString();
                            textBox10.Text = dataReader.GetValue(11).ToString();

                            MessageBox.Show("Exchange Successfully.");

                            button4.Hide();
                            button1.Hide();
                            button2.Hide();
                            button3.Hide();
                            button5.Hide();
                        }
                        db.closeConnection();

                        textBox2.Text = "";
                        textBox3.Text = "";
                        textBox5.Text = "";
                        textBox7.Text = "";
                        textBox9.Text = "";
                        textBox15.Text = "";
                        textBox14.Text = "";
                        textBox13.Text = "";
                        textBox12.Text = "";
                        textBox11.Text = "";

                    }
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
            if (comboBox1.Text == "Uniswap(UNI)")
            {
                MessageBox.Show("You can not Exchange the same Crypto coin.");
            }
            if (comboBox1.Text == "DogeCoin(DOGE)")
            {
                DB db = new DB();

                MySqlCommand command = new MySqlCommand("UPDATE `user` SET `uni`= @uni WHERE `username`='" + textBox16.Text + "'", db.GetConnection());
                float recive = float.Parse(textBox14.Text); //ช่อง recive
                float walletadd = float.Parse(textBox18.Text); //wallet
                float recivetotal;
                recivetotal = walletadd + recive;
                command.Parameters.Add("@uni", MySqlDbType.VarChar).Value = recivetotal;

                MySqlCommand command1 = new MySqlCommand("UPDATE `user` SET `doge`= @doge WHERE `username`='" + textBox16.Text + "'", db.GetConnection());
                float exchange = float.Parse(textBox9.Text); //ช่อง exchange
                float walletdis = float.Parse(textBox17.Text);//wallet
                float extotal;
                extotal = walletdis - exchange;
                command1.Parameters.Add("@doge", MySqlDbType.VarChar).Value = extotal;

                db.openConnection();
                if (command.ExecuteNonQuery() == 1)
                {
                    if (command1.ExecuteNonQuery() == 1)
                    {
                        MySqlCommand command0 = new MySqlCommand("SELECT * FROM `user` WHERE `username`='" + textBox16.Text + "'", db.GetConnection());
                        db.openConnection();
                        MySqlDataReader dataReader = command0.ExecuteReader();
                        if (dataReader.Read())
                        {
                            textBox21.Text = dataReader.GetValue(7).ToString();
                            textBox1.Text = dataReader.GetValue(7).ToString();

                            textBox20.Text = dataReader.GetValue(8).ToString();
                            textBox4.Text = dataReader.GetValue(8).ToString();

                            textBox19.Text = dataReader.GetValue(9).ToString();
                            textBox6.Text = dataReader.GetValue(9).ToString();

                            textBox18.Text = dataReader.GetValue(10).ToString();
                            textBox8.Text = dataReader.GetValue(10).ToString();

                            textBox17.Text = dataReader.GetValue(11).ToString();
                            textBox10.Text = dataReader.GetValue(11).ToString();

                            MessageBox.Show("Exchange Successfully.");

                            button4.Hide();
                            button1.Hide();
                            button2.Hide();
                            button3.Hide();
                            button5.Hide();
                        }
                        db.closeConnection();

                        textBox2.Text = "";
                        textBox3.Text = "";
                        textBox5.Text = "";
                        textBox7.Text = "";
                        textBox9.Text = "";
                        textBox15.Text = "";
                        textBox14.Text = "";
                        textBox13.Text = "";
                        textBox12.Text = "";
                        textBox11.Text = "";

                    }
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Bitcoin(BTC)")
            {
                DB db = new DB();

                MySqlCommand command = new MySqlCommand("UPDATE `user` SET `doge`= @doge WHERE `username`='" + textBox16.Text + "'", db.GetConnection());
                float recive = float.Parse(textBox15.Text); //ช่อง recive
                float walletadd = float.Parse(textBox17.Text); //wallet
                float recivetotal;
                recivetotal = walletadd + recive;
                command.Parameters.Add("@doge", MySqlDbType.VarChar).Value = recivetotal;

                MySqlCommand command1 = new MySqlCommand("UPDATE `user` SET `btc`= @btc WHERE `username`='" + textBox16.Text + "'", db.GetConnection());
                float exchange = float.Parse(textBox2.Text); //ช่อง exchange
                float walletdis = float.Parse(textBox21.Text);//wallet
                float extotal;
                extotal = walletdis - exchange;
                command1.Parameters.Add("@btc", MySqlDbType.VarChar).Value = extotal;

                db.openConnection();
                if (command.ExecuteNonQuery() == 1)
                {
                    if (command1.ExecuteNonQuery() == 1)
                    {
                        MySqlCommand command0 = new MySqlCommand("SELECT * FROM `user` WHERE `username`='" + textBox16.Text + "'", db.GetConnection());
                        db.openConnection();
                        MySqlDataReader dataReader = command0.ExecuteReader();
                        if (dataReader.Read())
                        {
                            textBox21.Text = dataReader.GetValue(7).ToString();
                            textBox1.Text = dataReader.GetValue(7).ToString();

                            textBox20.Text = dataReader.GetValue(8).ToString();
                            textBox4.Text = dataReader.GetValue(8).ToString();

                            textBox19.Text = dataReader.GetValue(9).ToString();
                            textBox6.Text = dataReader.GetValue(9).ToString();

                            textBox18.Text = dataReader.GetValue(10).ToString();
                            textBox8.Text = dataReader.GetValue(10).ToString();

                            textBox17.Text = dataReader.GetValue(11).ToString();
                            textBox10.Text = dataReader.GetValue(11).ToString();

                            MessageBox.Show("Exchange Successfully.");

                            button4.Hide();
                            button1.Hide();
                            button2.Hide();
                            button3.Hide();
                            button5.Hide();
                        }
                        db.closeConnection();

                        textBox2.Text = "";
                        textBox3.Text = "";
                        textBox5.Text = "";
                        textBox7.Text = "";
                        textBox9.Text = "";
                        textBox15.Text = "";
                        textBox14.Text = "";
                        textBox13.Text = "";
                        textBox12.Text = "";
                        textBox11.Text = "";

                    }
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
            if (comboBox1.Text == "Ethereum(ETH)")
            {
                DB db = new DB();

                MySqlCommand command = new MySqlCommand("UPDATE `user` SET `doge`= @doge WHERE `username`='" + textBox16.Text + "'", db.GetConnection());
                float recive = float.Parse(textBox15.Text); //ช่อง recive
                float walletadd = float.Parse(textBox17.Text); //wallet
                float recivetotal;
                recivetotal = walletadd + recive;
                command.Parameters.Add("@doge", MySqlDbType.VarChar).Value = recivetotal;

                MySqlCommand command1 = new MySqlCommand("UPDATE `user` SET `eth`= @eth WHERE `username`='" + textBox16.Text + "'", db.GetConnection());
                float exchange = float.Parse(textBox3.Text); //ช่อง exchange
                float walletdis = float.Parse(textBox20.Text);//wallet
                float extotal;
                extotal = walletdis - exchange;
                command1.Parameters.Add("@eth", MySqlDbType.VarChar).Value = extotal;

                db.openConnection();
                if (command.ExecuteNonQuery() == 1)
                {
                    if (command1.ExecuteNonQuery() == 1)
                    {
                        MySqlCommand command0 = new MySqlCommand("SELECT * FROM `user` WHERE `username`='" + textBox16.Text + "'", db.GetConnection());
                        db.openConnection();
                        MySqlDataReader dataReader = command0.ExecuteReader();
                        if (dataReader.Read())
                        {
                            textBox21.Text = dataReader.GetValue(7).ToString();
                            textBox1.Text = dataReader.GetValue(7).ToString();

                            textBox20.Text = dataReader.GetValue(8).ToString();
                            textBox4.Text = dataReader.GetValue(8).ToString();

                            textBox19.Text = dataReader.GetValue(9).ToString();
                            textBox6.Text = dataReader.GetValue(9).ToString();

                            textBox18.Text = dataReader.GetValue(10).ToString();
                            textBox8.Text = dataReader.GetValue(10).ToString();

                            textBox17.Text = dataReader.GetValue(11).ToString();
                            textBox10.Text = dataReader.GetValue(11).ToString();

                            MessageBox.Show("Exchange Successfully.");

                            button4.Hide();
                            button1.Hide();
                            button2.Hide();
                            button3.Hide();
                            button5.Hide();
                        }
                        db.closeConnection();

                        textBox2.Text = "";
                        textBox3.Text = "";
                        textBox5.Text = "";
                        textBox7.Text = "";
                        textBox9.Text = "";
                        textBox15.Text = "";
                        textBox14.Text = "";
                        textBox13.Text = "";
                        textBox12.Text = "";
                        textBox11.Text = "";

                    }
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
            if (comboBox1.Text == "Binance(BNB)")
            {
                DB db = new DB();

                MySqlCommand command = new MySqlCommand("UPDATE `user` SET `doge`= @doge WHERE `username`='" + textBox16.Text + "'", db.GetConnection());
                float recive = float.Parse(textBox15.Text); //ช่อง recive
                float walletadd = float.Parse(textBox17.Text); //wallet
                float recivetotal;
                recivetotal = walletadd + recive;
                command.Parameters.Add("@doge", MySqlDbType.VarChar).Value = recivetotal;

                MySqlCommand command1 = new MySqlCommand("UPDATE `user` SET `bnb`= @bnb WHERE `username`='" + textBox16.Text + "'", db.GetConnection());
                float exchange = float.Parse(textBox5.Text); //ช่อง exchange
                float walletdis = float.Parse(textBox19.Text);//wallet
                float extotal;
                extotal = walletdis - exchange;
                command1.Parameters.Add("@bnb", MySqlDbType.VarChar).Value = extotal;

                db.openConnection();
                if (command.ExecuteNonQuery() == 1)
                {
                    if (command1.ExecuteNonQuery() == 1)
                    {
                        MySqlCommand command0 = new MySqlCommand("SELECT * FROM `user` WHERE `username`='" + textBox16.Text + "'", db.GetConnection());
                        db.openConnection();
                        MySqlDataReader dataReader = command0.ExecuteReader();
                        if (dataReader.Read())
                        {
                            textBox21.Text = dataReader.GetValue(7).ToString();
                            textBox1.Text = dataReader.GetValue(7).ToString();

                            textBox20.Text = dataReader.GetValue(8).ToString();
                            textBox4.Text = dataReader.GetValue(8).ToString();

                            textBox19.Text = dataReader.GetValue(9).ToString();
                            textBox6.Text = dataReader.GetValue(9).ToString();

                            textBox18.Text = dataReader.GetValue(10).ToString();
                            textBox8.Text = dataReader.GetValue(10).ToString();

                            textBox17.Text = dataReader.GetValue(11).ToString();
                            textBox10.Text = dataReader.GetValue(11).ToString();

                            MessageBox.Show("Exchange Successfully.");

                            button4.Hide();
                            button1.Hide();
                            button2.Hide();
                            button3.Hide();
                            button5.Hide();
                        }
                        db.closeConnection();

                        textBox2.Text = "";
                        textBox3.Text = "";
                        textBox5.Text = "";
                        textBox7.Text = "";
                        textBox9.Text = "";
                        textBox15.Text = "";
                        textBox14.Text = "";
                        textBox13.Text = "";
                        textBox12.Text = "";
                        textBox11.Text = "";

                    }
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
            if (comboBox1.Text == "Uniswap(UNI)")
            {
                DB db = new DB();

                MySqlCommand command = new MySqlCommand("UPDATE `user` SET `doge`= @doge WHERE `username`='" + textBox16.Text + "'", db.GetConnection());
                float recive = float.Parse(textBox15.Text); //ช่อง recive
                float walletadd = float.Parse(textBox17.Text); //wallet
                float recivetotal;
                recivetotal = walletadd + recive;
                command.Parameters.Add("@doge", MySqlDbType.VarChar).Value = recivetotal;

                MySqlCommand command1 = new MySqlCommand("UPDATE `user` SET `uni`= @uni WHERE `username`='" + textBox16.Text + "'", db.GetConnection());
                float exchange = float.Parse(textBox7.Text); //ช่อง exchange
                float walletdis = float.Parse(textBox18.Text);//wallet
                float extotal;
                extotal = walletdis - exchange;
                command1.Parameters.Add("@uni", MySqlDbType.VarChar).Value = extotal;

                db.openConnection();
                if (command.ExecuteNonQuery() == 1)
                {
                    if (command1.ExecuteNonQuery() == 1)
                    {
                        MySqlCommand command0 = new MySqlCommand("SELECT * FROM `user` WHERE `username`='" + textBox16.Text + "'", db.GetConnection());
                        db.openConnection();
                        MySqlDataReader dataReader = command0.ExecuteReader();
                        if (dataReader.Read())
                        {
                            textBox21.Text = dataReader.GetValue(7).ToString();
                            textBox1.Text = dataReader.GetValue(7).ToString();

                            textBox20.Text = dataReader.GetValue(8).ToString();
                            textBox4.Text = dataReader.GetValue(8).ToString();

                            textBox19.Text = dataReader.GetValue(9).ToString();
                            textBox6.Text = dataReader.GetValue(9).ToString();

                            textBox18.Text = dataReader.GetValue(10).ToString();
                            textBox8.Text = dataReader.GetValue(10).ToString();

                            textBox17.Text = dataReader.GetValue(11).ToString();
                            textBox10.Text = dataReader.GetValue(11).ToString();

                            MessageBox.Show("Exchange Successfully.");

                            button4.Hide();
                            button1.Hide();
                            button2.Hide();
                            button3.Hide();
                            button5.Hide();
                        }
                        db.closeConnection();

                        textBox2.Text = "";
                        textBox3.Text = "";
                        textBox5.Text = "";
                        textBox7.Text = "";
                        textBox9.Text = "";
                        textBox15.Text = "";
                        textBox14.Text = "";
                        textBox13.Text = "";
                        textBox12.Text = "";
                        textBox11.Text = "";

                    }
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
            if (comboBox1.Text == "DogeCoin(DOGE)")
            {
                MessageBox.Show("You can not Exchange the same Crypto coin.");
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar != 8 && e.KeyChar != 46))
            {
                e.Handled = true;
            }
        }
    }
}
