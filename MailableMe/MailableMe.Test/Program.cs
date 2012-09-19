using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MailableMe.Data;
using MailableMe.Data.Entity;
using System.Data.Common;
using System.Data.Entity;
using MailableMe.Service.Repository;
using MailableMe.Service.Core;
using MailableMe.Service.BusinessObjects.IServices;
using MailableMe.Service.BusinessObjects.Services;
using MailableMe.Service.BusinessObjects;

namespace MailableMe.Test
{
    class Program
    {
        private static IUsersService EFUsers
        {
            get
            {
                return new UsersService();
            }
        }
        static void Main(string[] args)
        {
            //var p = EFUsers.GetUserWithPassword("april", "password");

        }
    }


}
