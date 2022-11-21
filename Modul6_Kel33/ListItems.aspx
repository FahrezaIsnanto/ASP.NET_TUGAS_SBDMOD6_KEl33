<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListItems.aspx.cs" Inherits="Modul6_Kel33.ListItems" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
       <div class="row">
          <div style="width: 40%; float: left;" class="left">
              <h1>Form untuk mahasiswa</h1>
              <table>
                <tr>
                  <td>NIM :</td>
                  <td>
                    <asp:TextBox ID="txtNimMhs" runat="server"></asp:TextBox>
                  </td>
                </tr>
                <tr>
                  <td>Nama :</td>
                  <td>
                    <asp:TextBox ID="txtNamaMhs" runat="server"></asp:TextBox>
                  </td>
                </tr>
                <tr>
                  <td>Alamat :</td>
                  <td>
                    <asp:TextBox ID="txtAlamatMhs" runat="server"></asp:TextBox>
                  </td>
                </tr>
                <tr>
                  <td>Hobi :</td>
                  <td>
                    <asp:TextBox ID="txtHobiMhs" runat="server"></asp:TextBox>
                  </td>
                </tr>
                <tr>
                  <td>ID Jurusan :</td>
                  <td>
                    <asp:TextBox ID="txtIdJurusanMhs" runat="server"></asp:TextBox>
                  </td>
                </tr>
                <tr>
                  <td></td>
                  <td>
                    <asp:Button
                      ID="btnAddMhs"
                      runat="server"
                      Text="ADD"
                      OnClick="btnAddMhs_Click"
                    />
                    <asp:Button
                      ID="btnDeleteMhs"
                      runat="server"
                      Text="DELETE"
                      OnClick="btnDeleteMhs_Click"
                    />
                    <asp:Button
                      ID="btnUpdateMhs"
                      runat="server"
                      Text="UPDATE"
                      OnClick="btnUpdateMhs_Click"
                    />
                   <asp:Button
                      ID="btnClearMhs"
                      runat="server"
                      Text="CLEAR"
                      OnClick="btnClearMhs_Click"
                    />
                  </td>
                </tr>
              </table>
               <asp:GridView ID="GridViewMhs" runat="server">
                </asp:GridView>
        </div>
        <div style="width: 50%; float: right;" class="right">
            <h1>Form untuk jurusan</h1>
              <table>
                <tr>
                  <td>ID Jurusan :</td>
                  <td>
                    <asp:TextBox ID="txtIdJurusan" runat="server"></asp:TextBox>
                  </td>
                </tr>
                <tr>
                  <td>Nama Jurusan :</td>
                  <td>
                    <asp:TextBox ID="txtNamaJurusan" runat="server"></asp:TextBox>
                  </td>
                </tr>
                <tr>
                  <td></td>
                  <td>
                    <asp:Button
                      ID="btnAddJurusan"
                      runat="server"
                      Text="ADD"
                      OnClick="btnAddJurusan_Click"
                    />
                    <asp:Button
                      ID="btnDeleteJurusan"
                      runat="server"
                      Text="DELETE"
                      OnClick="btnDeleteJurusan_Click"
                    />
                    <asp:Button
                      ID="btnUpdateJurusan"
                      runat="server"
                      Text="UPDATE"
                      OnClick="btnUpdateJurusan_Click"
                    />
                   <asp:Button
                      ID="btnClearJurusan"
                      runat="server"
                      Text="CLEAR"
                      OnClick="btnClearJurusan_Click"
                    />
                  </td>
                </tr>
              </table>
               <asp:GridView ID="GridViewJurusan" runat="server">
                </asp:GridView>
        </div>
        <div style="clear: both"></div>
        </div>
        <div style="margin: 20px">
             <asp:GridView ID="GridViewJoin" runat="server">
                </asp:GridView>
        </div>
    </form>
</body>
</html>
