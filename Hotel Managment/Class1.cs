using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Hotel_Managment
{
    internal class Class1
    {

        //public static SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\hotelmanagment.mdf;Integrated Security=True");
        public static Form activeForm = null;
        public static string server = "127.0.0.1";
        public static string un = "root";
        public static string pwd = "";
        public static string db = "hotelmanagment";
        public static MySqlConnection cn = new MySqlConnection("server = " + server + ";" + "user id =" + un + ";" + "password = " + pwd + ";" + "database =" + db);

        public static string s_cat;
        public static void openChildForm(Form childForm, Panel p)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            p.Controls.Add(childForm);
            p.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
    }
}
