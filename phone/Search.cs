﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace phone
{
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            string x = textBox1.Text;
            bool v = false;
            for (int i = 0; i < f.conter; i++)
            {
                if (f.arr[i].firstname == x)
                {
                    v = true;
                    break;

                }
                else
                    continue;
            }

            if (v == true)
            {
                MessageBox.Show("Is Found");
            }
            else
            {
                MessageBox.Show("Not Found");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
