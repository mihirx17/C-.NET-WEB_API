using System.ComponentModel.DataAnnotations;

namespace REST_API.Models
{
    public class Student_info
    {
        
        public int Id { get; set; }
        [Required(ErrorMessage = "Name Must required..")]
        public string Name { get; set; }

    }
}
