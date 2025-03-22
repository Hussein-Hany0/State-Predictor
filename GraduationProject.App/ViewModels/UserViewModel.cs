using System.ComponentModel.DataAnnotations;

namespace GraduationProject.App.ViewModels
{
    public class UserViewModel
    {
        [Display(Name = "Your Name")]
        public string UserName { get; set; }

        [EmailAddress(ErrorMessage = "This is not a valid email address") , MaxLength(50)]
        public string Email { get; set; }

        public string Password { get; set; }

        public int Gender { get; set; }
    }
}
