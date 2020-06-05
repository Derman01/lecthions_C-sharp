
using System.Collections.Generic;
using System.Windows.Forms;

namespace anastasia
{
    public partial class Data_Add : Form
    {
        public Data_Add(List<int> id_student, List<int> id_discipline)
        {
            InitializeComponent();
            foreach (var i in id_discipline)
                code_disciplane.Items.Add(i);

            foreach(var i in id_student)
            number_book.Items.Add(i);

        }
        public void Updata_tables(List<int> id_student, List<int> id_discipline)
        {
            code_disciplane.Items.Clear();
            number_book.Items.Clear();

            foreach (var i in id_discipline)
                code_disciplane.Items.Add(i);

            foreach (var i in id_student)
                number_book.Items.Add(i);
        }
    }
}
