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
                <td>Nama Karyawan</td>
                <td colspan="4"><asp:TextBox ID="txtNama" Width="100%" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Bagian</td>
                <td colspan="4"><asp:TextBox ID="txtBagian" Width="100%" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Jabatan</td>
                <td colspan="4"><asp:TextBox ID="txtJabatan" Width="100%"  runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Status Karyawan</td>
                <td>
                    <asp:RadioButton ID="radioKontrak" Text="Kontrak" GroupName="status" runat="server" />
                    <asp:RadioButton ID="radioTetap" Text="Tetap" GroupName="status" runat="server" />
                </td>
                <td style="width:55%"></td>
                <td>Gaji Pokok</td>
                <td><asp:TextBox ID="txtGajiPokok" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Tunjangan</td>
                <td><asp:TextBox ID="txtTunjangan" runat="server"></asp:TextBox></td>
                <td></td>
                <td>Pajak PPh 21</td>
                <td><asp:TextBox ID="txtPajak" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Gaji Bersih</td>
                <td><asp:TextBox ID="txtGajiBersih" runat="server"></asp:TextBox></td>
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
