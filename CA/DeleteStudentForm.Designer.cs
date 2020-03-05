namespace CA
{
    partial class DeleteStudentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewDatabaseHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txt_DeleteStudent = new System.Windows.Forms.TextBox();
            this.lbl_StudentNo = new System.Windows.Forms.Label();
            this.dg_Delete = new System.Windows.Forms.DataGridView();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Delete)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.studentToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 41;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // studentToolStripMenuItem
            // 
            this.studentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addStudentToolStripMenuItem,
            this.deleteStudentToolStripMenuItem,
            this.modifyToolStripMenuItem,
            this.viewDatabaseHistoryToolStripMenuItem});
            this.studentToolStripMenuItem.Name = "studentToolStripMenuItem";
            this.studentToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.studentToolStripMenuItem.Text = "Student";
            // 
            // addStudentToolStripMenuItem
            // 
            this.addStudentToolStripMenuItem.Name = "addStudentToolStripMenuItem";
            this.addStudentToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.addStudentToolStripMenuItem.Text = "New Student";
            this.addStudentToolStripMenuItem.Click += new System.EventHandler(this.addStudentToolStripMenuItem_Click);
            // 
            // deleteStudentToolStripMenuItem
            // 
            this.deleteStudentToolStripMenuItem.Name = "deleteStudentToolStripMenuItem";
            this.deleteStudentToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.deleteStudentToolStripMenuItem.Text = "Edit Student";
            this.deleteStudentToolStripMenuItem.Click += new System.EventHandler(this.deleteStudentToolStripMenuItem_Click);
            // 
            // modifyToolStripMenuItem
            // 
            this.modifyToolStripMenuItem.Name = "modifyToolStripMenuItem";
            this.modifyToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.modifyToolStripMenuItem.Text = "Delete Student";
            // 
            // viewDatabaseHistoryToolStripMenuItem
            // 
            this.viewDatabaseHistoryToolStripMenuItem.Name = "viewDatabaseHistoryToolStripMenuItem";
            this.viewDatabaseHistoryToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.viewDatabaseHistoryToolStripMenuItem.Text = "View Database History";
            this.viewDatabaseHistoryToolStripMenuItem.Click += new System.EventHandler(this.viewDatabaseHistoryToolStripMenuItem_Click);
            // 
            // txt_DeleteStudent
            // 
            this.txt_DeleteStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DeleteStudent.HideSelection = false;
            this.txt_DeleteStudent.Location = new System.Drawing.Point(261, 35);
            this.txt_DeleteStudent.Name = "txt_DeleteStudent";
            this.txt_DeleteStudent.Size = new System.Drawing.Size(420, 26);
            this.txt_DeleteStudent.TabIndex = 45;
            this.txt_DeleteStudent.TextChanged += new System.EventHandler(this.txt_DeleteStudent_TextChanged);
            // 
            // lbl_StudentNo
            // 
            this.lbl_StudentNo.AutoSize = true;
            this.lbl_StudentNo.Font = new System.Drawing.Font("Arial Nova Cond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_StudentNo.Location = new System.Drawing.Point(79, 35);
            this.lbl_StudentNo.Name = "lbl_StudentNo";
            this.lbl_StudentNo.Size = new System.Drawing.Size(176, 20);
            this.lbl_StudentNo.TabIndex = 44;
            this.lbl_StudentNo.Text = "SEARCH STUDENT BY ID:";
            // 
            // dg_Delete
            // 
            this.dg_Delete.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dg_Delete.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.dg_Delete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_Delete.Location = new System.Drawing.Point(83, 88);
            this.dg_Delete.Name = "dg_Delete";
            this.dg_Delete.ReadOnly = true;
            this.dg_Delete.Size = new System.Drawing.Size(598, 192);
            this.dg_Delete.TabIndex = 46;
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackColor = System.Drawing.Color.CadetBlue;
            this.btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btn_Delete.Location = new System.Drawing.Point(543, 314);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(138, 40);
            this.btn_Delete.TabIndex = 47;
            this.btn_Delete.Text = "DELETE";
            this.btn_Delete.UseVisualStyleBackColor = false;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // DeleteStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 369);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.dg_Delete);
            this.Controls.Add(this.txt_DeleteStudent);
            this.Controls.Add(this.lbl_StudentNo);
            this.Controls.Add(this.menuStrip1);
            this.Name = "DeleteStudentForm";
            this.ShowIcon = false;
            this.Text = "DeleteStudentForm";
            this.Load += new System.EventHandler(this.DeleteStudentForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Delete)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewDatabaseHistoryToolStripMenuItem;
        private System.Windows.Forms.TextBox txt_DeleteStudent;
        private System.Windows.Forms.Label lbl_StudentNo;
        private System.Windows.Forms.DataGridView dg_Delete;
        private System.Windows.Forms.Button btn_Delete;
    }
}