using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MailableMe.Data;
using System.ComponentModel.DataAnnotations;

namespace MailableMe.Data.Entity
{
    public class Blog:BaseObject
    {
        [Required]
        public string BlogContent { get; set; }
    }
}
