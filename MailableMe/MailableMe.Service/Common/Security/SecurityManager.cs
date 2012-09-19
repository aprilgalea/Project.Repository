using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MailableMe.Service.BusinessObjects.IServices;
using MailableMe.Service.BusinessObjects.Services;
using MailableMe.Service.Common;
using MailableMe.Data.Entity;
using System.Web;

namespace MailableMe.Service.Common.Security
{
    public static class SecurityManager
    {
        public static bool Login(string username, string password)
        {
            EFIdentity identity = new EFIdentity().GetIdentity(username, password);
            if (identity.IsAuthenticated)
            {
                EFPrincipal principal = new EFPrincipal(identity);
                HttpContext.Current.User = principal;
                return true;    
            }

            return false;
        }
    }
}
