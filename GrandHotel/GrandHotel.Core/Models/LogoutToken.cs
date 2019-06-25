using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GrandHotel.Core.Models
{
    public class LogoutToken
    {
        [Key]
        public int Id { get; set; }
        public string Username { get; set; }
        public string Token { get; set; }
    }
}
