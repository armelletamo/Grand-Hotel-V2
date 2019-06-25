using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GrandHotel.Core.Models
{
    public class LoginViewModel
    {
        [Required]
        [BindRequired]
        [EmailAddress]
        public string Username { get; set; }

        [Required]
        [BindRequired]
        [StringLength(255, ErrorMessage = "Must be between 8 and 255 characters", MinimumLength = 8)]
        [DataType(DataType.Password)]
        [RegularExpression("([a-zA-Z]{1,})([0-9]{1,})", ErrorMessage ="the password must contain atleast 1 number, 1 uppercase and 1 lowercase")]
        public string Password { get; set; }
    }
}
