using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Hotel_Managment
{
    public partial class checkout : Form
    {
        public static Panel main;
        public static homepage fn;
       // int totcat;
        public static string a;
        public static string Doc;
        public checkout(homepage f, Panel p, string s)
        {
            InitializeComponent();
            main = p;
            fn = f;
            a = s;

        }
        private void load()
        {
            string sel = "select * from bookinginfo";
            MySqlDataAdapter das = new MySqlDataAdapter(sel, Class1.cn);
            DataTable dts = new DataTable();
            das.Fill(dts);
            comboBox1.DataSource = dts;
            comboBox1.DisplayMember = "roomno";
        }
        private void clear()
        {
            tname.Text = "";
            tremaining.Text = "";
            tamount.Text = "";
            tdoa.Text = "";
            textBox1.Text = "";
            tpaid.Text = "";
            comboBox1.Text = "";
            

        }

        private void checkout_Load(object sender, EventArgs e)
        {
            load();
            
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ins = "insert into income(name,date,amount) values ('"+tname.Text+"' ,'"+Doc+"', '"+tamount.Text+"')";
            MySqlDataAdapter das = new MySqlDataAdapter(ins, Class1.cn);
            DataTable dts = new DataTable();
            das.Fill(dts);

            string up = "update rooms set status='Available', doa='' , doc='' where rno='" + comboBox1.Text + "'";
                MySqlDataAdapter dup = new MySqlDataAdapter(up, Class1.cn);
            DataTable dts1 = new DataTable();
            dup.Fill(dts1);

            string del = "delete from bookinginfo where roomno='"+comboBox1.Text+"'";
            MySqlDataAdapter ddl = new MySqlDataAdapter(del, Class1.cn);
            DataTable dtd = new DataTable();
            ddl.Fill(dtd);
            clear();
            load();
        }


      

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
          

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Hotel Name", new Font(FontFamily.GenericSansSerif, 16, FontStyle.Bold), Brushes.Black, 80, 10);
            e.Graphics.DrawString("------------------------------------------------------------" , new Font(FontFamily.GenericSansSerif, 10, FontStyle.Bold), Brushes.Black, 0, 40);
            e.Graphics.DrawString("Roomno                  : " + comboBox1.Text, new Font(FontFamily.GenericSansSerif, 10, FontStyle.Bold), Brushes.Black, 10, 80);
            e.Graphics.DrawString("Customer Name    : " + tname.Text, new Font(FontFamily.GenericSansSerif, 10, FontStyle.Bold), Brushes.Black, 10, 100);
            e.Graphics.DrawString("Date Of Arrival       : " + tdoa.Text, new Font(FontFamily.GenericSansSerif, 10, FontStyle.Bold), Brushes.Black, 10, 120);
            e.Graphics.DrawString("Date Of Checkout : " + Doc, new Font(FontFamily.GenericSansSerif, 10, FontStyle.Bold), Brushes.Black, 10, 140);
            e.Graphics.DrawString("------------------------------------------------------------", new Font(FontFamily.GenericSansSerif, 10, FontStyle.Bold), Brushes.Black, 0, printPreviewDialog1.Document.DefaultPageSettings.PaperSize.Height - 70);
            //e.Graphics.DrawImage(bitmap, 0, 60);
            e.Graphics.DrawString(" Total GST : " + textBox1.Text + " \n " + "Total Bill : " + tamount.Text, new Font(FontFamily.GenericSansSerif, 10, FontStyle.Bold), Brushes.Black, 150, printPreviewDialog1.Document.DefaultPageSettings.PaperSize.Height - 40);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            printPreviewDialog1.Document.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("prnm",300,400);
            printPreviewDialog1.ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           // MessageBox.Show(comboBox1.Text);
            string sel = "select * from bookinginfo where roomno='" + comboBox1.Text + "'";
            //  MessageBox.Show(comboBox1.Text);
            MySqlDataAdapter das = new MySqlDataAdapter(sel, Class1.cn);
            DataTable dts = new DataTable();
            das.Fill(dts);
            tname.Text = dts.Rows[0]["c_name"].ToString();
            tamount.Text = dts.Rows[0]["C_TotalBill"].ToString();
            tpaid.Text = dts.Rows[0]["C_Paid"].ToString();
            tremaining.Text = dts.Rows[0]["C_Remaining"].ToString();
            textBox1.Text = dts.Rows[0]["gst"].ToString();

            tdoa.Text = dts.Rows[0]["C_DateOfArrival"].ToString();
            tname.Text = dts.Rows[0]["c_name"].ToString();

            Doc = dts.Rows[0]["C_DateOfCheckOut"].ToString();
        }
    }
}
