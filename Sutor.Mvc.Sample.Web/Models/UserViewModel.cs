using System.ComponentModel.DataAnnotations;

namespace Sutor.Mvc.Sample.Web.Models
{
    public class UserViewModel
    {
        [Required]
        [StringLength(10)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(10)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        public string DisplayName => $"{FirstName} {LastName}";
    }
}
