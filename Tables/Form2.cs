using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tables
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public bool _add = false;

        private void Add_Click(object sender, EventArgs e)
        {
            double d;
            if (Double.TryParse(Course_name.Text, out d))
            {
                _add = true;
                Close();
            }
            else
            {
                MessageBox.Show("Неправильно введен курс");
            }
           
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
