using System;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace anastasia
{
    public partial class Tables : Form
    {
        static List<Data_student> _student = new List<Data_student>(3)
        {
            new Data_student
            {
                _code = 1,
                _numberbook = 3029858,
                _name = "Сидоров Г.В",
                _direction = "ПИ"
            },
            new Data_student
            {
                _code = 2,
                _numberbook = 3048967,
                _name = "Иванов А.П",
                _direction = "ПИ"
            },
            new Data_student
            {
                _code = 3,
                _numberbook = 3204894,
                _name = "Петров А.С",
                _direction = "ПИ"
            }
        };
        Dictionary<int, int> book_to_index = new Dictionary<int, int>();
        static List<Data_discipline> _discipline = new List<Data_discipline>(3) {
            new Data_discipline
            {
                _id = 1,
                _name_less = "Дискретная математика"
            },
            new Data_discipline
            {
                _id = 2,
                _name_less = "Программирование"
            },
            new Data_discipline
            {
                _id = 3,
                _name_less = "Английский"
            }
        };
        Dictionary<int, int> id_to_index = new Dictionary<int, int>();
        Dictionary<int, int> nomer_to_index = new Dictionary<int, int>();
        static List<Data_person> _person = new List<Data_person>(0);
        

        Data_Add forma_person;
        Dicsiplaine forma_dicsiplaine;
        Students forma_student;

        public Tables()
        {
            InitializeComponent();
            updata_index();
            dataGridView1.Columns.Add("name_person", "Имя");
            dataGridView1.Columns["name_person"].Visible = false;
            dataGridView1.Columns.Add("name_object", "Дисциплина");
            dataGridView1.Columns["name_object"].Visible = false;
            for (var i = 1; i != 4; i++)
            _person.Add(new Data_person
            {
                number = i,
                code_discoplane = _discipline[i-1]._id,
                _data_Discipline = _discipline[i-1],
                number_book = _student[i-1]._numberbook,
                _data_student = _student[i-1],
                score = "Отлично"
            });
            updata_index();
            Update_table();
            
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            var id_dis = new List<int>(0);
            var id_stud = new List<int>(0);

            foreach (var i in _discipline)
               id_dis.Add(i._id);
            foreach (var i in _student)
                id_stud.Add(i._numberbook);

            forma_person = new Data_Add(id_stud, id_dis);
           
            forma_person.Show();
            forma_person.Add_row.Click += Data_add_person;
            forma_person.button_Cancel.Click += Button_Cancel_Click;
            forma_person.button_disciplane.Click += Button_disciplane_Click;
            forma_person.button_number_book.Click += Button_number_book_Click;
            
        }

        private void Button_number_book_Click(object sender, EventArgs e)
        {
            forma_student = new Students(_student);
            forma_student.Show();
            forma_student.button_Add.Click += Add_student;

        }

        private void Add_student(object sender, EventArgs e)
        {
            var f = new formAddStudent();
            f.ShowDialog();
            if (f.was)
            {
                _student.Add(new Data_student
                {
                    _code = _student.Count + 1,
                    _name = f.txt_name.Text,
                    _direction = f.txt_dictinary.Text,
                    _numberbook = int.Parse(f.Txt_numer_book.Text),
                });
                forma_student.Updata_tables(_student);
                var id_dis = new List<int>(0);
                var id_stud = new List<int>(0);

                foreach (var i in _discipline)
                    id_dis.Add(i._id);
                foreach (var i in _student)
                    id_stud.Add(i._numberbook);
                updata_index();
                forma_person.Updata_tables(id_stud, id_dis);
            }
            
        }

        private void Button_disciplane_Click(object sender, EventArgs e)
        {
            forma_dicsiplaine = new Dicsiplaine(_discipline);
            forma_dicsiplaine.Show();
            forma_dicsiplaine.button_Add.Click += Add_discipline;
        }

        private void Add_discipline(object sender, EventArgs e)
        {
            var f = new formAddDiscinary();
            f.ShowDialog();
            if (f.was)
            {
                _discipline.Add(new Data_discipline { 
                    _id = _discipline.Count + 1,
                    _name_less = f.txt_name_dictinary.Text
                });
                forma_dicsiplaine.updata_tables(_discipline);
                var id_dis = new List<int>(0);
                var id_stud = new List<int>(0);

                foreach (var i in _discipline)
                    id_dis.Add(i._id);
                foreach (var i in _student)
                    id_stud.Add(i._numberbook);
                updata_index();
                forma_person.Updata_tables(id_stud, id_dis);
            }
        }

        private void Button_Cancel_Click(object sender, EventArgs e) => forma_person.Close();
        private void Data_add_person(object sender, EventArgs e)
        {
            try
            {
                _person.Add(new Data_person
                {
                    number = _person.Count + 1,
                    _data_Discipline = _discipline[id_to_index[int.Parse(forma_person.code_disciplane.SelectedItem.ToString())]],
                    code_discoplane = int.Parse(forma_person.code_disciplane.SelectedItem.ToString()),
                    number_book = int.Parse(forma_person.number_book.SelectedItem.ToString()),
                    _data_student = _student[book_to_index[int.Parse(forma_person.number_book.SelectedItem.ToString())]],
                    score = forma_person.score.SelectedItem.ToString()
                });
                _person[_person.Count - 1]._data_Discipline =
                    _discipline[id_to_index[_person[_person.Count - 1].code_discoplane]];
                _person[_person.Count - 1]._data_student =
                    _student[book_to_index[_person[_person.Count - 1].number_book]];
                Update_table();
            }
            catch
            {
                MessageBox.Show("НЕ веделены данные");
            }
        }
        private void Update_table()
        {
            dataGridView1.Rows.Clear();
            foreach(var person in _person)
                dataGridView1.Rows.Add(person.number = dataGridView1.Rows.Count + 1, 
                    person.code_discoplane, person.number_book, person.score,
                    person._data_student._name,person._data_Discipline._name_less);
            
        }
        private void updata_index() {

            book_to_index.Clear();
            id_to_index.Clear();
            nomer_to_index.Clear();
            for (var i = 0; i < _student.Count; i++)
                book_to_index.Add(_student[i]._numberbook, i);

            for (var i = 0; i < _discipline.Count; i++)
                id_to_index.Add(_discipline[i]._id, i);

            for (var i = 0; i < _person.Count; i++)
                nomer_to_index.Add(_person[i].number_book, i);
        }

        private void visable_name_Click_1(object sender, EventArgs e)
        {
            visable_name.Checked = !visable_name.Checked;
            dataGridView1.Columns["name_person"].Visible = visable_name.Checked;
        }
        private void visable_object_Click(object sender, EventArgs e)
        {
            visable_object.Checked = !visable_object.Checked;
            dataGridView1.Columns["name_object"].Visible = visable_object.Checked;
        }
        private void Save_file_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Еще не готово");
        }
        private void button3_Click(object sender, EventArgs e)
        {
            int _index = -1;
            for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
                _index = dataGridView1.SelectedRows[i].Index;
            if (_index != -1)
                _person.RemoveAt(_index);
            Update_table();
            updata_index();
        }
    }
}
