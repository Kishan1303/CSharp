﻿using System;
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
            Class1.openChildForm(new Form1(), p_fm);
        }
    }
}
