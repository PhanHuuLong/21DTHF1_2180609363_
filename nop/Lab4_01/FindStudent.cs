using Lab4_01.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab4_01
{
    public partial class FindStudent : Form
    {
        List<Faculty> listFaculty = new List<Faculty>();
        public FindStudent()
        {

            InitializeComponent();

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void FindStudent_Load(object sender, EventArgs e)
        {
            StudentContextDB db = new StudentContextDB();
            this.listFaculty = db.Faculties.ToList();
            FillFacultyCombobox(this.listFaculty);
        }
        void FillFacultyCombobox(List<Faculty> listFaculty)
        {

            this.cmbFaculty.DataSource = listFaculty;
            this.cmbFaculty.DisplayMember = "FacultyName";
            this.cmbFaculty.ValueMember = "FacultyID";
            cmbFaculty.SelectedIndex = -1;
        }

        void InitializeDataGridView()
        {
            dgvStudents.DataSource = null;
            dgvStudents.Rows.Clear();
            dgvStudents.Columns.Clear();
        }
        private void butDelete_Click(object sender, EventArgs e)
        {
            InitializeDataGridView();
        }

        private void butExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void butFind_Click(object sender, EventArgs e)
        {
            StudentContextDB db = new StudentContextDB();
            List<Student> listStudent = db.Students.ToList();

            dgvStudents.DataSource = null;
            dgvStudents.Rows.Clear();
            dgvStudents.Columns.Clear();

            if (txtCodeStudent != null)
            {
                var studentid = listStudent.FirstOrDefault(ls => ls.StudentID.Equals(txtCodeStudent.Text));
                if (studentid != null && string.Equals(studentid.FullName, txtName.Text, StringComparison.OrdinalIgnoreCase)
                    && studentid.Faculty.FacultyName == cmbFaculty.Text)
                {
                    dgvStudents.Columns.Add("codeStudent", "Student ID");
                    dgvStudents.Columns.Add("name", "Name");
                    dgvStudents.Columns.Add("averageScore", "Average Score");
                    dgvStudents.Columns.Add("faculty", "Faculty");

                    dgvStudents.Rows.Add();
                    dgvStudents.Rows[0].Cells["codeStudent"].Value = studentid.StudentID.ToString();
                    dgvStudents.Rows[0].Cells["name"].Value = studentid.FullName.ToString();
                    dgvStudents.Rows[0].Cells["averageScore"].Value = studentid.AverageScore.ToString();
                    dgvStudents.Rows[0].Cells["faculty"].Value = studentid.Faculty.FacultyName.ToString();
                    return;
                }
            }

            if (txtName != null && cmbFaculty != null)
            {
                var list_student = listStudent.Where(ls => ls.FullName.Equals(txtName.Text, StringComparison.OrdinalIgnoreCase)
                    && ls.Faculty.FacultyName == cmbFaculty.Text).ToList();
                if (list_student.Count > 0)
                {
                    dgvStudents.Columns.Add("codeStudent", "Student ID");
                    dgvStudents.Columns.Add("name", "Name");
                    dgvStudents.Columns.Add("averageScore", "Average Score");
                    dgvStudents.Columns.Add("faculty", "Faculty");

                    foreach (var student in list_student)
                    {
                        dgvStudents.Rows.Add();
                        dgvStudents.Rows[dgvStudents.Rows.Count - 1].Cells["codeStudent"].Value = student.StudentID.ToString();
                        dgvStudents.Rows[dgvStudents.Rows.Count - 1].Cells["name"].Value = student.FullName.ToString();
                        dgvStudents.Rows[dgvStudents.Rows.Count - 1].Cells["averageScore"].Value = student.AverageScore.ToString();
                        dgvStudents.Rows[dgvStudents.Rows.Count - 1].Cells["faculty"].Value = student.Faculty.FacultyName.ToString();
                    }
                    return;
                }
            }

            if (cmbFaculty != null)
            {
                var list_student1 = listStudent.Where(ls => ls.Faculty.FacultyName == cmbFaculty.Text).ToList();
                if (list_student1.Count > 0)
                {
                    dgvStudents.Columns.Add("codeStudent", "Student ID");
                    dgvStudents.Columns.Add("name", "Name");
                    dgvStudents.Columns.Add("averageScore", "Average Score");
                    dgvStudents.Columns.Add("faculty", "Faculty");

                    foreach (var student in list_student1)
                    {
                        dgvStudents.Rows.Add();
                        dgvStudents.Rows[dgvStudents.Rows.Count - 1].Cells["codeStudent"].Value = student.StudentID.ToString();
                        dgvStudents.Rows[dgvStudents.Rows.Count - 1].Cells["name"].Value = student.FullName.ToString();
                        dgvStudents.Rows[dgvStudents.Rows.Count - 1].Cells["averageScore"].Value = student.AverageScore.ToString();
                        dgvStudents.Rows[dgvStudents.Rows.Count - 1].Cells["faculty"].Value = student.Faculty.FacultyName.ToString();
                    }
                    return;
                }
            }

            if (cmbFaculty != null && txtCodeStudent != null)
            {
                var list_student2 = listStudent.Where(ls => ls.Faculty.FacultyName == cmbFaculty.Text
                    && ls.StudentID.Equals(txtCodeStudent.Text)).ToList();
                if (list_student2.Count > 0)
                {
                    dgvStudents.Columns.Add("codeStudent", "Student ID");
                    dgvStudents.Columns.Add("name", "Name");
                    dgvStudents.Columns.Add("averageScore", "Average Score");
                    dgvStudents.Columns.Add("faculty", "Faculty");

                    foreach (var student in list_student2)
                    {
                        dgvStudents.Rows.Add();
                        dgvStudents.Rows[dgvStudents.Rows.Count - 1].Cells["codeStudent"].Value = student.StudentID.ToString();
                        dgvStudents.Rows[dgvStudents.Rows.Count - 1].Cells["name"].Value = student.FullName.ToString();
                        dgvStudents.Rows[dgvStudents.Rows.Count - 1].Cells["averageScore"].Value = student.AverageScore.ToString();
                        dgvStudents.Rows[dgvStudents.Rows.Count - 1].Cells["faculty"].Value = student.Faculty.FacultyName.ToString();
                    }
                    return;
                }
            }

            if (txtName != null && txtCodeStudent != null)
            {
                var list_student3 = listStudent.Where(ls => ls.StudentID.Equals(txtCodeStudent.Text)
                    && ls.Faculty.FacultyName == cmbFaculty.Text).ToList();
                if (list_student3.Count > 0)
                {
                    dgvStudents.Columns.Add("codeStudent", "Student ID");
                    dgvStudents.Columns.Add("name", "Name");
                    dgvStudents.Columns.Add("averageScore", "Average Score");
                    dgvStudents.Columns.Add("faculty", "Faculty");

                    foreach (var student in list_student3)
                    {
                        dgvStudents.Rows.Add();
                        dgvStudents.Rows[dgvStudents.Rows.Count - 1].Cells["codeStudent"].Value = student.StudentID.ToString();
                        dgvStudents.Rows[dgvStudents.Rows.Count - 1].Cells["name"].Value = student.FullName.ToString();
                        dgvStudents.Rows[dgvStudents.Rows.Count - 1].Cells["averageScore"].Value = student.AverageScore.ToString();
                        dgvStudents.Rows[dgvStudents.Rows.Count - 1].Cells["faculty"].Value = student.Faculty.FacultyName.ToString();
                    }
                    return;
                }
            }

            if (txtCodeStudent != null)
            {
                var list_student4 = listStudent.Where(ls => ls.StudentID.Equals(txtCodeStudent.Text)).ToList();
                if (list_student4.Count > 0)
                {
                    dgvStudents.Columns.Add("codeStudent", "Student ID");
                    dgvStudents.Columns.Add("name", "Name");
                    dgvStudents.Columns.Add("averageScore", "Average Score");
                    dgvStudents.Columns.Add("faculty", "Faculty");

                    foreach (var student in list_student4)
                    {
                        dgvStudents.Rows.Add();
                        dgvStudents.Rows[dgvStudents.Rows.Count - 1].Cells["codeStudent"].Value = student.StudentID.ToString();
                        dgvStudents.Rows[dgvStudents.Rows.Count - 1].Cells["name"].Value = student.FullName.ToString();
                        dgvStudents.Rows[dgvStudents.Rows.Count - 1].Cells["averageScore"].Value = student.AverageScore.ToString();
                        dgvStudents.Rows[dgvStudents.Rows.Count - 1].Cells["faculty"].Value = student.Faculty.FacultyName.ToString();
                    }
                    return;
                }
            }
                var list_student5 = listStudent.Where(ls => ls.FullName.Equals(txtName.Text, StringComparison.OrdinalIgnoreCase)).ToList();
                if (list_student5.Count > 0)
                {
                    dgvStudents.Columns.Add("codeStudent", "Student ID");
                    dgvStudents.Columns.Add("name", "Name");
                    dgvStudents.Columns.Add("averageScore", "Average Score");
                    dgvStudents.Columns.Add("faculty", "Faculty");

                    foreach (var student in list_student5)
                    {
                        dgvStudents.Rows.Add();
                        dgvStudents.Rows[dgvStudents.Rows.Count - 1].Cells["codeStudent"].Value = student.StudentID.ToString();
                        dgvStudents.Rows[dgvStudents.Rows.Count - 1].Cells["name"].Value = student.FullName.ToString();
                        dgvStudents.Rows[dgvStudents.Rows.Count - 1].Cells["averageScore"].Value = student.AverageScore.ToString();
                        dgvStudents.Rows[dgvStudents.Rows.Count - 1].Cells["faculty"].Value = student.Faculty.FacultyName.ToString();
                    }
                    return;
                }
            
            MessageBox.Show("List student not found with the given criteria", "Confident ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
