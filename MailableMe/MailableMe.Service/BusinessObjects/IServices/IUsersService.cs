using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MailableMe.Service.Core;
using MailableMe.Data.Entity;

namespace MailableMe.Service.BusinessObjects.IServices
{
    public interface IUsersService: IFactory<User>
    {
        User GetUserWithPassword(string username, string password);
    }
}
