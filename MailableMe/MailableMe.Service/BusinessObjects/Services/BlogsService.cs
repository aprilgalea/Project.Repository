using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MailableMe.Service.Core;
using MailableMe.Service.BusinessObjects.IServices;
using MailableMe.Data.Entity;

namespace MailableMe.Service.BusinessObjects.Services
{
    public class BlogsService:BaseFactory<Blog>, IBlogsService
    {
    }
}
