﻿<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="pgeLogin.aspx.vb" Inherits="inventory.pgeLogin" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>STMIK Insan Pembangunan</title>
</head>
<body>
        
    <form id="form1" runat="server">
        <div style="width:1000px; height:600px; margin:auto; padding-bottom:10px; " >
        <div style="width:980px; height:160px; background-color:silver; margin:auto; padding-left:10px; padding-right:10px; margin-bottom:10px; padding-top:10px;" >
            <img src="logoip.jpg" width="980" height ="150" alt =""/>
        </div>
        <div style="width:980px; height:330px; background-color:silver; margin:auto; padding-left:10px; padding-right:10px; padding-top:100px; " >
        <div style="width:300px; height:150px; background-color:white; margin:auto; padding-left:10px; " >

            <table >
                <tr>
                    <td colspan="3" style="font-size:xx-large; " >Login Security</td>
                </tr>
                <tr>
                    <td colspan="3" >&nbsp;</td>
                </tr>
                <tr>
                    <td style="font-size:large;" >User Name</td>
                    <td style="width:15px;" >&nbsp;</td>
                    <td><asp:TextBox ID="txtUser" runat="server" Width="177"></asp:TextBox></td>
                </tr>
                <tr>
                    <td style="font-size:large;">Password</td>
                    <td style="width:15px;" >&nbsp;</td>
                    <td><asp:TextBox ID="txtPass" runat="server" TextMode="Password" Width="177" ></asp:TextBox></td>
                </tr>
                <tr>
                    <td>&nbsp</td>
                    <td style="width:15px;" >&nbsp;</td>
                    <td>
                        <asp:Button ID="btnLogin" runat="server" Text="Login" Width="90" Height="25" />
                        <asp:Button ID="btnClear" runat="server" Text="Clear" Width="90" Height="25" />
                    </td>
                </tr>
            </table>
        </div>
        </div>
        </div>
      </form>
      
</body>
</html>
