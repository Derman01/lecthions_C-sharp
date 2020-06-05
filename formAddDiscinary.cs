using System;
using System.Windows.Forms;

namespace anastasia
{
    public partial class formAddDiscinary : Form
    {
        public formAddDiscinary()
        {
            InitializeComponent();
        }
        public bool was = false;
        private void btn_Add_discinary_Click(object sender, EventArgs e)
        {
            was = true;
            Close();
        }
    }
}
