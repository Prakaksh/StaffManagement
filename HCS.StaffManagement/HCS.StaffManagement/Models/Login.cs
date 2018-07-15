using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HCS.StaffManagement.Models
{
    public class Login
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        public string EmailID { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}