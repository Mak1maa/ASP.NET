<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="WebUserControl1.ascx.cs" Inherits="PracticeWork5.WebUserControl1" %>
<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
<p>
    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
</p>
<p>
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="СЛОЖЕНИЕ" />
&nbsp;<asp:Button ID="Button2" runat="server" OnClick="Button2_Click1" Text="ВЫЧИТАНИЕ" />
&nbsp;<asp:Button ID="Button3" runat="server" OnClick="Button3_Click1" Text="ДЕЛЕНИЕ" />
&nbsp;<asp:Button ID="Button4" runat="server" OnClick="Button4_Click1" Text="УМНОЖЕНИЕ" />
</p>
<p>
    <asp:Label ID="Label1" runat="server"></asp:Label>
</p>

