using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MailableMe.Data;
using System.ComponentModel.DataAnnotations;

namespace MailableMe.Data.Entity
{
    public class SecurityQuestion:BaseObject
    {
        [Required]
        public string Question { get; set; }
        
    }
}
