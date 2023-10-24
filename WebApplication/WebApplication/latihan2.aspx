<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="latihan2.aspx.vb" Inherits="WebApplication.latihan2" %>
<%@ Register Assembly="SlimeeLibrary" Namespace="SlimeeLibrary" TagPrefix="cc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table>
            <tr style="text-align:center;">
                <td colspan="6">DATA MAHASISWA</td>
            </tr>
            <tr>
                <td colspan="6">&nbsp;</td>
            </tr>
            <tr>
                <td>NPM</td>
                <td>:</td>
                <td colspan="4"><asp:TextBox ID="txtNPM" runat="server" Width="100px"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Nama</td>
                <td>:</td>
                <td colspan="4"><asp:TextBox ID="txtNama" runat="server" Width="480px"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Tanggal Lahir</td>
                <td>:</td>
                <td>
x                    <cc1:DatePicker ID="dtTglLahir" runat="server" Width="80px" PaneWidth="150px" EnableViewState="true">
                        <PaneTableStyle BorderColor="#707070" BorderWidth="1px" BorderStyle="Solid" />
                        <PaneHeaderStyle BackColor="#0099FF" />
                        <TitleStyle ForeColor="White" Font-Bold="true" />
                        <NextPrevMonthStyle ForeColor="White" FontBold="true" />
                        <NextPrevYearStyle ForeColor="#E0E0E0" FontBold="true" />
                        <DayHeaderStyle BackColor="#E8E8E8" />
                        <TodayStyle BackColor="#FFFFCC" ForeColor="#000000" Font-Underline="false" BorderColor="#FFCC99"/>
                        <AlternateMonthStyle BackColor="#F0F0F0" ForeColor="#707070" Font-Underline="false"/>
                        <MonthStyle BackColor="" ForeColor="#000000" FontUnderline="false"/>
                    </cc1:DatePicker>
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
