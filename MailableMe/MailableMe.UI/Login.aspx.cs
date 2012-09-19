using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MailableMe.Service.Common.Security;
using System.Web.Security;

namespace MailableMe.UI
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if (SecurityManager.Login(this.tbUser.Text, this.tbPwd.Text))
            {
                //FormsAuthentication.SetAuthCookie(this.tbUser.Text, false);
                //EFPrincipal Principal = new EFPrincipal((EFIdentity)HttpContext.Current.User.Identity);
                FormsAuthentication.RedirectFromLoginPage(this.tbUser.Text, false);
                return;
            }

            this.error_info.Text = @"Invalid username/password. Please try again.";
            this.error_info.Visible = true;

        }
    }
}