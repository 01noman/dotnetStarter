using System.ComponentModel.DataAnnotations;

namespace WebAppStartar.Models;
//{
    public class Customer
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }
        
        [Range(0, 150, ErrorMessage = "Age must be between 0 and 150")]
        public  int Age { get; set; }
    }
//}



