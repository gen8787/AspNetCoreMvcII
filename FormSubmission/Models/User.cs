using System.ComponentModel.DataAnnotations; //Validations

namespace FormSubmission.Models
{
    public class User
    {
        [Required]
        [MinLength(4)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }


        [Required]
        [MinLength(4)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }


        [Required]
        [Range(1, 111)]
        public string Age { get; set; }


        [Required]
        [EmailAddress]
        public string Email { get; set; }


        [Required]
        [MinLength(8)]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}