using System;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace formsubmission.Models{

    public class User : BaseEntity {
        
        [Required]
        [MinLength(4)]
        public string FirstName { get; set; }

        [Required]
        [MinLength(4)]
        public string LastName { get; set; }
        
        [Required]
        [Range(0, 200)]
        public int Age { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }
 
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
