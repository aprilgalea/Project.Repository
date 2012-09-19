using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MailableMe.Service.Core;
using MailableMe.Data.Entity;
using MailableMe.Service.BusinessObjects.IServices;

namespace MailableMe.Service.BusinessObjects.Services
{
    public class UsersService:BaseFactory<User>, IUsersService
    {
        public User GetUserWithPassword(string username, string password)
        {
            return this.GetObject(x => x.UserName == username && x.Password == password);
        }
    }
}
