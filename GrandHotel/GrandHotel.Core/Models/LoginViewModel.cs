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
        public string Username { get; set; }

        [Required]
        [BindRequired]
        [StringLength(255, ErrorMessage = "Must be between 5 and 255 characters", MinimumLength = 8)]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
