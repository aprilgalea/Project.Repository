using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Data.Common;
using MailableMe.Data.Entity;

namespace MailableMe.Data
{
    public class DBInitializer<T>: IDatabaseInitializer<T> where T:DbContext
    {
        public DBInitializer(Action<T> seed = null)
        {
            Seed = seed ?? delegate { };
        }

        public Action<T> Seed { get; set; }

        public void InitializeDatabase(T context)            
        {

            if (!context.Database.Exists() || !context.Database.CompatibleWithModel(false))
            {
                context.Database.Delete();
                context.Database.Create();
            }                        
        }       

    }

    public class BlogContextSeedInitializer : DropCreateDatabaseAlways<MailableMeContext>
    {
        protected override void Seed(MailableMeContext context)
        {
            User user = new User { UserName = "april.galea", Password = "e0c9035898dd52fc65c41454cec9c4d2611bfb37", Active = true };
            context.Users.Add(user);
            context.SaveChanges();
        }
    }
}
