using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Managment
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (Keys.Escape == keyData)
            {
                Application.Exit();
            }
            return base.ProcessCmdKey(ref msg, keyData);

        }


        private void butlogin_Click(object sender, EventArgs e)
        {

            if (textBox1.Text != "" || textBox2.Text != "")
            {
                if (textBox1.Text != "")
                {
                   
                        if (textBox2.Text != "")
                        {
                            
                            string s = "Select * from login where unm= '" + textBox1.Text + "' and pwd  ='" + textBox2.Text + "' ";
                            SqlDataAdapter adapter = new SqlDataAdapter(s, Class1.cn);
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                         if(dt.Rows.Count==1)
                        {
                            MessageBox.Show("Login Sucssefuly !");
                            homepage hp = new homepage();
                            hp.Show();
                            this.Hide();
                        }
                         else
                        {
                            MessageBox.Show("User Not Found !");
                        }

                        }
                        else
                        {
                            MessageBox.Show("Enter Password !");
                        }
                    

                }

                else
                {
                    MessageBox.Show("Enter User Name !");
                }
            }
            else
            {
                MessageBox.Show("Enter Detail !");
            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
        }
    
