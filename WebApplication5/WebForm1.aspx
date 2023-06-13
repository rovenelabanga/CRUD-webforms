<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication5.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server" >
        <div>
            <table align="center">
                <tr>
                    <td>ID:</td>
                    <td>
                        <asp:TextBox ID="txtID" runat="server"></asp:TextBox></td>
                </tr>
                 <tr>
                    <td>Name:</td>
                    <td>
                        <asp:TextBox ID="txtName" runat="server"></asp:TextBox></td>
                </tr>
                 <tr>
                    <td>Phone:</td>
                    <td>
                        <asp:TextBox ID="txtPhone" runat="server"></asp:TextBox></td>
                </tr>
                 <tr>
                    <td>Adress:</td>
                    <td>
                        <asp:TextBox ID="txtAdress" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td align="center" colspan="2">
                        <asp:Button ID="btnInsert" runat="server" Text="Insert" OnClick="btnInsert_Click" />
                        <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" />
                        <asp:Button ID="btnUpdate" runat="server" Text="Update" OnClick="btnUpdate_Click" style="height: 35px" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
