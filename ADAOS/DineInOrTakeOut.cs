﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADAOS
{
    public partial class DineInOrTakeOut : Form
    {
        private System.Windows.Forms.Timer timer1;
        public DineInOrTakeOut()
        {
            InitializeComponent();
            timer1 = new System.Windows.Forms.Timer();
            timer1.Interval = 1; // set the interval in milliseconds
            timer1.Tick += new EventHandler(timer1_Tick);
        }


        private void btnDineIn_Click(object sender, EventArgs e)
        {
            progressBar1.Maximum = 100;
            timer1.Start();
            progressBar1.Visible = true;
        }

        private void btnTakeOut_Click(object sender, EventArgs e)
        {
            progressBar1.Maximum = 100;
            timer1.Start();
            progressBar1.Visible = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Increment the value of the ProgressBar
            progressBar1.Value += 1;

            // If the ProgressBar reaches its maximum value, stop the timer
            if (progressBar1.Value == progressBar1.Maximum)
            {
                timer1.Stop();
                Menu firstForm = new Menu();
                firstForm.Show();
                this.Hide();
            }
        }
    }
}
