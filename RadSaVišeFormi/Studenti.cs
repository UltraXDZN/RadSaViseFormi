using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadSaVišeFormi
{
    public delegate void AddStudentEvent(Student student);
    public partial class Studenti : Form
    {
        public AddStudentEvent noviStudent;

        public List<Student> studenti = new List<Student>();

        public Studenti()
        {
            InitializeComponent();
            noviStudent += new AddStudentEvent(InputFormData);
        }

        public void InputFormData(Student student)
        {
            studenti.Add(student);
            listaStudenata.Text += student.ShowData() + "\r\n";
        }


        private void AddStudent_Click(object sender, EventArgs e)
        {
            UnosNovogStudenta inputForm = new UnosNovogStudenta(noviStudent);
            inputForm.Show();
        }

        private void RemoveAllStudents_Click(object sender, EventArgs e)
        {
            RefreshStudents();
            studenti = new List<Student>();
        }

        private void RefreshStudents()
        {
            listaStudenata.Text = string.Empty;
            foreach (var student in studenti)
            {
                listaStudenata.Text += student.ShowData() + "\r\n";
            }
        }

        private void RemoveStudent_Click(object sender, EventArgs e)
        {
            if (studenti.Count > 0)
            {
                studenti.Remove(studenti.Last());
            }
            RefreshStudents();
        }
        
    }
}
