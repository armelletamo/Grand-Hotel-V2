using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GrandHotel.Core.Models
{
    public class Contact
    {
        [StringLength(100)]
        [BindRequired]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [EmailAddress(ErrorMessage = "The email is incorrect")]
        [BindRequired]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [StringLength(100)]
        [BindRequired]
        [Display(Name = "Subject")]
        public string Subject { get; set; }

        [DataType(DataType.MultilineText)]
        [Display(Name = "Message")]
        public string Message { get; set; }
    }
}
