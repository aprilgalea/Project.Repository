using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Data.Common;

namespace MailableMe.Data
{
    public class DBInitializer<T>: IDatabaseInitializer<T> where T:DbContext
    {
        //public DBInitializer(Action<T> seed = null)
        //{ 
        //    Seed = seed ?? delegate { };
        //}

        //public Action<T> Seed { get; set; }

        public void InitializeDatabase(T context)            
        {                       
            if (!context.Database.Exists())
            {
                context.Database.Create();
            }
        }
    }
}
