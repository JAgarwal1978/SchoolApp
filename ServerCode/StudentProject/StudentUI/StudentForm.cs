using Computech.Students.BO;
using Computech.Students.DTOs;
namespace StudentUI

{
    public partial class StudentForm : Form
    {
        List<Student> students = new List<Student>();
        public StudentForm()
        {
            InitializeComponent();
            InitcmbGender();
            INitCity();
        }

        private void myclick(object sender, EventArgs e)
        {
            MessageBox.Show("Form clicked");

        }
        private void StudentForm_Load(object sender, EventArgs e)
        {
            StudentBO studentBO = new StudentBO();
            students = studentBO.GetStudents();
            dgvStudent.DataSource = students;
        }

        private void InitcmbGender()
        {
            List<string> genders = new List<string>
            {
               "All","F", "M"
            };
            cmbGender.DataSource = genders;

        }

        private void cmbGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvStudent.DataSource = GetStudentsByGender(cmbGender.SelectedValue?.ToString());
            // MessageBox.Show(cmbGender.SelectedValue.ToString());
            //if (cmbGender.SelectedValue != null && cmbGender.SelectedValue?.ToString() != "All")
            //{
            //    var filterStudents = students.Where(s => s.Gender == cmbGender.SelectedValue?.ToString()).ToList();
            //    dgvStudent.DataSource = filterStudents;
            //}
            //else
            //{
            //    dgvStudent.DataSource = students;
            //}
        }

        public List<Student> GetStudentsByGender(string gender)
        {
            // MessageBox.Show(cmbGender.SelectedValue.ToString());
            if (gender != null && gender != "All")
            {
                var filterStudents = students.Where(s => s.Gender == cmbGender.SelectedValue?.ToString()).ToList();
                return filterStudents;
            }
            else
            {
                return students;
            }
        }

        private void INitCity()
        {
            List<string> citis = new List<string>
            {
               "All", "Mumbai", "Pune", "Delhi", "Bengaluru"
             };
            cmbCity.DataSource = citis;

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Student> filterstudent = GetStudentsByGender(cmbGender.SelectedValue?.ToString());

            if (cmbCity.SelectedItem != null && cmbCity.SelectedItem?.ToString() != "All")
            {
                var filterCitys = filterstudent.Where(s => s.CityName == cmbCity.SelectedItem?.ToString()).ToList();
                dgvStudent.DataSource = filterCitys;
            }
            else
            {
                dgvStudent.DataSource = filterstudent;
            }
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            AddEditStudent ae = new AddEditStudent();
            ae.ShowDialog();
        }
    }
}
