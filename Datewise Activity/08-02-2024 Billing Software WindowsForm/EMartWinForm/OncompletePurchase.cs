﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EMartWinForm
{
    public partial class OncompletePurchase : Form
    {
        public OncompletePurchase()
        {
            InitializeComponent();
        }

        private void OncompletePurchase_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home hm = new Home();
            hm.Show();
        }
    }
}
