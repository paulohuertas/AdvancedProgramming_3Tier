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
    public partial class DeleteStudentForm : Form
    {
        public Operations operations = new Operations();
        public Informations info = new Informations();

        public DataTable dt;
        
        public DeleteStudentForm()
        {
            InitializeComponent();
            operations.FetchStudentRecords(info);
            dg_Delete.Refresh();
        }

        private void DeleteStudentForm_Load(object sender, EventArgs e)
        {
            dt = operations.FetchStudentRecords(info);
            dg_Delete.DataSource = dt;
            int i = 0;
            foreach (DataGridViewColumn dgvc in dg_Delete.Columns)
            {
                i = i + dgvc.Width;
            }
            dg_Delete.Width = i + dg_Delete.RowHeadersWidth + 2;
            dg_Delete.Height = dg_Delete.GetRowDisplayRectangle(dg_Delete.NewRowIndex, true).Bottom + dg_Delete.GetRowDisplayRectangle(dg_Delete.NewRowIndex, false).Height;
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            int studentNumber;
            if (int.TryParse(txt_DeleteStudent.Text, out studentNumber))
            {
                try
                {
                    int numRes = operations.DeleteStudent(studentNumber);
                    if (numRes > 0)
                    {
                        MessageBox.Show("Deleted successfully");
                        this.Refresh();
                        txt_DeleteStudent.Clear();
                        operations.FetchStudentRecords(info);
                    }
                    else
                    {
                        MessageBox.Show("Please, try again!");
                    }

                }
                catch (Exception ex)
                {

                    throw new Exception("Error..." + ex.Message);
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
            this.Close();
            EditStudentForm editStudentForm = new EditStudentForm();
            editStudentForm.Show();
        }

        private void viewDatabaseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            MainStudentForm mainStudentForm = new MainStudentForm();
            mainStudentForm.Show();
        }

        private void txt_DeleteStudent_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataView dv = new DataView(dt);
                dv.RowFilter = "Convert(StudentNumber, 'System.String') LIKE '" + txt_DeleteStudent.Text + "%'";
                dg_Delete.DataSource = dv;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error", ex.Message);
            }
        }
    }
}
