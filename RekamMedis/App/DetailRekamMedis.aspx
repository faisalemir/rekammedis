<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="DetailRekamMedis.aspx.vb" Inherits="RekamMedis.DetailRekamMedis" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
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
    <h1>Rekam Medis</h1>
        <asp:GridView ID="gdv" runat="server" AutoGenerateColumns="False" CellPadding="4" EnableModelValidation="True" ForeColor="#333333" GridLines="None" >
            <AlternatingRowStyle BackColor="White" />
            <Columns>
            <asp:BoundField DataField="id_rm" HeaderText="ID RM"/>
                <asp:BoundField DataField="id_pasien" HeaderText="ID PASIEN" />
                <asp:BoundField DataField="id_reg" HeaderText="ID REG" />
                <asp:BoundField DataField="id_kondisi" HeaderText="KONDISI" />
                <asp:BoundField DataField="suhu" HeaderText="SUHU" /> 
                <asp:BoundField DataField="nadi" HeaderText="NADI" />
                <asp:BoundField DataField="anamnesia" HeaderText="ANAMNESIA" />
                <asp:BoundField DataField="pemeriksaan_fisik" HeaderText="PEMERIKSAAN" />
                <asp:BoundField DataField="stole_diastole" HeaderText="STOLE/DIASTOLE" />
                <asp:BoundField DataField="respiratory_rate" HeaderText="RESPIRATORY RATE" />
                <asp:BoundField DataField="berat_badan" HeaderText="BERAT BADAN" />
                <asp:BoundField DataField="tinggi_badan" HeaderText="TINGGI BADAN" />
                <asp:BoundField DataField="keadaan_umum" HeaderText="KEADAAN" />
                <asp:BoundField DataField="tanggal" HeaderText="TANGGAL" />
            </Columns>
            <EditRowStyle BackColor="#2461BF" />
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#EFF3FB" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
        </asp:GridView>
    </div>
    </form>
</body>
</html>
