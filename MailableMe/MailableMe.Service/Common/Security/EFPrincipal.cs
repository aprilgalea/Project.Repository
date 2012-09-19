using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Principal;
using System.Web;

namespace MailableMe.Service.Common.Security
{
    public class EFPrincipal: IPrincipal
    {
        EFIdentity _identity;

        public EFPrincipal(EFIdentity identity)
        {
            _identity = identity;
        }

        public System.Security.Principal.IIdentity Identity
        {
            get { return this._identity; }
        }

        public bool IsInRole(string role)
        {
            return true;
        }
    }
}
