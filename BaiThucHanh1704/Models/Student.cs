using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BaiThucHanh1704.Models;

namespace DemoMVC.Models
{
    public class Student
    {
        [Key]
         public string StudentID { get; set; }
        public string StudentName { get; set; }
        public string FacultyID { get; set; }
        [ForeignKey("FacultyID")]
        public Faculty? Faculty { get; set; }
    }
}