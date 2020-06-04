using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Tables
{
    public partial class Form1 : Form
    {
        public string FilePath;
        Diagram f = new Diagram();

        public Form1()
        {
            InitializeComponent();
            dataGridView1.Rows.Add("Американский доллар", 1);
            dataGridView1.Rows.Add("Евро", 0.9);
            dataGridView1.Rows.Add("Финская марка", 5.14);
            dataGridView1.Rows.Add("Английский фунт стерлингов", 0.62);
            f.Show(); f.Visible = false;
        }

        private void calculat_Click(object sender, EventArgs e)
        {
            try
            {
                var rub = double.Parse(textBox1.Text) / 70;
                double d;
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    try
                    {
                        dataGridView1[2, i].Value = Math.Round( rub * Convert.ToDouble(dataGridView1.Rows[i].Cells[1].Value), 4);
                    }
                    catch
                    {
                        dataGridView1[2, i].Value = "";
                    }
            }
            catch
            {
                MessageBox.Show("Неправильно введеное значение");
            }
            
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string _text = "";

            var dlina = 40;
            var Name = new List<(string n, string c, string s)>();
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
                Name.Add((dataGridView1[0, i].Value.ToString(),
                    dataGridView1[1, i].Value.ToString(),
                    dataGridView1[2, i].Value.ToString()));

            
            _text += ("Валюта" + new string(' ', 33) + "Курс" + new string(' ', 16) + "Сумма") + "\n";
            _text += (new string('_', 70)) + "\n";

            foreach (var i in Name)
                _text += (i.n + new string(' ', dlina - i.n.Length - 8) + "|" + new string(' ', 7) 
                    + i.c + new string(' ', dlina - 20 - i.c.Length - 8) + "|" + new string(' ', 7) + i.s) + "\n";

            _text += (new string('_', 70) + $"\nРублей: {textBox1.Text}") + "\n";

            using (SaveFileDialog dialog = new SaveFileDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    FilePath = dialog.FileName;
                    File.WriteAllText(FilePath + ".txt", _text);
                }
            }
            
        }

        private void оРазработчикеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Топычканов Денис Сергеевич\nИиП ПИ-19.02-1");
        }

        private void Add_Click(object sender, EventArgs e)
        {
            var f_add = new Form2();
            f_add.ShowDialog();
            if (f_add._add)
            {
                dataGridView1.Rows.Add(f_add.Value_name.Text, f_add.Course_name.Text);
            }
            f_add.Close();
            update();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            int _index = -1;
            for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
            {
                _index = dataGridView1.SelectedRows[i].Index;
            }
            if (_index != - 1)
                dataGridView1.Rows.Remove(dataGridView1.Rows[_index]);
            update();
        }

        private void Open_Diagram_Click(object sender, EventArgs e)
        {
            
            Open_Diagram.Checked = !Open_Diagram.Checked;
            if (Open_Diagram.Checked)
            {
                f.Visible = true;
                f.Location = new Point(Location.X + Width - 7, Location.Y + 30);
                update();
            }
            else
            {
                f.Visible = false;
            }
        }
        void update()
        {
            f.chart1.Series[0].Points.Clear();
            for (var i = 0; i < dataGridView1.Rows.Count; i++)
            {
                f.chart1.Series[0].Points.Add(Convert.ToDouble(dataGridView1[1, i].Value));
                f.chart1.Series[0].Points[i].LegendText = Convert.ToString(dataGridView1[0, i].Value);
            }
        }

        private void Form1_LocationChanged(object sender, EventArgs e) => f.Location = new Point(Location.X + Width - 7, Location.Y + 33); 
        private void Form1_SizeChanged(object sender, EventArgs e) => f.Location = new Point(Location.X + Width - 7, Location.Y + 33);
        
    }
}
