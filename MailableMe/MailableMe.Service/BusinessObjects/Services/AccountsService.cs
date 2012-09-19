using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MailableMe.Service.Core;
using MailableMe.Data.Entity;
using MailableMe.Service.BusinessObjects.IServices;

namespace MailableMe.Service.BusinessObjects.Services
{
    public class AccountsService: BaseFactory<Account>, IAccountsService
    {
        
    }
}
