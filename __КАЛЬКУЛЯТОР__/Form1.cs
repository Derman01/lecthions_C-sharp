using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace __КАЛЬКУЛЯТОР__
{
    public partial class Form1 : Form
    {
        float a, b;
        int count;
        bool znak = true;
        bool was = false;
        public Form1()
        {
            InitializeComponent();
            this.Cursor = System.Windows.Forms.Cursors.Default;

        }

        private void Button15_Click(object sender, EventArgs e)
        {
          textBox1.Text = textBox1.Text + 0;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 1;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 2;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 3;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 4;
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 5;
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 6;
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 7;
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 8;
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 9;
        }

        private void Button20_Click(object sender, EventArgs e)
        {

            if (was) { wased(); }
            else { a = float.Parse(textBox1.Text); }

            textBox1.Clear();
            count = 1;
            label1.Text =  "+" + a.ToString() ;
            znak = true;
            was = true;
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            if (was) { wased(); }
            else { a = float.Parse(textBox1.Text); }
            textBox1.Clear();
            
            count = 2;
            label1.Text ="-" + a.ToString();
            znak = true; was = true;
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            if (was) { wased(); }
            else { a = float.Parse(textBox1.Text); }
            textBox1.Clear();
           
            count = 3;
            label1.Text = "*" + a.ToString();
            znak = true; was = true; 
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            if (was) { wased(); }
            else { a = float.Parse(textBox1.Text); }
            textBox1.Clear();
            
            count = 4;
            label1.Text =  "/" + a.ToString();
            znak = true; was = true;
        }

        private void Button13_Click(object sender, EventArgs e)
        {
            calculate();
            label1.Text = "";
            was = false;
        }

        private void Button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "," ;
        }

        private void Button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label1.Text = "";
        }

        private void Button16_Click(object sender, EventArgs e)
        {
            int lenght = textBox1.Text.Length - 1;
            string text = textBox1.Text;
            textBox1.Clear();
            for (int i = 0; i < lenght; i++)
            {
                textBox1.Text = textBox1.Text + text[i];
            }
        }

        private void Button19_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void calculate()
        {
            switch (count)
            {
                case 1:
                    b = a + float.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                case 2:
                    b = a - float.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                case 3:
                    b = a * float.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                case 4:
                    b = a / float.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
               
                default:
                    break;
            }
            if (b < 0)
            {
                textBox1.Text = (-b).ToString() + "-";
                
            }



        }

        private void Button18_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            textBox1.Text = Convert.ToString(Math.Sqrt(a));
                       
        }

        private void wased()
        {
            int lenght = label1.Text.Length - 1;
            string text = label1.Text;
            textBox1.Clear();
            for (int i = 0; i < lenght; i++)
            {
                label1.Text = label1.Text + text[i];
            }
            
        }
    }
}
