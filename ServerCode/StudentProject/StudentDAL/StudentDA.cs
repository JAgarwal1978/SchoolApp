using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Pkcs;
using System.Text;
using System.Threading.Tasks;
using Computech.Students.DTOs;
using Microsoft.Data.SqlClient;

namespace Computech.Students.DAL 
{
    public class StudentDA
    {
      private static readonly string connectionstr = "Data Source=DESKTOP-DVRGJB8\\SQLEXPRESS;Initial Catalog=StudentDB;Integrated Security=True;Encrypt=False";

        public List<Student> GetStudents()
        {
            var students = new List<Student>(); 
            
           using(var con = new SqlConnection(connectionstr))
            {
                con.Open();
                using (var cmd = new SqlCommand("dbo.svgStudents", con))
                {
                   // cmd.CommandText = "dbo.svgStudents";
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var student = new Student();
                            student.StudentID = Convert.ToInt32(reader["StudentID"]);
                            student.FirstName = reader["FirstName"]?.ToString();
                            student.LastName = reader["LastName"]?.ToString();
                            student.Email = reader["Email"]?.ToString();
                            student.Address = reader["Address"]?.ToString();
                            student.Gender = reader["Gender"]?.ToString();
                            student.CityID = Convert.ToInt32(reader["CityID"]);
                            student.CityName = reader["CityName"]?.ToString();

                            students.Add(student);
                        }
                    }
                       

                }

                    con.Close();
            }
            
           
            return students;
        }


        public Student GetStudentByID(int id)
        {
            var student = new Student();

            using (var con = new SqlConnection(connectionstr))
            {
                con.Open();
                using (var cmd = new SqlCommand("dbo.svgStudentById", con))
                {
                    // cmd.CommandText = "dbo.svgStudents";
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    SqlParameter sp = new SqlParameter();
                    sp.ParameterName = "@StudentID";
                    sp.Value = id;
                    sp.DbType = System.Data.DbType.Int32;
                    cmd.Parameters.Add(sp);
                   // cmd.Parameters.AddWithValue(connectionstr, sp); 
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            student.StudentID = Convert.ToInt32(reader["StudentID"]);
                            student.FirstName = reader["FirstName"]?.ToString();
                        }
                    }


                }

                con.Close();
            }


            return student;
        }

        public List<StudentMarks> GetStudentsMarks()
        {
            var studentsMarks = new List<StudentMarks>();

            using (var con = new SqlConnection(connectionstr))
            {
                con.Open();
                using (var cmd = new SqlCommand("dbo.svgStudentsMarks", con))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var studentMarks = new StudentMarks();
                            studentMarks.StudentDetail.StudentID = Convert.ToInt32(reader["StudentID"]);
                            studentMarks.FullName = reader["FullName"].ToString();
                            studentMarks.Percentage = Convert.ToDecimal(reader["Percentage"].ToString());
                           
                        }
                    }


                }

                con.Close();
            }


            return studentsMarks;
        }
        public void AddStudent(Student student)
        {
            using (var con = new SqlConnection(connectionstr))
            {
                con.Open();
                using (var cmd = new SqlCommand("dbo.spiuStudent", con))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@FirstName", student.FirstName);
                    cmd.Parameters.AddWithValue("@LastName", student.LastName);
                    cmd.Parameters.AddWithValue("@DateOfBirth", student.DateOfBirth.Date);
                    cmd.Parameters.AddWithValue("@Gender", student.Gender);
                    cmd.Parameters.AddWithValue("@Email", student.Email);
                    cmd.Parameters.AddWithValue("@Phone", student.Phone);
                    cmd.Parameters.AddWithValue("@Address", student.Address);
                    int? cityID = student.CityID == 0 ? null : student.CityID;
                    cmd.Parameters.AddWithValue("@CityID", cityID.HasValue?cityID.Value:DBNull.Value);
                   
                    cmd.ExecuteNonQuery();


                }

                con.Close();
            }
        }
        public void UpdateStudent(Student student)
        {
            using (var con = new SqlConnection(connectionstr))
            {
                con.Open();
                using (var cmd = new SqlCommand("dbo.spuStudent", con))
                {
                    cmd.CommandType=System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@StudentID", student.StudentID);
                    cmd.Parameters.AddWithValue("@FirstName", student.FirstName);
                    cmd.Parameters.AddWithValue("@LastName", student.LastName);
                    cmd.Parameters.AddWithValue("@DateOfBirth", student.DateOfBirth.Date);
                    cmd.Parameters.AddWithValue("@Gender", student.Gender);
                    cmd.Parameters.AddWithValue("@Email", student.Email);
                    cmd.Parameters.AddWithValue("@Phone", student.Phone);
                    cmd.Parameters.AddWithValue("@Address", student.Address);
                    int?CityID=student.CityID == 0 ? null :student.CityID;
                    cmd.Parameters.AddWithValue("@CityID",CityID.HasValue?CityID.Value:DBNull.Value);
                    cmd.ExecuteNonQuery();

                }
                con.Close();
            }
        }
    }
}
