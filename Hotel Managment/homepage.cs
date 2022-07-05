using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Managment
{
    public partial class homepage : Form
    {
        public homepage()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Class1.openChildForm(new bookingpage(this, p_fm, "0"), p_fm);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Class1.openChildForm(new singlecat(this,p_fm,"0"),this.p_fm);

        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if(Keys.Escape==keyData)
            {
                Application.Exit();
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void p_fm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void homepage_Load(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            Class1.openChildForm(new checkout(this, p_fm, "0"), this.p_fm);
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Class1.openChildForm(new staffmanagement(this, p_fm, "0"), this.p_fm);
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Class1.openChildForm(new income(), this.p_fm);
        }
    }
}
