using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MailableMe.Data;
using MailableMe.Service.Core;

namespace MailableMe.Service.Repository
{
    public class GenericRepository<T>: BaseRepository<T,MailableMe.Data.MailableMeContext> where T: BaseObject
    {
    }
}
