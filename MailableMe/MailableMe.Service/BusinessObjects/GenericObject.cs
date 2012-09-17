using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MailableMe.Service.Core;
using MailableMe.Data;

namespace MailableMe.Service.BusinessObjects
{
    public class GenericObject<T>: BaseClass<T> where T: BaseObject
    {
    }
}
