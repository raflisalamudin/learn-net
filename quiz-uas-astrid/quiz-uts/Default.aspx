<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Default.aspx.vb" Inherits="quiz_uts._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Astrid Monica Saputri 2020804185</title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="border:5px solid gray">
    
        <h2 style="text-align:center; padding-top:20px">SOAL QUIZ [2020804185]</h2>
        <hr />
        
        <center>
        <table>
            <tr>
                <td>NIK</td>
                <td><asp:TextBox ID="txtNik" runat="server"></asp:TextBox></td>                
            </tr>
            <tr>
                <td>Nama</td>
                <td colspan="6"><asp:TextBox ID="txtNama" Width="100%" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Departement</td>
                <td colspan="6"><asp:TextBox ID="txtDepartement" Width="100%" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Upah/Hari</td>
                <td><asp:TextBox ID="txtJabatan" Width="100%"  runat="server"></asp:TextBox></td>
                <td>&nbsp;</td>
                <td>Jumlah Hari Kerja</td>
                <td><asp:TextBox ID="TextBox1" Width="100%"  runat="server"></asp:TextBox></td>
                <td>Upah Pokok</td>
                <td><asp:TextBox ID="TextBox2" Width="100%"  runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Upah/Hari</td>
                <td><asp:TextBox ID="TextBox3" Width="100%"  runat="server"></asp:TextBox></td>
                <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</td>
                <td>Jumlah Lembur</td>
                <td><asp:TextBox ID="TextBox4" Width="100%"  runat="server"></asp:TextBox></td>
                <td>Upah Pokok</td>
                <td><asp:TextBox ID="TextBox5" Width="100%"  runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Tunjangan</td>
                <td><asp:TextBox ID="txtTunjangan" runat="server"></asp:TextBox></td>
                <td></td>
                <td>Pajak PPh 21</td>
                <td><asp:TextBox ID="txtPajak" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Gaji Pokok</td>
                <td><asp:TextBox ID="txtGajiBersih" runat="server"></asp:TextBox></td>
                <td></td>
                <td></td>
                <td></td>
            </tr>
            <tr>
                <td>Potongan Lain</td>
                <td><asp:TextBox ID="txtPotonganLain" runat="server"></asp:TextBox></td>
                <td></td>
                <td></td>
                <td></td>
            </tr>
            <tr>
                <td></td>
                <td>
                    <asp:Button ID="btnHitung" runat="server" Text="HITUNG" Width="48%" />
                    <asp:Button ID="btnClear" runat="server" Text="RESET" Width="48%" />
                </td>
                <td></td>
                <td></td>
                <td></td>
            </tr>
        
        
        </table>
        </center>
        
        
    
    </div>
    </form>
</body>
</html>
