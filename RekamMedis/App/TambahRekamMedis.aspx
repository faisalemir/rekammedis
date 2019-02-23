<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="TambahRekamMedis.aspx.vb" Inherits="RekamMedis.TambahRekamMedis" %>

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
        #form1 div {
            display:inline-block;
            vertical-align:top;
        }

        #tbx_anamnesia {
            resize:vertical;
        }

        #bul_obat, #bul_terapi{
            margin: 0px 0px 0px 20px;
            padding: 0px;
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
        <br />
    <div>
        <table style="width: 359px">
            <tr>
                <td>ID Rekam Medis</td>
                <td>:</td>
                <td>
                    <asp:TextBox ID="tbx_idrm" runat="server" Width="170px"></asp:TextBox>
                    <asp:Button ID="btn_cek" runat="server" Text="Cek" />
                </td>
            </tr>
            <tr>
                <td>ID Pasien</td>
                <td>:</td>
                <td>
                    <asp:TextBox ID="tbx_idpasien" runat="server" Width="170px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>ID Registrasi</td>
                <td>:</td>
                <td>
                    <asp:TextBox ID="tbx_idreg" runat="server" Width="170px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Kondisi</td>
                <td>:</td>
                <td>
                    <asp:DropDownList ID="ddl_kondisi" runat="server" Height="25px" Width="176px"></asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>Stole / Diastole</td>
                <td>:</td>
                <td>
                    <asp:TextBox ID="tbx_stole" runat="server" Width="170px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Respiratory Rate</td>
                <td>:</td>
                <td>
                    <asp:TextBox ID="tbx_respirate" runat="server" Width="170px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Suhu</td>
                <td>:</td>
                <td>
                    <asp:TextBox ID="tbx_suhu" runat="server" Width="170px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Nadi</td>
                <td>:</td>
                <td>
                    <asp:TextBox ID="tbx_nadi" runat="server" Width="170px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Berat Badan</td>
                <td>:</td>
                <td>
                    <asp:TextBox ID="tbx_berat" runat="server" Width="170px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Tinggi Badan</td>
                <td>:</td>
                <td>
                    <asp:TextBox ID="tbx_tinggi" runat="server" Width="170px"></asp:TextBox>
                </td>
            </tr>
            <tr style="vertical-align:top;">
                <td>Anamnesia</td>
                <td>:</td>
                <td>
                    <asp:TextBox ID="tbx_anamnesia" runat="server" TextMode="MultiLine" Height="87px" Width="170px"></asp:TextBox>
                </td>
            </tr>
            <tr style="vertical-align:top;">
                <td>Daftar Obat</td>
                <td>:</td>
                <td>
                    <asp:BulletedList ID="bul_obat" runat="server" ></asp:BulletedList>
                </td>
            </tr>
            <tr style="vertical-align:top;">
                <td>Daftar Terapi</td>
                <td>:</td>
                <td>
                    <asp:BulletedList ID="bul_terapi" runat="server"></asp:BulletedList>
                </td>
            </tr>
        </table>
        <asp:Button ID="btn_selesai" runat="server" Text="Selesai" />
    </div>
    <div runat="server" id="div_obat">
        Tambah Daftar Obat<br />
        <asp:TextBox ID="tbx_obat" runat="server" Width="177px"></asp:TextBox>
        <asp:Button ID="btn_obat" runat="server" Text="Cari" />
        <br />
        <asp:GridView ID="gdv_obat" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" EnableModelValidation="True" ForeColor="Black" GridLines="Horizontal" Width="380px">
            <Columns>
                <asp:BoundField DataField="id_obat" HeaderText="ID Obat" HeaderStyle-Width="200px">
                <HeaderStyle Width="100px"></HeaderStyle>
                </asp:BoundField>
                <asp:BoundField DataField="nama" HeaderText="Nama Obat" >
                <HeaderStyle Width="200px" />
                </asp:BoundField>
                <asp:TemplateField HeaderText="Jumlah">
                    <ItemTemplate>
                        <asp:TextBox ID="tbx_jumlah" Width="40px" runat="server"></asp:TextBox>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:ButtonField CommandName="tambah_obat" Text="Tambah" />
            </Columns>
            <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
            <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
            <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
        </asp:GridView>
    </div>
    <div runat="server" id="div_terapi">
        Tambah Daftar Terapi<br />
        <asp:TextBox ID="tbx_terapi" runat="server" Width="177px"></asp:TextBox>
        <asp:Button ID="btn_terapi" runat="server" Text="Cari" />
        <br />
        <asp:GridView ID="gdv_terapi" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" EnableModelValidation="True" ForeColor="Black" GridLines="Horizontal" Width="380px">
            <Columns>
                <asp:BoundField DataField="id_terapi" HeaderText="ID Terapi" HeaderStyle-Width="200px">
                <HeaderStyle Width="100px"></HeaderStyle>
                </asp:BoundField>
                <asp:BoundField DataField="terapi" HeaderText="Nama Terapi" >
                <HeaderStyle Width="200px" />
                </asp:BoundField>
                <asp:ButtonField CommandName="tambah_terapi" Text="Tambah" />
            </Columns>
            <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
            <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
            <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
        </asp:GridView>
    </div>
    </form>
</body>
</html>
