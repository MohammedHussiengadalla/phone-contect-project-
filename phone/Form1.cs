using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public struct newphone
        {

            public string firstname { get; set; }
            public int mobile { get; set; }
            public string lastname { get; set; }
            public string email { get; set; }
            public string jop { get; set; }

        }
        public newphone[] arr = new newphone[50];
         public int conter = 0;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string fname = textBox6.Text;
            for(int i = 0; i < conter; i++)
            {
                if (arr[i].firstname == fname)
                {
                   
                    for (int j = i; j <= conter; j++)
                    {
                        arr[j ].firstname = arr[j+1].firstname;

                        arr[j ].lastname = arr[j+1].lastname;
                        arr[j].email = arr[j + 1].email;
                        arr[j].mobile = arr[j + 1].mobile;
                        arr[j].jop = arr[j + 1].jop;
                    }
                    conter -= 1;
                    MessageBox.Show("complete delete ");
                    break;
                    
                }


            }

           /* int INDEX = Array.IndexOf(arr, fname);
            List<newphone> tem = new List<newphone>(arr);
            tem.RemoveAt(INDEX);
            arr = tem.ToArray();
            MessageBox.Show("delete");*/
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            arr[conter].firstname = textBox1.Text;
            arr[conter].lastname = textBox2.Text;
            arr[conter].mobile = Convert.ToInt32(textBox4.Text);
            arr[conter].email = textBox3.Text; ;
            arr[conter].jop = textBox5.Text;



            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();

            textBox5.Clear();
            MessageBox.Show("added succes");
            conter++;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
      
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Search n = new Search();
            n.Show();
            this.Hide();
            /*string x = textBox7.Text;
            bool v = false;
            for (int i = 0; i < conter; i++)
            {
                if (arr[i].firstname == x)
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
            }*/
            }
    }
}
