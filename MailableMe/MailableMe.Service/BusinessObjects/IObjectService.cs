using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MailableMe.Service.Core;
using MailableMe.Data;

namespace MailableMe.Service.BusinessObjects
{
    public interface IObjectService<T>:IFactory<T> where T:BaseObject
    {
    }
}
