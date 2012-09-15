using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MailableMe.Data;
using System.Data.Common;
using System.Data.Entity;

namespace MailableMe.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Database.SetInitializer(new DBInitializer<MailableMeContext>());

            DbContext context = new MailableMeContext();
            var p = context.Set<MailableMe.Data.Entity.Account>().SingleOrDefault();
        }
    }
}
