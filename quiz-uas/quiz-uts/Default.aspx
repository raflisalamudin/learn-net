<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Default.aspx.vb" Inherits="quiz_uts._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
        <style type="text/css">
         .style1
         {
         text-align: center;
         }
         .style2
         {
         font-family: "Courier New";
         font-size: small;
         color: #FFFFFF;
         }
    </style>

    <title>Joki with Apli</title>
</head>
<body>
    <form id="form1" runat="server">
    
    <div>
        <img src="logoip.jpg" style="display:block; margin:auto" width="770" height ="120" alt =""/>
    </div>
    
    <div style="background-color:gray">
    
        <h2 style="text-align:center; padding-top:20px">SOAL QUIZ<p>2019804265 | Ahmad Rafli Salamudin</h2>
        <hr />
        
        <center>
        <table>
            <tr>
                <td>No. Kendaraan</td>
                <td><asp:TextBox ID="txtNoKendaraan" runat="server"></asp:TextBox></td>                
            </tr>
            <tr>
                <td>Pemilik Kendaraan</td>
                <td colspan="4"><asp:TextBox ID="txtPemilik" Width="100%" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Nama Kendaraan</td>
                <td colspan="4"><asp:TextBox ID="txtNama" Width="100%" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Nomor Rangka</td>
                <td colspan="4"><asp:TextBox ID="txtNoRangka" Width="100%"  runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Warna Kendaraan</td>
                <td><asp:TextBox ID="txtWarna" runat="server"></asp:TextBox></td>
                <td style="width:50%"></td>
                <td>Jenis Kendaraan &nbsp;&nbsp;</td>
                <td>
                    <asp:RadioButton ID="radioRodaDua" Text="Roda Dua" GroupName="jenis" runat="server" />
                    <asp:RadioButton ID="radioRodaEmpat" Text="Roda Empat" GroupName="jenis" runat="server" />
                </td>
            </tr>
            <tr>
                <td>Tahun Pembuatan</td>
                <td><asp:TextBox ID="txtTahun" runat="server"></asp:TextBox></td>
                <td></td>
                <td>Harga Jual</td>
                <td><asp:TextBox ID="txtHarga" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>PPn</td>
                <td><asp:TextBox ID="txtPpn" runat="server"></asp:TextBox></td>
                <td></td>
                <td>Total Harga</td>
                <td><asp:TextBox ID="txtTotal" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td></td>
                <td>
                    <asp:Button ID="btnCalculate" runat="server" Text="Calculate" />&nbsp;
                    <asp:Button ID="btnSave" runat="server" Text="Save" />&nbsp;
                    <asp:Button ID="btnClear" runat="server" Text="Clear" />
                </td>
                <td></td>
                <td></td>
                <td></td>
            </tr>
        
        
        </table>
        </center>
        
         <div style="width:100%; height:40px; margin:auto; background:white; padding-top:5px;" class="style1" >
         <div style ="width:100%; height:30px; background:#333333; margin:auto; padding-top:5px; padding-bottom:5px;" >
         <span class="style2">Copyrights by Joki with Apli</span><br class="style2" />
         <span class="style2"><span class="style2">&copy; 2022 All Rights Reserved</span></span><span class="style2"> </span>

        
        
    
    </div>
    </form>
</body>
</html>
