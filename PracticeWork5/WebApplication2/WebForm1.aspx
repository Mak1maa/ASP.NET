<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            СЛОЖЕНИЕ:<br />
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
&nbsp;<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
&nbsp;<asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="ENTER" />
&nbsp;<asp:Label ID="Label1" runat="server"></asp:Label>
            <br />
            <br />
            ВЫЧИТАНИЕ:<br />
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
&nbsp;<asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
&nbsp;<asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="ENTER" />
&nbsp;<asp:Label ID="Label2" runat="server"></asp:Label>
            <br />
            <br />
            ДЕЛЕНИЕ:<br />
            <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
&nbsp;<asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
&nbsp;<asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="ENTER" />
&nbsp;<asp:Label ID="Label3" runat="server"></asp:Label>
            <br />
            <br />
            УМНОЖЕНИЕ:<br />
            <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
&nbsp;<asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
&nbsp;<asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="ENTER" />
&nbsp;<asp:Label ID="Label4" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
