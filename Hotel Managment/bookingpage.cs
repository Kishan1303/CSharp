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

namespace Hotel_Managment
{
    public partial class bookingpage : Form
    {
        public static Panel main;
        public static homepage fn;
        public static string a;
        public static int oram;


        // int totcat, oid;
        //int pxloc = 50, pyloc = 80, lxloc = 50, lyloc = 80;


        private void clear()
        {
            tname.Text = "";
            tacno.Text = "";
            
            tta.Text = "";
            tad.Text = "";
            tage.Text = "";
            tr.Text = "";
            tgst.Text="";
            tmo.Text = "";
            tcat.Text = "";
            trn.Text = "";
            ttp.Text = "";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string ins = "INSERT INTO `bookinginfo`( `c_name`, `c_num`, `C_Age`, `C_TotalMember`, `C_AdharCardNumber`, `C_Paid`, `C_Remaining`,`gst`, `C_TotalBill`, `C_DateOfArrival`, `C_DateOfCheckOut`, `roomno`, `catagory`) VALUES ('" + tname.Text + "','" + tmo.Text + "','" + tage.Text + "','" + ttp.Text + "','" + tacno.Text + "','" + tad.Text + "','" + tr.Text + "','"+tgst.Text+"','" + tta.Text + "','" + dateTimePicker1.Value.ToShortDateString() + "','" + dateTimePicker2.Value.ToShortDateString() + "','"+trn.Text+"','"+tcat.Text+"')";
            MySqlDataAdapter adapter = new MySqlDataAdapter(ins,Class1.cn);
            DataTable dt1= new DataTable();
            adapter.Fill(dt1);
            clear();

            string up = "update rooms set doa='" + dateTimePicker1.Value.ToShortDateString() + "' , doc='"+dateTimePicker2.Value.ToShortDateString()+"', status ='Unavailable'  where rno='"+trn.Text+"' ";
            MySqlDataAdapter dau= new MySqlDataAdapter(up,Class1.cn);
            DataTable dataTable = new DataTable();
            dau.Fill(dataTable);
        }

        public bookingpage(homepage f, Panel p, string s)
        {
            InitializeComponent();
            main = p;
            fn = f;
            a = s;

        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (Keys.Escape == keyData)
            {
                Application.Exit();
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tcat.Text = Class1.s_cat;
            trn.Text = a;
            


            string sel = "select amount from rooms where catagory='" + tcat.Text + "'and rno='"+trn.Text+"'";
            MySqlDataAdapter das = new MySqlDataAdapter(sel,Class1.cn);
            DataTable dt1= new DataTable();
            das.Fill(dt1);
            tta.Text = dt1.Rows[0]["amount"].ToString();
            oram = Convert.ToInt32(tta.Text);


        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
           // string d1 = dateTimePicker2.Value.ToShortDateString();
           // int d2 = Convert.ToInt32(d1.Substring(0, 2));

          //  string a1 = dateTimePicker1.Value.ToShortDateString();
           // int a2 = Convert.ToInt32(a1.Substring(0, 2));

           // int a3 = d2 - a2;
           // int a4 = Convert.ToInt32(tta.Text);
           // int a5 = a4 * a3;
           // tta.Text = a5.ToString();


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            tgst.Text = "0";
            tta.Text = oram.ToString();
            
            try {
                int amt = Convert.ToInt32(textBox1.Text);
                int rc = Convert.ToInt32(tta.Text);
                double charge = amt * rc;
                double gst = charge * 0.12;
                tgst.Text = gst.ToString();
                charge +=gst; 
                tta.Text = charge.ToString();
            }

            catch(Exception)
            {
                tta.Text =oram.ToString();
                textBox1.Text = "";
                tgst.Text = "";
            }
        }

        private void tad_TextChanged(object sender, EventArgs e)
        {
            int ad = Convert.ToInt32(tad.Text);
            int ta = Convert.ToInt32(tta.Text);
            int re = ta - ad;
            tr.Text = re.ToString();
        }
    }
}
