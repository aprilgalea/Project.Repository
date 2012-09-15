using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Data.Common;
using MailableMe.Data.Entity;


namespace MailableMe.Data
{
    public class MailableMeContext:DbContext
    {      
        public DbSet<Account> Accounts { get; set; }
        public DbSet<AccountSecurityQuestion> AccountSecurityQuestions { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Email> Emails { get; set; }
        public DbSet<SecurityQuestion> SecurityQuestions  { get; set; }

        public DbSet<T> GetDbSet<T>() where T:BaseObject
        {
            if (typeof(T) == typeof(Account))
                return (DbSet<T>)(object)Accounts;
            if (typeof(T) == typeof(AccountSecurityQuestion))
                return (DbSet<T>)(object)AccountSecurityQuestions;
            if (typeof(T) == typeof(Blog))
                return (DbSet<T>)(object)Blogs;
            if (typeof(T) == typeof(Email))
                return (DbSet<T>)(object)Emails;
            if (typeof(T) == typeof(SecurityQuestion))
                return (DbSet<T>)(object)SecurityQuestions;
            else
                return null;
        }
    }
}
