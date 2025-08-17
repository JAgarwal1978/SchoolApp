using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Computech.Students.DTOs
{
    public class StudentMarks
    {
        public Student StudentDetail { get; set; } = new Student();
        public decimal Percentage { get; set; }
        public string FullName { get; set; } = string.Empty;
    }
}
