namespace Lab4_01
{
    partial class FindStudent
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
            this.groupBoxInformationStudent = new System.Windows.Forms.GroupBox();
            this.cmbFaculty = new System.Windows.Forms.ComboBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtCodeStudent = new System.Windows.Forms.TextBox();
            this.labFaculty = new System.Windows.Forms.Label();
            this.labName = new System.Windows.Forms.Label();
            this.labCodeStudent = new System.Windows.Forms.Label();
            this.butFind = new System.Windows.Forms.Button();
            this.butDelete = new System.Windows.Forms.Button();
            this.butExit = new System.Windows.Forms.Button();
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.codeStudent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.averageScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.faculty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.groupBoxInformationStudent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxInformationStudent
            // 
            this.groupBoxInformationStudent.Controls.Add(this.cmbFaculty);
            this.groupBoxInformationStudent.Controls.Add(this.txtName);
            this.groupBoxInformationStudent.Controls.Add(this.txtCodeStudent);
            this.groupBoxInformationStudent.Controls.Add(this.labFaculty);
            this.groupBoxInformationStudent.Controls.Add(this.labName);
            this.groupBoxInformationStudent.Controls.Add(this.labCodeStudent);
            this.groupBoxInformationStudent.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxInformationStudent.ForeColor = System.Drawing.Color.Blue;
            this.groupBoxInformationStudent.Location = new System.Drawing.Point(204, 21);
            this.groupBoxInformationStudent.Name = "groupBoxInformationStudent";
            this.groupBoxInformationStudent.Size = new System.Drawing.Size(382, 137);
            this.groupBoxInformationStudent.TabIndex = 0;
            this.groupBoxInformationStudent.TabStop = false;
            this.groupBoxInformationStudent.Text = "Information Student";
            // 
            // cmbFaculty
            // 
            this.cmbFaculty.FormattingEnabled = true;
            this.cmbFaculty.Location = new System.Drawing.Point(114, 105);
            this.cmbFaculty.Name = "cmbFaculty";
            this.cmbFaculty.Size = new System.Drawing.Size(192, 23);
            this.cmbFaculty.TabIndex = 5;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(114, 65);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(238, 22);
            this.txtName.TabIndex = 4;
            // 
            // txtCodeStudent
            // 
            this.txtCodeStudent.Location = new System.Drawing.Point(114, 28);
            this.txtCodeStudent.Name = "txtCodeStudent";
            this.txtCodeStudent.Size = new System.Drawing.Size(238, 22);
            this.txtCodeStudent.TabIndex = 3;
            // 
            // labFaculty
            // 
            this.labFaculty.AutoSize = true;
            this.labFaculty.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labFaculty.Location = new System.Drawing.Point(28, 108);
            this.labFaculty.Name = "labFaculty";
            this.labFaculty.Size = new System.Drawing.Size(47, 15);
            this.labFaculty.TabIndex = 2;
            this.labFaculty.Text = "Faculty";
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labName.Location = new System.Drawing.Point(28, 68);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(37, 15);
            this.labName.TabIndex = 1;
            this.labName.Text = "Name";
            // 
            // labCodeStudent
            // 
            this.labCodeStudent.AutoSize = true;
            this.labCodeStudent.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labCodeStudent.Location = new System.Drawing.Point(28, 31);
            this.labCodeStudent.Name = "labCodeStudent";
            this.labCodeStudent.Size = new System.Drawing.Size(80, 15);
            this.labCodeStudent.TabIndex = 0;
            this.labCodeStudent.Text = "Code Student";
            // 
            // butFind
            // 
            this.butFind.Location = new System.Drawing.Point(405, 164);
            this.butFind.Name = "butFind";
            this.butFind.Size = new System.Drawing.Size(75, 23);
            this.butFind.TabIndex = 1;
            this.butFind.Text = "Find";
            this.butFind.UseVisualStyleBackColor = true;
            this.butFind.Click += new System.EventHandler(this.butFind_Click);
            // 
            // butDelete
            // 
            this.butDelete.Location = new System.Drawing.Point(511, 164);
            this.butDelete.Name = "butDelete";
            this.butDelete.Size = new System.Drawing.Size(75, 23);
            this.butDelete.TabIndex = 2;
            this.butDelete.Text = "Delete";
            this.butDelete.UseVisualStyleBackColor = true;
            this.butDelete.Click += new System.EventHandler(this.butDelete_Click);
            // 
            // butExit
            // 
            this.butExit.Location = new System.Drawing.Point(702, 164);
            this.butExit.Name = "butExit";
            this.butExit.Size = new System.Drawing.Size(75, 23);
            this.butExit.TabIndex = 3;
            this.butExit.Text = "Exit";
            this.butExit.UseVisualStyleBackColor = true;
            this.butExit.Click += new System.EventHandler(this.butExit_Click);
            // 
            // dgvStudents
            // 
            this.dgvStudents.AllowUserToAddRows = false;
            this.dgvStudents.AllowUserToDeleteRows = false;
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codeStudent,
            this.name,
            this.averageScore,
            this.faculty});
            this.dgvStudents.Location = new System.Drawing.Point(12, 207);
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.ReadOnly = true;
            this.dgvStudents.Size = new System.Drawing.Size(776, 159);
            this.dgvStudents.TabIndex = 19;
            // 
            // codeStudent
            // 
            this.codeStudent.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.codeStudent.HeaderText = "Code Student";
            this.codeStudent.Name = "codeStudent";
            this.codeStudent.ReadOnly = true;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // averageScore
            // 
            this.averageScore.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.averageScore.HeaderText = "Average Score";
            this.averageScore.Name = "averageScore";
            this.averageScore.ReadOnly = true;
            // 
            // faculty
            // 
            this.faculty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.faculty.HeaderText = "Faculty";
            this.faculty.Name = "faculty";
            this.faculty.ReadOnly = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(604, 377);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Total Find See";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(685, 374);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(103, 20);
            this.txtTotal.TabIndex = 6;
            // 
            // FindStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvStudents);
            this.Controls.Add(this.butExit);
            this.Controls.Add(this.butDelete);
            this.Controls.Add(this.butFind);
            this.Controls.Add(this.groupBoxInformationStudent);
            this.Name = "FindStudent";
            this.Text = "Find Student";
            this.Load += new System.EventHandler(this.FindStudent_Load);
            this.groupBoxInformationStudent.ResumeLayout(false);
            this.groupBoxInformationStudent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxInformationStudent;
        private System.Windows.Forms.Button butFind;
        private System.Windows.Forms.Button butDelete;
        private System.Windows.Forms.Button butExit;
        private System.Windows.Forms.ComboBox cmbFaculty;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtCodeStudent;
        private System.Windows.Forms.Label labFaculty;
        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.Label labCodeStudent;
        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn averageScore;
        private System.Windows.Forms.DataGridViewTextBoxColumn faculty;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTotal;
    }
}