using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MailableMe.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MailableMe.Data.Entity
{
    public class AccountSecurityQuestion:BaseObject
    {
        [Required]
        [ForeignKey("Account")]
        public int AccountID { get; set; }

        [Required]
        [ForeignKey("SecurityQuestion")]
        public int SecurityQuestionID { get; set; }

        [Required]
        public string Answer { get; set; }

        public virtual Account Account { get; set; }
        public virtual SecurityQuestion SecurityQuestion { get; set; }

    }
}
