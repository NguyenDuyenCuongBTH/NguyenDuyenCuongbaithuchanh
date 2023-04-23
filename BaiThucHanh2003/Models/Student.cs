using System.ComponentModel.DataAnnotations;

namespace BaiThucHanh2003.Models
{
    public class Student
    {
        public string StudentID { get; set; }
        public string StudentName { get; set; }
        [Required(ErrorMessage = "Address is Required")]
        public string Address { get; set; }
    }
}