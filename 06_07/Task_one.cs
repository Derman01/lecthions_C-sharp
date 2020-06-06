using System.Windows.Forms;

namespace _06_07
{
    public partial class Task_one : Form
    {
        public Task_one()
        {
            InitializeComponent();
            for(var i = 0; i < 4; i++)
            {
                dataGridView1.Columns.Add($"Column{i}", $"Колона {i}");
                dataGridView1.Rows.Add();
            }
            for (var i = 0; i < dataGridView1.Rows.Count; i++)
                for (var j = 0; j < dataGridView1.Columns.Count; j++)
                    dataGridView1[j, i].Value = (i, j).ToString();
        }
        void updata_listBox()
        {
            listBox1.Items.Clear();
            for (var i = 0; i < dataGridView1.Rows.Count; i++)
            {
                listBox1.Items.Add("");
                for (var j = 0; j < dataGridView1.Columns.Count; j++)
                    listBox1.Items[i] += dataGridView1[j, i].Value.ToString() + "\t";
            }
        }

        private void button_updata_Click_1(object sender, System.EventArgs e) => updata_listBox();
    }
}
