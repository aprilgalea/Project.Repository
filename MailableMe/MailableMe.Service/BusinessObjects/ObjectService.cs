using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MailableMe.Service.Core;
using MailableMe.Data;

namespace MailableMe.Service.BusinessObjects
{
    public class ObjectService<T>: BaseFactory<T>,IObjectService<T> where T: BaseObject
    {
    }
}
