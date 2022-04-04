<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="read.aspx.cs" Inherits="demo.read"%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            ชื่อ:
            <asp:Label ID="showName" runat="server" Text="Label"></asp:Label>
            <br />
            นามสกุล:
            <asp:Label ID="showLastname" runat="server" Text="Label"></asp:Label>
        </div>
    </form>
</body>
</html>
