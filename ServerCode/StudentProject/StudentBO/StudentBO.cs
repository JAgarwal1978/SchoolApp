using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Computech.Students.DAL;
using Computech.Students.DTOs;

namespace Computech.Students.BO
{
    public class StudentBO
    {
        public StudentBO()
        {
            
        }

       public List<Student> GetStudents()
        {
            var students = new List<Student>();
            StudentDA studentDA = new StudentDA();
            students = studentDA.GetStudents();
            return students;
        }
        public Student GetStudentByID(int id)
        {
            Student s = new Student();
            StudentDA sda = new StudentDA();
            s = sda.GetStudentByID(id);
            return s;
        }

       
        public  List<StudentMarks > studentMarks()
        {
            var studentsMarks = new List<StudentMarks>();
            StudentDA sd = new StudentDA();
            studentsMarks = sd.GetStudentsMarks();
            return studentsMarks;
        }
        public void AddStudent(Student student)
        {
            new StudentDA().AddStudent(student);
        }

        public void UpdateStudent(Student student)
        {
            StudentDA sda = new StudentDA();
            sda.UpdateStudent(student);
        }
    }
}
