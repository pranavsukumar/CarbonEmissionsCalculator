﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EESD_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 openForm = new Form2();
            openForm.Show();
            Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
               CarbonSaved openForm = new CarbonSaved();
               openForm.Show();
               Visible = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 openForm = new Form3();
            openForm.Show();
            Visible = false;
        }
    }
}
