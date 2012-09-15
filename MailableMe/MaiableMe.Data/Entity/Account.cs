using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MailableMe.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MailableMe.Data.Entity
{
    public class Account:BaseObject
    {
        [Required]
        public string FullName { get; set; }

        [Required]        
        public string EmailUser { get; set; }

        [Required]
        [ForeignKey("Email")]
        public int EmailID { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string Gender { get; set; }

        [Required]
        public DateTime BirthDay { get; set; }

        [Required]
        public string Address { get; set; }

        public string PersonalEmail { get; set; }

        public virtual Email Email { get; set; }
    }
}
