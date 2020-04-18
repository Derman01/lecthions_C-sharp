using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Опрос
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            //контейне с вопросами выравниваются и становятся рзмером с главный контейнер
            panel15.Width = panel14.Width = panel13.Width = panel12.Width = panel11.Width = panel10.Width = panel9.Width = panel8.Width = panel7.Width = panel6.Width = panel5.Width = panel4.Width = panel3.Width = panel2.Width = panel1.Width;
            panel1.Location = new Point(this.Width / 2 - panel1.Width / 2 - 15,  pictureBox2.Height + 10);
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {//изменение положение контейнера с вопросамипри измении размера  окна
        //у меня все по середине находится, как бы не меняться размер окна            
            panel1.Location = new Point(this.Width / 2 - panel1.Width / 2 - 15, panel1.Location.Y);
            
        }

        private void RadioButton11_CheckedChanged(object sender, EventArgs e) //по какому напрвлению?
        {//доступ к написании другого варианта 
            if (radioButton11.Checked) textBox3.Visible = true;
            else { textBox3.Visible = false; textBox3.Text = ""; }
        }

        private void RadioButton19_CheckedChanged(object sender, EventArgs e)// с какой целью вы занимаетесь спортом
        {//доступ к написании другого варианта 
            if (radioButton19.Checked) textBox4.Visible = true;
            else { textBox4.Visible = false; textBox4.Text = ""; }
        }

        private void RadioButton28_CheckedChanged(object sender, EventArgs e) //в каком рео
        {//доступ к написании другого варианта 
            if (radioButton28.Checked) textBox5.Visible = true;
            else { textBox5.Visible = false; textBox5.Text = ""; }
        }
    }
}
