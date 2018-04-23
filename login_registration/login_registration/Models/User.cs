using System.ComponentModel.DataAnnotations;

namespace login_registration.Models
{
    public class User : BaseEntity
    {
        [Required]
        // [DataType(DataType.String)]
        [MinLength(2)]
        public string first_name { get; set; }

        [Required]
        // [DataType(DataType.String)]
        [MinLength(2)]
        public string last_name { get; set; }
        
        [Required]
        [EmailAddress]
        public string email { get; set; }
        
        [Required]
        [MinLength(8)]
        [DataType(DataType.Password)]
        public string password { get; set; }

        [Required]
        [MinLength(8)]
        [DataType(DataType.Password)]
        public string PasswordConfirmation { get; set; }

        public User (){
            first_name = first_name;
            last_name = last_name;
            email = email;
            password = password;
            PasswordConfirmation = PasswordConfirmation;
        }


    }

}
