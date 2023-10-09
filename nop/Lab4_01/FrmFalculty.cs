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
using Lab4_01.Model;

namespace Lab4_01
{
    
    public partial class FrmManagerFaculty : Form
    {
        private List<Faculty> listFaculty = new List<Faculty>();
        public FrmManagerFaculty()
        {
            InitializeComponent();
        }

        private void txtCodeFalculty_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNameFalculty_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTotalFalculty_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvFalculty_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void butExit_Click(object sender, EventArgs e)
        {

        }

        private void totalProfessor_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmManagerFaculty_Load(object sender, EventArgs e)
        {
            StudentContextDB db = new StudentContextDB();
            this.listFaculty = db.Faculties.ToList();

            FillFacultyCombobox(this.listFaculty);
            BindGrid(db.Faculties.ToList());
        }
        void FillFacultyCombobox(List<Faculty> listFaculty)
        {
            this.comboBoxFaculty.DataSource= listFaculty;
            this.comboBoxFaculty.DisplayMember = "FacultyName";
            this.comboBoxFaculty.ValueMember = "FacultyID";
        }

        void BindGrid(List<Faculty> listFaculty)
        {
            dgvFalculty.Rows.Clear();
            foreach(Faculty faculty in listFaculty)
            {
                int index=dgvFalculty.Rows.Add();
                dgvFalculty.Rows[index].Cells["facultyID"].Value=faculty.FacultyID;
                dgvFalculty.Rows[index].Cells["totalProfessor"].Value = faculty.TotalProfessor;
                dgvFalculty.Rows[index].Cells["nameFaculty"].Value = faculty.FacultyName;
            }
        }
        private void butAdd_Click(object sender, EventArgs e)
        {
            StudentContextDB db = new StudentContextDB();
            int count=db.Faculties.Count()+1;
            Faculty f = new Faculty()
            {
                FacultyID= count,
                TotalProfessor = int.Parse(txtTotalFalcultyOfProfessor.Text),
                FacultyName = comboBoxFaculty.Text

            };
            db.Faculties.Add(f);
            db.SaveChanges();
            BindGrid(db.Faculties.ToList());
        }
        private void butUpdate_Click(object sender, EventArgs e)
        {
            StudentContextDB db=new StudentContextDB();
            var student = db.Faculties.SingleOrDefault(f => f.FacultyID.ToString().Equals(txtCodeFalculty.Text));
            if(student != null)
            {
                student.FacultyName= comboBoxFaculty.Text;
                student.TotalProfessor = int.Parse(txtTotalFalcultyOfProfessor.Text);

                db.SaveChanges() ;
                BindGrid(db.Faculties.ToList());
            }
            else
            {
                MessageBox.Show("No found code faculty you want delete.","Confident", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void butDelete_Click(object sender, EventArgs e)
        {
            int selectRowsIndex = dgvFalculty.SelectedCells[0].RowIndex;// lay ra rowindex dong đầu tiên trong dgvFaculty
            if (selectRowsIndex >= 0)
            {
                string facultyid = dgvFalculty.Rows[selectRowsIndex].Cells["facultyID"].Value.ToString();

                DialogResult result= MessageBox.Show("Do you want delete it?","Confident",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    StudentContextDB db = new StudentContextDB();
                    var faculty = db.Faculties.FirstOrDefault(f => f.FacultyID.ToString().Equals(facultyid));
                    if (faculty != null)
                    {
                        db.Faculties.Remove(faculty);
                        db.SaveChanges();
                        BindGrid(db.Faculties.ToList());
                    }
                    else
                    {
                        MessageBox.Show("No found StudentID you want delete.", "Confident",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please! chose line you want delete.", "Confident",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void labCodeFaculty_Click(object sender, EventArgs e)
        {

        }

        private void butExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmManagerFaculty_KeyDown(object sender, KeyEventArgs e)
        {
            
        }
    }
}
