<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="demo.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Hello world</title>
    <style type="text/css">
        #div1 {
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <!-- <div>
            ชื่อผู้ใช้: <asp:TextBox ID="txt_Name" runat="server"></asp:TextBox>
        </div>
        <p>
            รหัสผ่าน:
            <asp:TextBox ID="txt_Password" runat="server" TextMode="Password"></asp:TextBox>
        </p> -->
        <div id="div1" runat="server">
            <asp:Image ID="Image1" runat="server" Height="175px" ImageUrl="https://www.w3schools.com/w3css/img_lights.jpg" Width="235px" />
            <br />
            <asp:Label ID="txt_Result" runat="server" Text="Label"></asp:Label>
        </div>
        <div>
            ชื่อ:
            <asp:TextBox ID="txt_Number" runat="server"></asp:TextBox>
        </div>
        <div>
            นามสกุล:
            <asp:TextBox ID="txt_Surname" runat="server"></asp:TextBox>
        </div>
        <div>
            ชื่อสินค้า:<br />
            <asp:ListBox ID="ls_Product" runat="server" Height="159px" Width="233px" AutoPostBack="True" OnSelectedIndexChanged="ls_Product_SelectedIndexChanged">
                <asp:ListItem>Tablet</asp:ListItem>
                <asp:ListItem>iPhone</asp:ListItem>
                <asp:ListItem>Nokia</asp:ListItem>
                <asp:ListItem>Notebook</asp:ListItem>
            </asp:ListBox>
            <br />
            วันจัดส่ง<div>
                <asp:Calendar ID="control_calendar" runat="server" OnSelectionChanged="Calendar1_SelectionChanged"></asp:Calendar>
                <div>
                    วิธีจัดส่ง :<br />
                    <asp:DropDownList ID="DropDownList1" runat="server">
                        <asp:ListItem>จัดส่งแบบธรรมดา</asp:ListItem>
                        <asp:ListItem>จัดส่งแบบ EMS</asp:ListItem>
                    </asp:DropDownList>
                    <br />
                    การสนทนา :<br />
                    <asp:ListBox ID="lsChat" runat="server" Height="322px" Width="565px"></asp:ListBox>
                </div>
            </div>
        </div>
        <div>
            <asp:TextBox ID="txtMsg" runat="server" Width="494px"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="ส่ง" Width="62px" />
            <br />
            ชื่อผู้ใช้งาน:
            <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
        </div>
    </form>
</body>
</html>
