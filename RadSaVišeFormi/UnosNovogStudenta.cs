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
    public partial class UnosNovogStudenta : Form
    {
        AddStudentEvent noviStudent;

        public UnosNovogStudenta(AddStudentEvent studentData)
        {
            InitializeComponent();
            noviStudent = studentData;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                Student student = new Student(nameTxtBox.Text, secondNameTxtBox.Text, typeTxtBox.Text, int.Parse(indexNumTxtBox.Text), dayOfBirthDateTime.Value);
                noviStudent.Invoke(student);
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void abortButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
