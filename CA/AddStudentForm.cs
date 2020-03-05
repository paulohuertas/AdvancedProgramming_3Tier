using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BAL;
using BEL;

namespace CA
{   
    public partial class AddStudentForm : Form
    {
        public Informations info = new Informations();
        public Operations operations = new Operations();

        string gradLevel;
        public AddStudentForm()
        {
            InitializeComponent();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (rb_Postgrad.Checked)
            {
                gradLevel = rb_Postgrad.Text;
            }
            else
            {
                gradLevel = rb_Undergrad.Text;
            }

            info.FirstName = txt_FirstName.Text;
            info.Surname = txt_Surname.Text;
            info.Email = txt_Email.Text;
            info.Phone = txt_Phone.Text;
            info.AddressLine1 = txt_AddressL1.Text;
            info.AddressLine2 = txt_AddressL2.Text;
            info.City = txt_City.Text;
            info.County = cbo_County.Text;
            info.Level = gradLevel;
            info.Course = cb_Course.Text;
            info.StudentNumber = Convert.ToInt32(txt_StudentId.Text);

            int numRes = operations.InsertStudent(info);
            if(numRes > 0)
            {
                MessageBox.Show("Student Saved Successfully");
                this.Controls.Clear();
                this.InitializeComponent();
            }
        }

        private void studentRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainStudentForm mainForm = new MainStudentForm();
            mainForm.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void editStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            EditStudentForm editStudentForm = new EditStudentForm();
            editStudentForm.Show();
        }

        private void deleteStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            DeleteStudentForm deleteStudent = new DeleteStudentForm();
            deleteStudent.Show();
        }
    }
}
