using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MailableMe.Data;
using MailableMe.Data.Entity;
using System.Data.Common;
using System.Data.Entity;
using MailableMe.Service.Repository;
using MailableMe.Service.BusinessObjects;
using MailableMe.Service.Core;

namespace MailableMe.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            IObjects<Account> account = new GenericObject<Account>();
            account.CreateObject(new Account
            {
                Address = "Mandaluyong City",
                BirthDay = DateTime.Parse("04/13/1987"),
                EmailID = 1,
                EmailUser = "april.galea",
                FullName = "April B. Galea",
                Gender = "Male",
                Password = "password",
                PersonalEmail = "april.galea@live.com.ph"
            });            

            //IObjects<Email> email = new GenericObject<Email>();
            //email.CreateObject(new Email
            //{
            //    EmailPrefix = "mailable.me"
            //}
            //);
        }
    }


}
