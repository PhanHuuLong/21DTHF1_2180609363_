
namespace Lab4_01
{
    partial class FrmManagerFaculty
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
            this.groupBox_InformationFaculty = new System.Windows.Forms.GroupBox();
            this.comboBoxFaculty = new System.Windows.Forms.ComboBox();
            this.txtTotalFalcultyOfProfessor = new System.Windows.Forms.TextBox();
            this.labTotalProfessor = new System.Windows.Forms.Label();
            this.labNameFaculty = new System.Windows.Forms.Label();
            this.txtCodeFalculty = new System.Windows.Forms.TextBox();
            this.labCodeFaculty = new System.Windows.Forms.Label();
            this.butUpdate = new System.Windows.Forms.Button();
            this.butAdd = new System.Windows.Forms.Button();
            this.dgvFalculty = new System.Windows.Forms.DataGridView();
            this.facultyID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameFaculty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalProfessor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.butDelete = new System.Windows.Forms.Button();
            this.butExit = new System.Windows.Forms.Button();
            this.groupBox_InformationFaculty.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFalculty)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_InformationFaculty
            // 
            this.groupBox_InformationFaculty.Controls.Add(this.comboBoxFaculty);
            this.groupBox_InformationFaculty.Controls.Add(this.txtTotalFalcultyOfProfessor);
            this.groupBox_InformationFaculty.Controls.Add(this.labTotalProfessor);
            this.groupBox_InformationFaculty.Controls.Add(this.labNameFaculty);
            this.groupBox_InformationFaculty.Controls.Add(this.txtCodeFalculty);
            this.groupBox_InformationFaculty.Controls.Add(this.labCodeFaculty);
            this.groupBox_InformationFaculty.Location = new System.Drawing.Point(17, 79);
            this.groupBox_InformationFaculty.Name = "groupBox_InformationFaculty";
            this.groupBox_InformationFaculty.Size = new System.Drawing.Size(272, 211);
            this.groupBox_InformationFaculty.TabIndex = 20;
            this.groupBox_InformationFaculty.TabStop = false;
            this.groupBox_InformationFaculty.Text = "Information Faculty";
            // 
            // comboBoxFaculty
            // 
            this.comboBoxFaculty.FormattingEnabled = true;
            this.comboBoxFaculty.Location = new System.Drawing.Point(105, 62);
            this.comboBoxFaculty.Name = "comboBoxFaculty";
            this.comboBoxFaculty.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFaculty.TabIndex = 7;
            // 
            // txtTotalFalcultyOfProfessor
            // 
            this.txtTotalFalcultyOfProfessor.Location = new System.Drawing.Point(105, 143);
            this.txtTotalFalcultyOfProfessor.Name = "txtTotalFalcultyOfProfessor";
            this.txtTotalFalcultyOfProfessor.Size = new System.Drawing.Size(121, 20);
            this.txtTotalFalcultyOfProfessor.TabIndex = 6;
            this.txtTotalFalcultyOfProfessor.TextChanged += new System.EventHandler(this.txtTotalFalculty_TextChanged);
            // 
            // labTotalProfessor
            // 
            this.labTotalProfessor.AutoSize = true;
            this.labTotalProfessor.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTotalProfessor.Location = new System.Drawing.Point(19, 147);
            this.labTotalProfessor.Name = "labTotalProfessor";
            this.labTotalProfessor.Size = new System.Drawing.Size(78, 16);
            this.labTotalProfessor.TabIndex = 4;
            this.labTotalProfessor.Text = "Total Professor";
            // 
            // labNameFaculty
            // 
            this.labNameFaculty.AutoSize = true;
            this.labNameFaculty.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labNameFaculty.Location = new System.Drawing.Point(19, 67);
            this.labNameFaculty.Name = "labNameFaculty";
            this.labNameFaculty.Size = new System.Drawing.Size(69, 16);
            this.labNameFaculty.TabIndex = 2;
            this.labNameFaculty.Text = "NameFaculty";
            // 
            // txtCodeFalculty
            // 
            this.txtCodeFalculty.Enabled = false;
            this.txtCodeFalculty.Location = new System.Drawing.Point(105, 30);
            this.txtCodeFalculty.Name = "txtCodeFalculty";
            this.txtCodeFalculty.Size = new System.Drawing.Size(121, 20);
            this.txtCodeFalculty.TabIndex = 1;
            this.txtCodeFalculty.Text = "Value auto + 1. Also enter when find";
            this.txtCodeFalculty.TextChanged += new System.EventHandler(this.txtCodeFalculty_TextChanged);
            // 
            // labCodeFaculty
            // 
            this.labCodeFaculty.AutoSize = true;
            this.labCodeFaculty.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCodeFaculty.Location = new System.Drawing.Point(19, 31);
            this.labCodeFaculty.Name = "labCodeFaculty";
            this.labCodeFaculty.Size = new System.Drawing.Size(70, 16);
            this.labCodeFaculty.TabIndex = 1;
            this.labCodeFaculty.Text = "Code Faculty";
            this.labCodeFaculty.Click += new System.EventHandler(this.labCodeFaculty_Click);
            // 
            // butUpdate
            // 
            this.butUpdate.Location = new System.Drawing.Point(119, 320);
            this.butUpdate.Name = "butUpdate";
            this.butUpdate.Size = new System.Drawing.Size(73, 51);
            this.butUpdate.TabIndex = 22;
            this.butUpdate.Text = "Update";
            this.butUpdate.UseVisualStyleBackColor = true;
            this.butUpdate.Click += new System.EventHandler(this.butUpdate_Click);
            // 
            // butAdd
            // 
            this.butAdd.Location = new System.Drawing.Point(17, 320);
            this.butAdd.Name = "butAdd";
            this.butAdd.Size = new System.Drawing.Size(75, 51);
            this.butAdd.TabIndex = 21;
            this.butAdd.Text = "Add";
            this.butAdd.UseVisualStyleBackColor = true;
            this.butAdd.Click += new System.EventHandler(this.butAdd_Click);
            // 
            // dgvFalculty
            // 
            this.dgvFalculty.AllowUserToAddRows = false;
            this.dgvFalculty.AllowUserToDeleteRows = false;
            this.dgvFalculty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFalculty.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.facultyID,
            this.nameFaculty,
            this.totalProfessor});
            this.dgvFalculty.Location = new System.Drawing.Point(316, 85);
            this.dgvFalculty.Name = "dgvFalculty";
            this.dgvFalculty.ReadOnly = true;
            this.dgvFalculty.Size = new System.Drawing.Size(468, 204);
            this.dgvFalculty.TabIndex = 24;
            this.dgvFalculty.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFalculty_CellContentClick);
            // 
            // facultyID
            // 
            this.facultyID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.facultyID.HeaderText = "Code Falculty";
            this.facultyID.Name = "facultyID";
            this.facultyID.ReadOnly = true;
            // 
            // nameFaculty
            // 
            this.nameFaculty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameFaculty.HeaderText = "Name Falculty";
            this.nameFaculty.Name = "nameFaculty";
            this.nameFaculty.ReadOnly = true;
            // 
            // totalProfessor
            // 
            this.totalProfessor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.totalProfessor.HeaderText = "Total Professor";
            this.totalProfessor.Name = "totalProfessor";
            this.totalProfessor.ReadOnly = true;
            // 
            // butDelete
            // 
            this.butDelete.Location = new System.Drawing.Point(208, 320);
            this.butDelete.Name = "butDelete";
            this.butDelete.Size = new System.Drawing.Size(81, 51);
            this.butDelete.TabIndex = 23;
            this.butDelete.Text = "Delete";
            this.butDelete.UseVisualStyleBackColor = true;
            this.butDelete.Click += new System.EventHandler(this.butDelete_Click);
            // 
            // butExit
            // 
            this.butExit.Location = new System.Drawing.Point(702, 320);
            this.butExit.Name = "butExit";
            this.butExit.Size = new System.Drawing.Size(82, 49);
            this.butExit.TabIndex = 25;
            this.butExit.Text = "Exit";
            this.butExit.UseVisualStyleBackColor = true;
            this.butExit.Click += new System.EventHandler(this.butExit_Click_1);
            // 
            // FrmManagerFaculty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.butExit);
            this.Controls.Add(this.groupBox_InformationFaculty);
            this.Controls.Add(this.butUpdate);
            this.Controls.Add(this.butAdd);
            this.Controls.Add(this.dgvFalculty);
            this.Controls.Add(this.butDelete);
            this.Name = "FrmManagerFaculty";
            this.Text = "ManagerFaculty";
            this.Load += new System.EventHandler(this.FrmManagerFaculty_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmManagerFaculty_KeyDown);
            this.groupBox_InformationFaculty.ResumeLayout(false);
            this.groupBox_InformationFaculty.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFalculty)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_InformationFaculty;
        private System.Windows.Forms.TextBox txtTotalFalcultyOfProfessor;
        private System.Windows.Forms.Label labTotalProfessor;
        private System.Windows.Forms.Label labNameFaculty;
        private System.Windows.Forms.TextBox txtCodeFalculty;
        private System.Windows.Forms.Label labCodeFaculty;
        private System.Windows.Forms.Button butUpdate;
        private System.Windows.Forms.Button butAdd;
        private System.Windows.Forms.DataGridView dgvFalculty;
        private System.Windows.Forms.Button butDelete;
        private System.Windows.Forms.ComboBox comboBoxFaculty;
        private System.Windows.Forms.DataGridViewTextBoxColumn facultyID;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameFaculty;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalProfessor;
        private System.Windows.Forms.Button butExit;
    }
}