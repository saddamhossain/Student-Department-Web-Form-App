<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentEntry.aspx.cs" Inherits="StudentManagementApp_WebForm.UI.StudentEntry" %>

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
                Dept.
            </td>
            <td>              
                <asp:DropDownList runat="server" ID="txtdropdown" />
            </td>
        </tr>
        <tr>
            <td>
                Reg No.
            </td>
            <td>
                <asp:TextBox runat="server" ID="txtRegNo" ></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                Name
            </td>
            <td>
                <asp:TextBox runat="server" ID="txtName" ></asp:TextBox>
            </td>
        </tr>
         <tr>
            <td>
                Email
            </td>
            <td>
                <asp:TextBox runat="server" ID="txtEmail" ></asp:TextBox>
            </td>
        </tr>
        
        <tr>
            <td> <asp:Button runat="server" ID="btnSave" OnClick="btnSave_OnClick" Text="Insert"/></td>
        </tr>
        
        <tr>
            <td>
                <asp:Label runat="server" ID="msgLabel" Text=""></asp:Label>
            </td>
        </tr>
    </table>
    </div>
    </form>
</body>
</html>
