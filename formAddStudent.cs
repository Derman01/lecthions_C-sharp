using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace anastasia
{
    public partial class formAddStudent : Form
    {
        public bool was = false;
        public formAddStudent()
        {
            InitializeComponent();
        }

        private void btn_add_student_from_form_Click(object sender, EventArgs e)
        {
            was = true;
            Close();
        }
    }
}
