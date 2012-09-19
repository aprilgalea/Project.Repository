using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Principal;
using MailableMe.Service.BusinessObjects.IServices;
using MailableMe.Service.BusinessObjects.Services;
using MailableMe.Data.Entity;

namespace MailableMe.Service.Common.Security
{
    public class EFIdentity : IIdentity
    {       
        string _AuthenticationType;
        public string AuthenticationType
        {
            get { return "EF Authentication"; }
        }

        bool _IsAuthenticated;
        public bool IsAuthenticated
        {
            get { return this._IsAuthenticated; }
        }

        string _Name;
        public string Name
        {
            get { return this._Name; }
        }
        
        public EFIdentity GetIdentity(string username, string password)
        {
            IUsersService users = new UsersService();
            User user = users.GetUserWithPassword(username, Helper.HashPassword(password));
            this._IsAuthenticated = user != null;
            this._Name = user.UserName;
            return this;
        }
    }


}
