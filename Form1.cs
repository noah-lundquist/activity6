﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace activity2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {



        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double weight;
                double weightOnMars;

                weight = double.Parse(Weight.Text);

                weightOnMars = (weight * .3783);

                marsWeight.Text = weightOnMars.ToString("");

            }
            catch
            {
                MessageBox.Show("Please enter a number");
            }
        }
    }
}
