<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="MailableMe.UI.Login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="error_info" runat="server" Visible="false"/>
    </div>
    <div>
        <div>
            User Name
        </div>
        <div>
            <asp:TextBox ID="tbUser" runat="server" />
        </div>
        
        <div>
            Password
        </div>
        <div>
            <asp:TextBox ID="tbPwd" runat="server" />
        </div>
                
        <div>
            <asp:Button ID="btnLogin" Text="Login" runat="server" 
                onclick="btnLogin_Click"  />
        </div>
    </div>
    </form>
</body>
</html>
