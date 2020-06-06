using System.Windows.Forms;

namespace _06_07
{
    public partial class Task_two : Form
    {
        public Task_two()
        {
            InitializeComponent();
            comboBox1.Items.Add("Message");
            comboBox1.Items.Add("About");
        } 
        private void comboBox1_SelectionChangeCommitted(object sender, System.EventArgs e)
        {
            switch (comboBox1.SelectedItem)
            {
                case "Message":
                    MessageBox.Show("Окно-сообщение", "Задание 1");
                    break;
                case "About":
                    var f = new form_message();
                    f.ShowDialog();
                    break;
                default:
                    break;
            }
        }

        private void выходToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Close();
        }
    }
}
