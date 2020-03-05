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
    public partial class EditStudentForm : Form
    {
        public Operations operations = new Operations();
        public Informations info = new Informations();
        DataTable dt;

        string gradLevel;

        public EditStudentForm()
        {
            InitializeComponent();
            operations.FetchAllStudentAttribute(info);
            dg_SearchEdit.Refresh();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void lbl_Search_Click(object sender, EventArgs e)
        {

        }

        private void lbl_EditStudent_Click(object sender, EventArgs e)
        {

        }

        private void txt_Search_TextChanged(object sender, EventArgs e)
        {
        }

        private void EditStudentForm_Load(object sender, EventArgs e)
        {
            dt = operations.FetchAllStudentAttribute(info);
            dg_SearchEdit.DataSource = dt;

        }

        private void dg_SearchEdit_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dg_SearchEdit_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    int index = e.RowIndex;
                    DataGridViewRow selectedRow = dg_SearchEdit.Rows[index];
                    txt_StudentId.Text = selectedRow.Cells[0].Value.ToString();
                    txt_FirstName.Text = selectedRow.Cells[1].Value.ToString();
                    txt_Surname.Text = selectedRow.Cells[2].Value.ToString();
                    txt_Email.Text = selectedRow.Cells[3].Value.ToString();
                    txt_Phone.Text = selectedRow.Cells[4].Value.ToString();
                    txt_AddressL1.Text = selectedRow.Cells[5].Value.ToString();
                    txt_AddressL2.Text = selectedRow.Cells[6].Value.ToString();
                    txt_City.Text = selectedRow.Cells[7].Value.ToString();
                    cbo_County.Text = selectedRow.Cells[8].Value.ToString();
                    if (selectedRow.Cells[9].Value.Equals("Postgrad"))
                    {
                        rb_Postgrad.Checked = true;
                    }
                    else
                    {
                        rb_Undergrad.Checked = true;
                    }
                    cb_Course.Text = selectedRow.Cells[10].Value.ToString();

                }
                catch (Exception ex)
                {

                    MessageBox.Show("Something went wrong", ex.Message);
                }
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Email.Text))
            {
                MessageBox.Show("Enter student email");
                txt_Email.Select();
            }
            else if (string.IsNullOrEmpty(txt_Phone.Text))
            {
                MessageBox.Show("Enter student telephone number");
                txt_Phone.Select();
            }
            else if (string.IsNullOrEmpty(txt_AddressL1.Text))
            {
                MessageBox.Show("Enter student address");
                txt_AddressL1.Select();
            }
            else if (string.IsNullOrEmpty(txt_City.Text))
            {
                MessageBox.Show("Enter student city");
                txt_City.Select();
            }
            else if (cbo_County.SelectedIndex <= -1)
            {
                MessageBox.Show("Enter student county");
                cbo_County.Select();
            }
            else if (txt_StudentId.TextLength > 9)
            {
                MessageBox.Show("Student number must be up to 9 characters length");
                txt_StudentId.Select();
            }
            else
            {
                if (rb_Postgrad.Checked)
                {
                    gradLevel = rb_Postgrad.Text;
                }
                else
                {
                    gradLevel = rb_Undergrad.Text;
                }

                info.Email = txt_Email.Text;
                info.Phone = txt_Phone.Text;
                info.AddressLine1 = txt_AddressL1.Text;
                info.AddressLine2 = txt_AddressL2.Text;
                info.City = txt_City.Text;
                info.County = cbo_County.Text;
                info.Level = gradLevel;
                info.StudentNumber = Convert.ToInt32(txt_StudentId.Text);
                int numRes = operations.UpdateStudent(info);
                if (numRes > 0)
                {
                    MessageBox.Show("Student Saved Successfully");
                    this.Controls.Clear();
                    this.InitializeComponent();
                    operations.FetchAllStudentAttribute(info);
                }
                else
                {
                    MessageBox.Show("Something went wrong");

                }
            }
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Login login = new Login();
            login.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void addStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            AddStudentForm addStudent = new AddStudentForm();
            addStudent.Show();
        }

        private void deleteStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void viewDatabaseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            MainStudentForm mainStudentForm = new MainStudentForm();
            mainStudentForm.Show();
        }

        private void modifyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            DeleteStudentForm delete = new DeleteStudentForm();
            delete.Show();
        }
    }
}
