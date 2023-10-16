
namespace Lab4_01
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.findToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBoxFaculty = new System.Windows.Forms.ComboBox();
            this.txtAverageScore = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.labAverageScore = new System.Windows.Forms.Label();
            this.labFaculty = new System.Windows.Forms.Label();
            this.labName = new System.Windows.Forms.Label();
            this.txtCodeStudent = new System.Windows.Forms.TextBox();
            this.toolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manegerFacultyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findCtrlFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.groupBox_InformationStudent = new System.Windows.Forms.GroupBox();
            this.labCodeStudent = new System.Windows.Forms.Label();
            this.butUpdate = new System.Windows.Forms.Button();
            this.butAdd = new System.Windows.Forms.Button();
            this.faculty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.codeStudent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.averageScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.butExit = new System.Windows.Forms.Button();
            this.butDelete = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1_ManegerFaculty = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel2_ManagerFaculty = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel_FindByName = new System.Windows.Forms.ToolStripLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.FrmFalculty = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBox_InformationStudent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // findToolStripMenuItem
            // 
            this.findToolStripMenuItem.Name = "findToolStripMenuItem";
            this.findToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.findToolStripMenuItem.Text = "Exit";
            this.findToolStripMenuItem.Click += new System.EventHandler(this.findToolStripMenuItem_Click);
            // 
            // comboBoxFaculty
            // 
            this.comboBoxFaculty.FormattingEnabled = true;
            this.comboBoxFaculty.Location = new System.Drawing.Point(105, 103);
            this.comboBoxFaculty.Name = "comboBoxFaculty";
            this.comboBoxFaculty.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFaculty.TabIndex = 1;
            // 
            // txtAverageScore
            // 
            this.txtAverageScore.Location = new System.Drawing.Point(105, 143);
            this.txtAverageScore.Name = "txtAverageScore";
            this.txtAverageScore.Size = new System.Drawing.Size(121, 20);
            this.txtAverageScore.TabIndex = 6;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(105, 63);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(121, 20);
            this.txtName.TabIndex = 5;
            // 
            // labAverageScore
            // 
            this.labAverageScore.AutoSize = true;
            this.labAverageScore.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labAverageScore.Location = new System.Drawing.Point(19, 147);
            this.labAverageScore.Name = "labAverageScore";
            this.labAverageScore.Size = new System.Drawing.Size(79, 16);
            this.labAverageScore.TabIndex = 4;
            this.labAverageScore.Text = "Average Score";
            // 
            // labFaculty
            // 
            this.labFaculty.AutoSize = true;
            this.labFaculty.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labFaculty.Location = new System.Drawing.Point(19, 108);
            this.labFaculty.Name = "labFaculty";
            this.labFaculty.Size = new System.Drawing.Size(41, 16);
            this.labFaculty.TabIndex = 3;
            this.labFaculty.Text = "Faculty";
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labName.Location = new System.Drawing.Point(19, 67);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(35, 16);
            this.labName.TabIndex = 2;
            this.labName.Text = "Name";
            // 
            // txtCodeStudent
            // 
            this.txtCodeStudent.Location = new System.Drawing.Point(105, 30);
            this.txtCodeStudent.Name = "txtCodeStudent";
            this.txtCodeStudent.Size = new System.Drawing.Size(121, 20);
            this.txtCodeStudent.TabIndex = 1;
            // 
            // toolToolStripMenuItem
            // 
            this.toolToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manegerFacultyToolStripMenuItem,
            this.findCtrlFToolStripMenuItem,
            this.findToolStripMenuItem});
            this.toolToolStripMenuItem.Name = "toolToolStripMenuItem";
            this.toolToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.toolToolStripMenuItem.Text = "Tool";
            // 
            // manegerFacultyToolStripMenuItem
            // 
            this.manegerFacultyToolStripMenuItem.Name = "manegerFacultyToolStripMenuItem";
            this.manegerFacultyToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.manegerFacultyToolStripMenuItem.Text = "Maneger Faculty        F2";
            this.manegerFacultyToolStripMenuItem.Click += new System.EventHandler(this.manegerFacultyToolStripMenuItem_Click);
            // 
            // findCtrlFToolStripMenuItem
            // 
            this.findCtrlFToolStripMenuItem.Name = "findCtrlFToolStripMenuItem";
            this.findCtrlFToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.findCtrlFToolStripMenuItem.Text = "Find    Ctrl + F";
            this.findCtrlFToolStripMenuItem.Click += new System.EventHandler(this.findCtrlFToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // groupBox_InformationStudent
            // 
            this.groupBox_InformationStudent.Controls.Add(this.comboBoxFaculty);
            this.groupBox_InformationStudent.Controls.Add(this.txtAverageScore);
            this.groupBox_InformationStudent.Controls.Add(this.txtName);
            this.groupBox_InformationStudent.Controls.Add(this.labAverageScore);
            this.groupBox_InformationStudent.Controls.Add(this.labFaculty);
            this.groupBox_InformationStudent.Controls.Add(this.labName);
            this.groupBox_InformationStudent.Controls.Add(this.txtCodeStudent);
            this.groupBox_InformationStudent.Controls.Add(this.labCodeStudent);
            this.groupBox_InformationStudent.Location = new System.Drawing.Point(17, 59);
            this.groupBox_InformationStudent.Name = "groupBox_InformationStudent";
            this.groupBox_InformationStudent.Size = new System.Drawing.Size(272, 211);
            this.groupBox_InformationStudent.TabIndex = 14;
            this.groupBox_InformationStudent.TabStop = false;
            this.groupBox_InformationStudent.Text = "Information Students";
            // 
            // labCodeStudent
            // 
            this.labCodeStudent.AutoSize = true;
            this.labCodeStudent.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCodeStudent.Location = new System.Drawing.Point(19, 31);
            this.labCodeStudent.Name = "labCodeStudent";
            this.labCodeStudent.Size = new System.Drawing.Size(71, 16);
            this.labCodeStudent.TabIndex = 1;
            this.labCodeStudent.Text = "Code Student";
            // 
            // butUpdate
            // 
            this.butUpdate.Location = new System.Drawing.Point(119, 300);
            this.butUpdate.Name = "butUpdate";
            this.butUpdate.Size = new System.Drawing.Size(73, 51);
            this.butUpdate.TabIndex = 16;
            this.butUpdate.Text = "Update";
            this.butUpdate.UseVisualStyleBackColor = true;
            this.butUpdate.Click += new System.EventHandler(this.butUpdate_Click);
            // 
            // butAdd
            // 
            this.butAdd.Location = new System.Drawing.Point(17, 300);
            this.butAdd.Name = "butAdd";
            this.butAdd.Size = new System.Drawing.Size(75, 51);
            this.butAdd.TabIndex = 15;
            this.butAdd.Text = "Add";
            this.butAdd.UseVisualStyleBackColor = true;
            this.butAdd.Click += new System.EventHandler(this.butAdd_Click);
            // 
            // faculty
            // 
            this.faculty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.faculty.HeaderText = "Faculty";
            this.faculty.Name = "faculty";
            this.faculty.ReadOnly = true;
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
            this.dgvStudents.Location = new System.Drawing.Point(316, 65);
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.ReadOnly = true;
            this.dgvStudents.Size = new System.Drawing.Size(468, 204);
            this.dgvStudents.TabIndex = 18;
            this.dgvStudents.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudents_CellClick);
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
            // butExit
            // 
            this.butExit.Location = new System.Drawing.Point(703, 300);
            this.butExit.Name = "butExit";
            this.butExit.Size = new System.Drawing.Size(81, 51);
            this.butExit.TabIndex = 19;
            this.butExit.Text = "Exit";
            this.butExit.UseVisualStyleBackColor = true;
            this.butExit.Click += new System.EventHandler(this.butExit_Click);
            // 
            // butDelete
            // 
            this.butDelete.Location = new System.Drawing.Point(208, 300);
            this.butDelete.Name = "butDelete";
            this.butDelete.Size = new System.Drawing.Size(81, 51);
            this.butDelete.TabIndex = 17;
            this.butDelete.Text = "Delete";
            this.butDelete.UseVisualStyleBackColor = true;
            this.butDelete.Click += new System.EventHandler(this.butDelete_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1_ManegerFaculty,
            this.toolStripLabel2_ManagerFaculty,
            this.toolStripLabel_FindByName,
            this.toolStripProgressBar1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 22;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1_ManegerFaculty
            // 
            this.toolStripButton1_ManegerFaculty.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1_ManegerFaculty.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1_ManegerFaculty.Image")));
            this.toolStripButton1_ManegerFaculty.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1_ManegerFaculty.Name = "toolStripButton1_ManegerFaculty";
            this.toolStripButton1_ManegerFaculty.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1_ManegerFaculty.Text = "toolStripButtonManegerFaculty";
            this.toolStripButton1_ManegerFaculty.Click += new System.EventHandler(this.toolStripButton1_ManegerFaculty_Click);
            // 
            // toolStripLabel2_ManagerFaculty
            // 
            this.toolStripLabel2_ManagerFaculty.AutoSize = false;
            this.toolStripLabel2_ManagerFaculty.Name = "toolStripLabel2_ManagerFaculty";
            this.toolStripLabel2_ManagerFaculty.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStripLabel2_ManagerFaculty.Size = new System.Drawing.Size(86, 22);
            this.toolStripLabel2_ManagerFaculty.Text = "Manager Faculty";
            this.toolStripLabel2_ManagerFaculty.Click += new System.EventHandler(this.toolStripLabel2_ManagerFaculty_Click);
            // 
            // toolStripLabel_FindByName
            // 
            this.toolStripLabel_FindByName.Name = "toolStripLabel_FindByName";
            this.toolStripLabel_FindByName.Size = new System.Drawing.Size(81, 22);
            this.toolStripLabel_FindByName.Text = "Find By Name";
            this.toolStripLabel_FindByName.Click += new System.EventHandler(this.toolStripLabel_FindByName_Click);
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 22);
            this.toolStripProgressBar1.Click += new System.EventHandler(this.toolStripProgressBar1_Click);
            // 
            // FrmFalculty
            // 
            this.FrmFalculty.Location = new System.Drawing.Point(327, 299);
            this.FrmFalculty.Name = "FrmFalculty";
            this.FrmFalculty.Size = new System.Drawing.Size(78, 52);
            this.FrmFalculty.TabIndex = 23;
            this.FrmFalculty.Text = "Form Falculty";
            this.FrmFalculty.UseVisualStyleBackColor = true;
            this.FrmFalculty.Click += new System.EventHandler(this.FrmFalculty_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 361);
            this.Controls.Add(this.FrmFalculty);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox_InformationStudent);
            this.Controls.Add(this.butUpdate);
            this.Controls.Add(this.butAdd);
            this.Controls.Add(this.dgvStudents);
            this.Controls.Add(this.butExit);
            this.Controls.Add(this.butDelete);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox_InformationStudent.ResumeLayout(false);
            this.groupBox_InformationStudent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem findToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboBoxFaculty;
        private System.Windows.Forms.TextBox txtAverageScore;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label labAverageScore;
        private System.Windows.Forms.Label labFaculty;
        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.TextBox txtCodeStudent;
        private System.Windows.Forms.ToolStripMenuItem toolToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.GroupBox groupBox_InformationStudent;
        private System.Windows.Forms.Label labCodeStudent;
        private System.Windows.Forms.Button butUpdate;
        private System.Windows.Forms.Button butAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn faculty;
        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn averageScore;
        private System.Windows.Forms.Button butExit;
        private System.Windows.Forms.Button butDelete;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1_ManegerFaculty;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2_ManagerFaculty;
        private System.Windows.Forms.Button FrmFalculty;
        private System.Windows.Forms.ToolStripMenuItem manegerFacultyToolStripMenuItem;
        private System.Windows.Forms.ToolStripLabel toolStripLabel_FindByName;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripMenuItem findCtrlFToolStripMenuItem;
    }
}

