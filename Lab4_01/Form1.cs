using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab4_01.Model;
namespace Lab4_01
{
    public partial class Form1 : Form
    {
        private List<Faculty> listFaculty = new List<Faculty>();
        //Cong da o day
        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StudentContextDB db = new StudentContextDB();

            this.listFaculty = db.Faculties.ToList(); 
            FillFacultyCombobox(this.listFaculty);
            BindGrid(db.Students.ToList());
            this.KeyDown += new KeyEventHandler(Form1_KeyDown);
        }
        private void BindGrid(List<Student> listStudent)
        {
            dgvStudents.Rows.Clear();
            foreach (var student in listStudent)
            {
                int index = dgvStudents.Rows.Add();
                dgvStudents.Rows[index].Cells["codeStudent"].Value = student.StudentID;
                dgvStudents.Rows[index].Cells["name"].Value = student.FullName;
                dgvStudents.Rows[index].Cells["averageScore"].Value = student.AverageScore;

                if (student.Faculty != null && student.Faculty.FacultyName != null)
                {
                    dgvStudents.Rows[index].Cells["faculty"].Value = student.Faculty.FacultyName;
                }
            }
        }
        void FillFacultyCombobox (List<Faculty> listFaculty)
        {
            this.comboBoxFaculty.DataSource = listFaculty;
            this.comboBoxFaculty.DisplayMember = "FacultyName";
            this.comboBoxFaculty.ValueMember = "FacultyID";
        }

        private void butExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void butAdd_Click(object sender, EventArgs e)
        {
            StudentContextDB db = new StudentContextDB();

            string studentID = txtCodeStudent.Text;
            Student existingStudent = db.Students.FirstOrDefault(s => s.StudentID == studentID);

            if (existingStudent != null)
            {
                MessageBox.Show("Student with the same ID already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Student student = new Student()
            {
                StudentID = studentID,
                FullName = txtName.Text,
                FacultyID = (int)comboBoxFaculty.SelectedValue,
            };

            double averageScore;
            if (double.TryParse(txtAverageScore.Text, out averageScore))
            {
                student.AverageScore = averageScore;

                db.Students.Add(student);
                db.SaveChanges();
                BindGrid(db.Students.ToList());
            }
            else
            {
                MessageBox.Show("Invalid Average Score. Please enter a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void butUpdate_Click(object sender, EventArgs e)
        {
            StudentContextDB db = new StudentContextDB();
            var item = db.Students.FirstOrDefault(s => s.StudentID.Equals(txtCodeStudent.Text));

            if(item==null)
            {
                MessageBox.Show("Found no have Code Student!");
                return;
            }
            else
            {
                item.FullName = txtName.Text;
                item.FacultyID = (int)comboBoxFaculty.SelectedValue;
                item.AverageScore = double.Parse(txtAverageScore.Text);

                db.SaveChanges();
                BindGrid(db.Students.ToList());
            }
        }



        private void butDelete_Click(object sender, EventArgs e)
        {
            int selectedRowIndex = dgvStudents.SelectedCells[0].RowIndex;
            if (selectedRowIndex >= 0)
            {
                string studentId = dgvStudents.Rows[selectedRowIndex].Cells["codeStudent"].Value.ToString();

                DialogResult result = MessageBox.Show("Are you sure you want to delete this student?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    StudentContextDB db = new StudentContextDB();
                    var student = db.Students.SingleOrDefault(s => s.StudentID.Equals(studentId));

                    if (student != null)
                    {
                        db.Students.Remove(student);
                        db.SaveChanges();
                        BindGrid(db.Students.ToList());
                    }
                    else
                    {
                        MessageBox.Show("Student not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a student to delete.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            MessageBox.Show($"You entered at {rowIndex}.");

            if (rowIndex >= 0)
            {
                txtCodeStudent.Text = dgvStudents.Rows[rowIndex].Cells["codeStudent"].Value.ToString();
                txtName.Text = dgvStudents.Rows[rowIndex].Cells["name"].Value.ToString();
                txtAverageScore.Text = dgvStudents.Rows[rowIndex].Cells["averageScore"].Value.ToString();

                var facultyname = dgvStudents.Rows[rowIndex].Cells["faculty"].Value.ToString();
                var faculty = this.listFaculty.FirstOrDefault(c => c.FacultyName.Equals(facultyname));

                if (faculty == null)
                {
                    comboBoxFaculty.SelectedValue = null;
                }
                else
                {
                    comboBoxFaculty.SelectedValue = faculty.FacultyID;
                }
            }
        }

        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void manegerFacultyF2ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void FrmFalculty_Click(object sender, EventArgs e)
        {
            FrmManagerFaculty ff = new FrmManagerFaculty();
            ff.ShowDialog();
        }

        private void manegerFacultyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmManagerFaculty fm = new FrmManagerFaculty();
            fm.ShowDialog();
        }

        private void findCtrlFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FindStudent fs=new FindStudent();
            fs.ShowDialog();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F2) {
                FrmManagerFaculty fm = new FrmManagerFaculty();
                fm.ShowDialog();
            }
            if(e.Control && e.KeyCode == Keys.F) {
                FindStudent fs = new FindStudent();
                fs.ShowDialog();
            }
        }

        private void toolStripButton1_ManegerFaculty_Click(object sender, EventArgs e)
        {
            FrmManagerFaculty fm=new FrmManagerFaculty();
            fm.ShowDialog();
        }

        private void toolStripLabel2_ManagerFaculty_Click(object sender, EventArgs e)
        {
            FrmManagerFaculty fm = new FrmManagerFaculty();
            fm.ShowDialog();
        }

        private void toolStripProgressBar1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please enter StudentID and click one time enter.", "Confident", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void toolStripLabel_FindByName_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please enter StudentID in text.", "Confident", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
