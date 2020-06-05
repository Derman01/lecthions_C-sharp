using System.Collections.Generic;
using System.Windows.Forms;

namespace anastasia
{
    public partial class Dicsiplaine : Form
    {
        public Dicsiplaine(List<Data_discipline> _dicsipliane)
        {
            InitializeComponent();
            updata_tables(_dicsipliane);
           
        }
        public void updata_tables(List<Data_discipline> _dicsipliane)
        {
            dataGridView1.Rows.Clear();
            foreach (var data in _dicsipliane)
                dataGridView1.Rows.Add(data._id, data._name_less);
        }

    }
}
