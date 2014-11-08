<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DepartmentEntry.aspx.cs" Inherits="StudentManagementApp_WebForm.UI.DepartmentEntry" %>

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
                Code
            </td>
            <td>
                <asp:TextBox runat="server" ID="txtcode" ></asp:TextBox>
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
            <td> <asp:Button runat="server" ID="btnSave" OnClick="deptSave_OnClick" Text="Insert"/></td>
        </tr>
        
        <tr>
            <td align="center">
                <asp:Label runat="server" ID="msgLabel" Text=""></asp:Label>
            </td>
        </tr>

        </table>
    </div>
    </form>
</body>
</html>
