using System.Collections.Generic;
using System.Windows.Forms;

namespace anastasia
{
    public partial class Students : Form
    {
        public Students(List<Data_student> _student)
        {
            InitializeComponent();
            foreach (var data in _student)
                dataGridView1.Rows.Add(data._code,  data._numberbook, data._name, data._direction);
        }
        public void Updata_tables(List<Data_student> _student)
        {
            dataGridView1.Rows.Clear();
            foreach (var data in _student)
                dataGridView1.Rows.Add(data._code, data._numberbook, data._name, data._direction);
        }
    }
}
