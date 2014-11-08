<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentView.aspx.cs" Inherits="StudentManagementApp_WebForm.UI.StudentView" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table>
            <tr>
                <td>
                    Reg No
                </td>
                <td>
                    <asp:DropDownList runat="server" ID="regNoDropDownList" />
                </td>

            </tr>
            <tr>
                <td>
                    <asp:Button runat="server" ID="showButton" Text="Show" OnClick="showButton_OnClick"/>
                </td>

            </tr>
            <tr>
                <td>
                    Name
                </td>
                <td>
                    <asp:Label runat="server" ID="nameLabel"></asp:Label>
                </td>

            </tr>
             <tr>
                <td>
                    Email
                </td>
                <td>
                    <asp:Label runat="server" ID="emailLabel"></asp:Label>
                </td>

            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
