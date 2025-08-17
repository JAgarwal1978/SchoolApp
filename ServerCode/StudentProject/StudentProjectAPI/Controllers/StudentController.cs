using Microsoft.AspNetCore.Mvc;
using Computech.Students.BO;
using Computech.Students.DTOs;

namespace StudentProjectAPI.Controllers
{
    [ApiController]
    public class StudentController : ControllerBase
    {
        [HttpGet]
        [Route("GetStudents")]
        public  ActionResult <List<Student>> GetStudents()
        {
            var students = new List<Student>();
            students = new StudentBO().GetStudents();
            return students;
        }

        [HttpPost]
        [Route("GetStudentbyId")]
        public ActionResult <Student> GetStudentbyId(int id)
        {

            var students = new List<Student>();
            students = new StudentBO().GetStudents();
            return students.FirstOrDefault(s => s.StudentID == id) ?? new Student();

        }
        [HttpGet("{id}")]
        //[Route("GetStudbyID")]
        public ActionResult<Student> GetStudbyID(int id)
        {
            var students = new List<Student>();
            students = new StudentBO().GetStudents();
            return students.FirstOrDefault(s => s.StudentID == id) ?? new Student();

        }

        //[HttpPost]
        //[Route("AddStudent")]
        //public ActionResult<List<Student>> AddStudent([FromBody]Student student)
        //{
        //    var studentBO = new StudentBO();
        //    studentBO.AddStudent(student);
        //    var result = studentBO.GetStudents();
        //    return result;

        //}

        //[HttpPost]
        //[Route("AddStudent")]
        //public IActionResult? AddStudent([FromBody] Student student)
        //{
        //    var studentBO = new StudentBO();
        //    studentBO.AddStudent(student);
        //    List<Student>? result = studentBO.GetStudents();
        //    return Ok(result);
        // return Ok("studentedit");

        //}

        [HttpPost]
        [Route("AddStudent")]
        public JsonResult AddStudent([FromBody] Student student)
        {
            if (student.StudentID != 0)
            {
                var studentBO = new StudentBO();
                studentBO.AddStudent(student);
                List<Student>? result = studentBO.GetStudents();
                return new JsonResult(result);
            }
            else
            {
                ErrorMessage er = new ErrorMessage();
                er.Message = "student id not provided";
                er.Code = "es001";
                return new JsonResult(er);
            }

        }
    }
}
