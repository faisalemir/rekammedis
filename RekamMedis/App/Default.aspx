<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Default.aspx.vb" Inherits="RekamMedis._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Login</h1>
        <asp:Label ID="lbl_info" runat="server"></asp:Label>
        <br />
        <br />
        Username :<br />
        <asp:TextBox ID="tbx_username" runat="server"></asp:TextBox>
        <br />
        <br />
        Password :<br />
        <asp:TextBox ID="tbx_password" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btn_login" runat="server" Text="Login" />
    </form>
</body>
</html>
