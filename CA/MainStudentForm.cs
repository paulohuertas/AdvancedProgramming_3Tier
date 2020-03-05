using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BEL;
using BAL;

namespace CA
{
    public partial class MainStudentForm : Form
    {
        public Operations operations = new Operations();
        public Informations info = new Informations();
        public MainStudentForm()
        {
            InitializeComponent();
            operations.FetchStudentRecords(info);
        }

        private void MainStudentForm_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = operations.FetchStudentRecords(info);
            dg_Students.DataSource = dt;

            int i = 0;
            foreach (DataGridViewColumn dgvc in dg_Students.Columns)
            {
                i = i + dgvc.Width;
            }
            dg_Students.Width = i + dg_Students.RowHeadersWidth + 2;
            dg_Students.Height = dg_Students.GetRowDisplayRectangle(dg_Students.NewRowIndex, true).Bottom + dg_Students.GetRowDisplayRectangle(dg_Students.NewRowIndex, false).Height;
            
        }

        private void editStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditStudentForm edit = new EditStudentForm();
            edit.Show();
        }

        private void deleteStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            DeleteStudentForm delete = new DeleteStudentForm();
            delete.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Login login = new Login();
            login.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void newStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddStudentForm studentForm = new AddStudentForm();
            studentForm.Show();
        }
    }
}
