using System.ComponentModel.DataAnnotations;


namespace login_registration.Models
{
    public class User : BaseEntity
    {
        public int idUser { get; set; }

        [Required]
        // [DataType(DataType.String)]
        [MinLength(2)]
        [Display(Name = "First Name")]
        public string first_name { get; set; }
        
        [Required]
        // [DataType(String)]
        [MinLength(2)]
        [Display(Name = "Last Name")]
        public string last_name { get; set; }
        
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string email { get; set; }
        
        [Required]
        [MinLength(8)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string password { get; set; }

        [Required]
        [MinLength(8)]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        public string PasswordConfirmation { get; set; }

        public User (){
            idUser = idUser;
            first_name = first_name;
            last_name = last_name;
            email = email;
            password = password;
            PasswordConfirmation = PasswordConfirmation;
        }


    }

}
