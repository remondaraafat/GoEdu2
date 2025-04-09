using System.ComponentModel.DataAnnotations;

namespace GoEdu.ViewModel
{
    public class VMRegister
    {
        public string UserName { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }

        [RegularExpression(@"\w+\.(com)")]
        public string Email { get; set; }

        [Range(1, 100, ErrorMessage = "Invalid Age, must be positive Number or less than 100!")]
        public int Age { get; set; }

        public string? Address { get; set; }

        [RegularExpression(@"^\\+?[0-9][0-9]{7,14}$", ErrorMessage = "Invalid Phone Number")]
        public string Phone { get; set; }
        public string? ImageUrl { get; internal set; }
        public bool IsStudent { get; set; }
        public bool IsInstructor { get; set; }

    }
}
