using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ulong sayı, sonuç = 1;
                sayı = ulong.Parse(textBox1.Text);
                if (sayı == 0)
                {
                    sonuç = 1;
                }
                else
                {
                    for (ulong i = 1; i <= sayı; i++)
                    {
                        sonuç = sonuç * i;
                    }
                }
                textBox2.Text = sonuç.ToString();

            }
            catch (Exception)
            {

                MessageBox.Show("LÜTFEN GEÇERLİ DEĞER GİRİN");
            }
            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox1.Focus();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
