using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sinavHesaplamalari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string isim;
            int sinav1, sinav2, ortalama;
            isim = textBox1.Text;
            sinav1 = Convert.ToInt32(textBox2.Text);
            sinav2 = Convert.ToInt32(textBox3.Text);
            ortalama = (sinav1 +sinav2) / 2;
           

            if (ortalama>=50)
            {
               listBox4.Items.Add(ortalama);
               listBox5.Items.Add("Geçti"); 
            }
            else
            {
                listBox4.Items.Add(ortalama);
                listBox5.Items.Add("Kaldı");
            }

            listBox1.Items.Add(textBox1.Text);
            listBox2.Items.Add(textBox2.Text);
            listBox3.Items.Add(textBox3.Text);
          
            

            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox1.Focus();
        }
    }
}
