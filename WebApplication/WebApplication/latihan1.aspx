<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="latihan1.aspx.vb" Inherits="WebApplication._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h3>ASP WEB APLICATION</h3>
        
        <table>
            <tr>
                <td>NPM</td>
                <td>:</td>
                <td><asp:TextBox runat="server" ID="txtNPM"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Nama</td>
                <td>:</td>
                <td><asp:TextBox runat="server" ID="txtNama"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Jurusan</td>
                <td>:</td>
                <td><asp:TextBox runat="server" ID="txtJurusan"></asp:TextBox></td>
            </tr>
        </table>
        
        
    </div>
    </form>
</body>
</html>
