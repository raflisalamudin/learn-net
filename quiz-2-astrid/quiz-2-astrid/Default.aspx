<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Default.aspx.vb" Inherits="quiz_2_astrid._Default" %>

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
                <td colspan="7"><asp:TextBox ID="txtNama" Width="100%" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Departement</td>
                <td colspan="7"><asp:TextBox ID="txtDepartement" Width="100%" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Upah/Hari</td>
                <td><asp:TextBox ID="txtUpahHari" runat="server"></asp:TextBox></td>
                <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</td>
                <td>Jumlah Hari Kerja</td>
                <td><asp:TextBox ID="txtJumlahHariKerja" runat="server"></asp:TextBox></td>
                <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</td>
                <td>Upah Pokok</td>
                <td><asp:TextBox ID="txtUpahPokok" Width="100%"  runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Upah/Jam</td>
                <td><asp:TextBox ID="txtUpahJam" runat="server"></asp:TextBox></td>
                <td></td>
                <td>Jumlah Lembur</td>
                <td><asp:TextBox ID="txtJumlahLembur" runat="server"></asp:TextBox></td>
                <td></td>
                <td>Upah Lembur</td>
                <td><asp:TextBox ID="txtUpahLembur" Width="100%" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Tunjangan</td>
                <td><asp:TextBox ID="txtTunjangan" runat="server"></asp:TextBox></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td>Jamsostek</td>
                <td><asp:TextBox ID="txtJamsostek" Width="100%"  runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Gaji Kotor</td>
                <td><asp:TextBox ID="txtGajiKotor" runat="server"></asp:TextBox></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td>Pajak</td>
                <td><asp:TextBox ID="txtPajak" Width="100%"  runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Potongan Lain</td>
                <td><asp:TextBox ID="txtPotonganLain" runat="server"></asp:TextBox></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td>Gaji Bersih</td>
                <td><asp:TextBox ID="txtGajiBersih" Width="100%"  runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td></td>
                <td colspan="6">
                    <asp:Button ID="btnHitung" runat="server" Text="HITUNG" Width="15%" />
                    <asp:Button ID="btnSimpan" runat="server" Text="SIMPAN" Width="15%" />
                    <asp:Button ID="btnUpdate" runat="server" Text="UPDATE" Width="15%" />
                    <asp:Button ID="btnDelete" runat="server" Text="DELETE" Width="15%" />
                    <asp:Button ID="btnReset" runat="server" Text="RESET" Width="15%" />
                </td>
            </tr>
            <tr>
                <td colspan="8">
                    <asp:GridView ID="grdList" runat="server" AutoGenerateColumns="False" 
                        DataKeyNames="NIK" DataSourceID="AccessDataSource2">
                       <Columns>
                            <asp:CommandField ShowSelectButton="true" HeaderText="SELECT" />
                            <asp:BoundField DataField="NIK" HeaderText="NIK" ReadOnly="True" 
                                SortExpression="NIK" />
                            <asp:BoundField DataField="NAMA" HeaderText="NAMA" SortExpression="NAMA" />
                            <asp:BoundField DataField="DEPARTEMENT" HeaderText="DEPARTEMENT" 
                                SortExpression="DEPARTEMENT" />
                            <asp:BoundField DataField="UPAH_HARI" HeaderText="UPAH/HARI" 
                                SortExpression="UPAH_HARI" />
                            <asp:BoundField DataField="JUMLAH_HARI_KERJA" HeaderText="JUMLAH HARI KERJA" 
                                SortExpression="JUMLAH_HARI_KERJA"/>
                            <asp:BoundField DataField="UPAH_POKOK" HeaderText="UPAH POKOK" 
                                SortExpression="UPAH_POKOK" />
                            <asp:BoundField DataField="UPAH_JAM" HeaderText="UPAH/JAM" 
                                SortExpression="UPAH_JAM"/>
                       </Columns>
                    </asp:GridView>
                    <asp:AccessDataSource ID="AccessDataSource2" runat="server" DataFile="~/db.mdb" 
                        SelectCommand="SELECT * FROM [TBL_PAYROLL]"></asp:AccessDataSource>
                    <asp:AccessDataSource ID="AccessDataSource1" runat="server">
                    </asp:AccessDataSource>
                </td>
            </tr>
        
        
        </table>
        </center>

        
    </div>
    </form>
</body>
</html>
