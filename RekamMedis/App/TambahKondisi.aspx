<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="TambahKondisi.aspx.vb" Inherits="RekamMedis.TambahKondisi" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <style type="text/css">
        #form1 div ul li {
            display:inline-block;
            text-decoration:none;
            padding: 0px 10px 0px 10px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <ul>
            <li><a href="RekamMedis.aspx">Rekam Medis</a></li>
            <li><a href="Kondisi.aspx">Kondisi</a></li>
            <li><a href="Logout.aspx">Logout</a></li>
        </ul>
    </div>
        <div>
    <h1>Tambah Kondisi</h1>
    <table>
        <tr>
            <td>ID Kondisi</td>
            <td>:</td>
            <td>
                <asp:TextBox ID="tbx_id" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Kondisi</td>
            <td>:</td>
            <td>
                <asp:TextBox ID="tbx_kondisi" runat="server"></asp:TextBox>
            </td>
        </tr>
    </table>
    <asp:Button ID="btn_tambah" runat="server" Text="Tambah" />
    <asp:Button ID="btn_batal" runat="server" Text="Batal" />
    </div>
    </form>
</body>
</html>
