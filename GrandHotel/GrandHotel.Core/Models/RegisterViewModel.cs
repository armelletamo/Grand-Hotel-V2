using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GrandHotel.Core.Models
{
    public class RegisterViewModel
    {
        [Required]
        [EmailAddress]
        [BindRequired]
        public string Email { get; set; }

        [Required]
        [BindRequired]
        [StringLength(255, ErrorMessage = "The password must be between 5 and 255 characters", MinimumLength = 8)]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }

}
