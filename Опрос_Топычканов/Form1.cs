using System;
using System.IO;
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
        Dictionary<string, string> opros = new Dictionary<string, string>
        {
            { "ФИО", ""},
            { "Пол", "" },
            { "Дата рождения", "" },
            { "Статус", "" },
            { "Тренируетесь ли в каком-либо спортивном клубе?", "" },
            { "В каком спортивном клубе вы тренируетесь?", "" },
            { "По какому направлению", "" },
            { "Какой вид спорта вам более интересен?", "" },
            { "Какая физическая активность на ваш взгляд интересней и востребованей?", "" },
            { "C какой целью вы занимаетесь спортом?", "" },
            { "Знакомы ли вы с направлением фитнеса Bungee workout?",""},
            { "Хотели бы вы попробовать что-то новое в сфере фитнеса и спорта?",""},
            { "Как вы относитесь к новинкам в сфере фитнеса и спорта?",""},
            { "Как считаете, в каком районе Тюмени недостаточно филиалов спортивных клубов?",""}
        };

        public Form1()
        {
            InitializeComponent();
            pictureBox2.Location = new Point(this.Width / 2 - pictureBox2.Width / 2 - 15, 5);
            panel15.Width = panel14.Width = panel13.Width = panel12.Width = panel11.Width = panel10.Width = panel9.Width = panel8.Width = panel7.Width = panel6.Width = panel5.Width = panel4.Width = panel3.Width = panel2.Width = panel1.Width;
            panel1.Location = new Point(this.Width / 2 - panel1.Width / 2 - 15,  pictureBox2.Height + 10);
            
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {//изменение положение контейнер по середине при изменении размера  окна
              panel1.Location = new Point(this.Width / 2 - panel1.Width / 2 - 15, panel1.Location.Y);
            pictureBox2.Location = new Point(this.Width / 2 - pictureBox2.Width / 2 - 15, 5);
        }
        private void RadioButton11_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton11.Checked) textBox3.Visible = true;
            else { textBox3.Visible = false; textBox3.Text = ""; }
        }
        private void RadioButton19_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton19.Checked) textBox4.Visible = true;
            else { textBox4.Visible = false; textBox4.Text = ""; }
        }
        private void RadioButton28_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton28.Checked) textBox5.Visible = true;
            else { textBox5.Visible = false; textBox5.Text = ""; }
        }


        private void Button1_Click(object sender, EventArgs e)
        {
            {
                opros["ФИО"] = textBox1.Text;
            }//ФИО
            {
                if (Pol_Man.Checked) opros["Пол"] = "Мужской";
                if (Pol_Women.Checked) opros["Пол"] = "Женский";
            }//пол
            {
                string data = Convert.ToString(dateTimePicker1.Value);
                string data_Real = "";
                for (int i = 0; i < 10; i++)
                    data_Real += data[i];
                opros["Дата рождения"] = data_Real;
            }//дата рождения
            {
                if (radioButton4.Checked) opros["Статус"] = "Учусь в школе";
                if (radioButton2.Checked) opros["Статус"] = "Студент";
                if (radioButton1.Checked) opros["Статус"] = "Работаю";
                if (radioButton3.Checked) opros["Статус"] = "Безработный";
            }//статус
            {
                if (radioButton6.Checked) opros["Тренируетесь ли в каком-либо спортивном клубе?"] = "Да";
                if (radioButton5.Checked) opros["Тренируетесь ли в каком-либо спортивном клубе?"] = "Нет";
            }//Тренируетесь
            {
                opros["В каком спортивном клубе вы тренируетесь ?"] = textBox2.Text;
            }//какой клуб
            {
                if (radioButton8.Checked) opros["По какому направлению"] = "Фитнес";
                if (radioButton7.Checked) opros["По какому направлению"] = "Единоборство";
                if (radioButton12.Checked) opros["По какому направлению"] = "Легкая атлетика";
                if (radioButton11.Checked) opros["По какому направлению"] = textBox3.Text;
            }//какое направление
            {
                if (checkBox1.Checked) opros["Какой вид спорта вам более интересен?"] += "Баскетбол  ";
                if (checkBox2.Checked) opros["Какой вид спорта вам более интересен?"] += "Волейбол  ";
                if (checkBox3.Checked) opros["Какой вид спорта вам более интересен?"] += "Теннис  ";
                if (checkBox4.Checked) opros["Какой вид спорта вам более интересен?"] += "Водное поло  ";
                if (checkBox5.Checked) opros["Какой вид спорта вам более интересен?"] += "Борьба  ";
                if (opros["Какой вид спорта вам более интересен?"] != "")
                {
                    opros["Какой вид спорта вам более интересен?"] = opros["Какой вид спорта вам более интересен?"].Remove(opros["Какой вид спорта вам более интересен?"].Length - 2, 1);
                    opros["Какой вид спорта вам более интересен?"] = opros["Какой вид спорта вам более интересен?"].Replace("  ", ", ");
                }

            }//kakoy vid sporta
            {
                string k = "Какая физическая активность на ваш взгляд интересней и востребованей?";
                if (radioButton10.Checked) opros[k] = radioButton10.Text;
                if (radioButton9.Checked) opros[k] = radioButton9.Text;
                if (radioButton13.Checked) opros[k] = radioButton13.Text;
                if (radioButton14.Checked) opros[k] = radioButton14.Text;
            }//fiz aktivnost
            {
                string k = "C какой целью вы занимаетесь спортом?";
                if (radioButton18.Checked) opros[k] = radioButton18.Text;
                if (radioButton17.Checked) opros[k] = radioButton17.Text;
                if (radioButton16.Checked) opros[k] = radioButton16.Text;
                if (radioButton19.Checked) opros[k] = radioButton19.Text;
            }//s kakoy целью
            {
                string k = "Знакомы ли вы с направлением фитнеса Bungee workout?";
                if (radioButton21.Checked) opros[k] = radioButton21.Text;
                if (radioButton20.Checked) opros[k] = radioButton20.Text;
            }//Bungee workaout
            {
                string k = "Хотели бы вы попробовать что-то новое в сфере фитнеса и спорта?";
                if (radioButton23.Checked) opros[k] = radioButton23.Text;
                if (radioButton22.Checked) opros[k] = radioButton22.Text;
                if (radioButton24.Checked) opros[k] = radioButton24.Text;
            }// новое в спорте
            {
                string k = "Как вы относитесь к новинкам в сфере фитнеса и спорта?";
                if (radioButton25.Checked) opros[k] = radioButton25.Text;
                if (radioButton26.Checked) opros[k] = radioButton26.Text;
                if (radioButton27.Checked) opros[k] = radioButton27.Text;
            }//как относитесь к новинкам
            {
                string k = "Как считаете, в каком районе Тюмени недостаточно филиалов спортивных клубов?";
                if (radioButton30.Checked) opros[k] = radioButton30.Text;
                if (radioButton31.Checked) opros[k] = radioButton31.Text;
                if (radioButton32.Checked) opros[k] = radioButton32.Text;
                if (radioButton29.Checked) opros[k] = radioButton29.Text;
                if (radioButton28.Checked) opros[k] = textBox5.Text;
            }//в какой районе живешь

            var f = new StreamWriter( opros["ФИО"] + ".txt");
            foreach (KeyValuePair<string, string> keyValue in opros)
            {
                if (keyValue.Value != "")
                    f.WriteLine(keyValue.Key + "  :  " + keyValue.Value);
            }
            f.Close();
            Application.Exit();
            
        }

    }
    

}
