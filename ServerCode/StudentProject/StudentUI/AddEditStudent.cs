using Computech.Students.BO;
using Computech.Students.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentUI
{
    public partial class AddEditStudent : Form
    {
        public AddEditStudent()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int studentId;
            int.TryParse(txtStudentID.Text, out studentId);
            Student student = new Student()
            {
                StudentID = studentId,
                FirstName = txtFname.Text,
                LastName = txtLname.Text,
                DateOfBirth = dtpDOB.Value,
                Address = txtAddress.Text,
                Email = txtEmail.Text,
                Gender = cmbGender.Text,
                Phone = txtPhone.Text,
                City = cmbCity.Text

            };
            //new StudentBO().AddStudent(student);
            StudentBO studentBO = new StudentBO();
            var existingStudent = studentBO.GetStudentByID(studentId);
            if (existingStudent != null && existingStudent.StudentID > 0)
            {
                studentBO.UpdateStudent(student);
                MessageBox.Show("Student updated successfully.");
            }
            else
            {
                studentBO.AddStudent(student);
                MessageBox.Show("Student added successfully.");
            }

        }
     
      
    }
}
