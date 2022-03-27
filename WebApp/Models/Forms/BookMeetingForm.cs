using System.ComponentModel.DataAnnotations;

namespace WebApp.Models.Forms {
    public class BookMeetingForm {

        [Display(Name = "Firstname")]
        [Required(ErrorMessage = "This field is required")]
        [StringLength(256, ErrorMessage = "Must contain at least 2 characters", MinimumLength = 2)]
        [RegularExpression(@"^([a-öA-Ö]+?)([-][a-öA-Ö]+)*?$", ErrorMessage = "Must be a valid firstname")]
        public string FirstName { get; set; } = "";

        [Display(Name = "Email")]
        [Required(ErrorMessage = "This field is required")]
        [RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$", ErrorMessage = "Must contain a valid email address")]
        public string Email { get; set; } = "";

    }
}
