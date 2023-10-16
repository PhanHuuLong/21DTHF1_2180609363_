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
namespace Lab4_01
{
    public partial class FormNew : Form
    {
        List<Faculty> listFaculty = new List<Faculty>();
      
        public FormNew()
        {
            InitializeComponent();
        }
        private void FormNew_Load(object sender, EventArgs e)
        {
            Bindgird();
        }
        void Bindgird()
        {
            StudentContextDB db = new StudentContextDB();
            List<Student> listStudent = db.Students.ToList();

            dgvStudents.DataSource = null;
            dgvStudents.Rows.Clear();
            dgvStudents.Columns.Clear();

            // Thêm các cột vào DataGridView
            dgvStudents.Columns.Add("codeStudent", "Code Student");
            dgvStudents.Columns.Add("name", "Name");
            dgvStudents.Columns.Add("averageScore", "Average Score");
            dgvStudents.Columns.Add("faculty", "Faculty");

            // Đổ dữ liệu vào từng dòng
            foreach (var studentid in listStudent)
            {
                dgvStudents.Rows.Add();
                dgvStudents.Rows[dgvStudents.Rows.Count - 1].Cells["codeStudent"].Value = studentid.StudentID.ToString();
                dgvStudents.Rows[dgvStudents.Rows.Count - 1].Cells["name"].Value = studentid.FullName.ToString();
                dgvStudents.Rows[dgvStudents.Rows.Count - 1].Cells["averageScore"].Value = studentid.AverageScore.ToString();
                dgvStudents.Rows[dgvStudents.Rows.Count - 1].Cells["faculty"].Value = studentid.Faculty.FacultyName.ToString();
            }
        }


    }
}
