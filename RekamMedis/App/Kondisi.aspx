<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Kondisi.aspx.vb" Inherits="RekamMedis.Kondisi" %>

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
    <h1>Daftar Kondisi</h1>
    <asp:Panel ID="pnl_cari" runat="server" Visible="true">
        <asp:TextBox ID="tbx_cari" runat="server"></asp:TextBox>
        <asp:Button ID="btn_cari" runat="server" Text="Search" Height="26px" />
        <asp:Button ID="btn_tambah" runat="server" Text="Tambah" />
    </asp:Panel>
    <asp:Panel ID="pnl_sunting" runat="server" Visible="false">
        <asp:TextBox ID="tbx_sunting" runat="server"></asp:TextBox>
        <asp:Button ID="btn_sunting" runat="server" Text="Sunting" Height="26px" />
        <asp:Button ID="btn_batal" runat="server" Text="Batal" Height="26px" />
        <asp:Label ID="lbl_id" runat="server" Visible="false"></asp:Label>
    </asp:Panel>
    <asp:GridView ID="gdv_kondisi" runat="server" AutoGenerateColumns="False" CellPadding="4" EnableModelValidation="True" ForeColor="#333333" GridLines="None">
        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
        <Columns>
            <asp:BoundField DataField="id_kondisi" HeaderText="ID" />
            <asp:BoundField DataField="kondisi" HeaderText="Kondisi" />
            <asp:ButtonField ButtonType="Button" CommandName="sunting" Text="Sunting" />
            <asp:ButtonField ButtonType="Button" CommandName="hapus" Text="Hapus" />
        </Columns>
        <EditRowStyle BackColor="#999999" />
        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
    </asp:GridView>
    </div>
    </form>
</body>
</html>
