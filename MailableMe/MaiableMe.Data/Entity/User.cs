using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MailableMe.Data;
using System.ComponentModel.DataAnnotations;

namespace MailableMe.Data.Entity
{
    public class User:BaseObject
    {
        [Required]        
        public string UserName { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public DateTime PasswordExpiry { get; set; }

        [Required]
        public bool Active { get; set; }
    }
}
