using System;
using System.IO;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Drawing;
using System.Diagnostics;
using System.Linq;

namespace NoteBook
{
    public partial class Form1 : Form
    {
        private string FilePath;
        public Form1()
        {
            InitializeComponent();
            
        }


        public void Save_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(FilePath))
                сохранитьКакToolStripMenuItem_Click(sender, e);
            else
                File.WriteAllText(FilePath + ".txt", richTextBox1.Text);
        }
        private void сохранитьКакToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog dialog = new SaveFileDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    FilePath = dialog.FileName;
                    File.WriteAllText(FilePath + ".txt", richTextBox1.Text);
                }
            }
        }

        private void Open_File_Click(object sender, EventArgs e)
        {
            using (var dialog = new OpenFileDialog())
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    FilePath = dialog.FileName;
                    richTextBox1.Text = File.ReadAllText(FilePath);
                    Text = FilePath;
                }

        }


        private void Print_Click(object sender, EventArgs e)
        {
            FilePath = richTextBox1.Text;
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += PrintPageHandler;
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument;

            if (printDialog.ShowDialog() == DialogResult.OK)
                printDialog.Document.Print(); // печатаем
        }

        void PrintPageHandler(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString(FilePath, this.Font, Brushes.Black, 4, 2);
        }

        private void шрифтToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            if (fd.ShowDialog() == DialogResult.OK)
                richTextBox1.Font = fd.Font;
        }

        private void переносПоСловамToolStripMenuItem_Click(object sender, EventArgs e)
        {
            переносПоСловамToolStripMenuItem.Checked = !переносПоСловамToolStripMenuItem.Checked;
            richTextBox1.WordWrap = переносПоСловамToolStripMenuItem.Checked;

        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e) => Close();

        private void Отменить(object sender, EventArgs e) => richTextBox1.Undo();

        private void вырезатьToolStripMenuItem_Click(object sender, EventArgs e) => richTextBox1.Cut();

        private void toolStripMenuItem1_Click(object sender, EventArgs e) => richTextBox1.Copy();

        private void вставитьToolStripMenuItem_Click(object sender, EventArgs e) => richTextBox1.Paste();

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int StartPosDel = richTextBox1.SelectionStart;
            int LenSelection = richTextBox1.SelectionLength;
            richTextBox1.Text = richTextBox1.Text.Remove(StartPosDel, LenSelection);
            richTextBox1.SelectionStart = richTextBox1.Text.Length;
        }

        public int index = 0;
        public string find;
        public string text_all;

        private void поискToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            var f = new Form2();
            f.textBox1.Text = find;
            f.ShowDialog();
            var file = f.textBox1.Text;

            if ( file != find)
            {
                text_all = richTextBox1.Text;
                index = 0;  
                richTextBox1.Find(file, 0, RichTextBoxFinds.None);
                index = text_all.IndexOf(file) + file.Length;
                text_all.Remove(0, index);                   
                find = file;                                 

            }
            else
            {
                if (index < richTextBox1.Text.LastIndexOf(file))
                {
                    richTextBox1.Find(file, index, RichTextBoxFinds.None);
                    index += text_all.IndexOf(file) + file.Length;
                    text_all = text_all.Remove(0, text_all.IndexOf(file) + file.Length);
                }
               else
                {
                    text_all = richTextBox1.Text;
                    index = 0;
                    richTextBox1.Find(file, index, RichTextBoxFinds.None);
                    index = text_all.IndexOf(file) + file.Length;
                }
                
            }

        }

        private void новоеОкноToolStripMenuItem_Click(object sender, EventArgs e)=> Process.Start("Notebook.exe");

        private void времяДатаToolStripMenuItem_Click(object sender, EventArgs e) => richTextBox1.Text += DateTime.Now;

        private void выделитьВсеToolStripMenuItem_Click(object sender, EventArgs e) => richTextBox1.SelectAll();


        private void Zoom_plus(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font(richTextBox1.Font.FontFamily,
                richTextBox1.Font.Size + 1);
        }

        private void уменьшитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Font.Size!=1)
            richTextBox1.Font = new Font(richTextBox1.Font.FontFamily,
                richTextBox1.Font.Size - 1);
        }

        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
    
       
    
}


