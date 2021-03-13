<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ShowInfo.aspx.cs" Inherits="PracticeWork3.ShowInfo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" Text="Заказчики:"></asp:Label>
        <br />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" AutoGenerateSelectButton="True" DataKeyNames="Id" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:BoundField DataField="Id" HeaderText="Номер" InsertVisible="False" ReadOnly="True" SortExpression="Id" />
                <asp:BoundField DataField="Name" HeaderText="Имя" SortExpression="Name" />
                <asp:BoundField DataField="Surname" HeaderText="Фамилия" SortExpression="Surname" />
                <asp:BoundField DataField="Birthday" HeaderText="Год рождения" SortExpression="Birthday" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:TradeCompanyBDConnectionString %>" DeleteCommand="DELETE FROM Customers WHERE ID = @ID" InsertCommand="INSERT INTO Customers (Name, Surname, Birthday) VALUES (@Name, @Surname, @Birthday)" OnSelecting="SqlDataSource1_Selecting" ProviderName="<%$ ConnectionStrings:TradeCompanyBDConnectionString.ProviderName %>" SelectCommand="SELECT * FROM [Customers]" UpdateCommand="UPDATE Customers SET Name = @Name, Surname = @Surname, Birthday = @Birthday WHERE ID = @ID">
            <DeleteParameters>
                <asp:ControlParameter ControlID="GridView1" Name="ID" PropertyName="SelectedValue" />
            </DeleteParameters>
            <InsertParameters>
                <asp:ControlParameter ControlID="GridView2" Name="ID" PropertyName="SelectedValue" />
                <asp:ControlParameter ControlID="TextBox4" Name="Name" PropertyName="Text" />
                <asp:ControlParameter ControlID="TextBox5" Name="Surname" PropertyName="Text" />
                <asp:ControlParameter ControlID="TextBox6" Name="Birthday" PropertyName="Text" />
            </InsertParameters>
            <UpdateParameters>
                <asp:ControlParameter ControlID="GridView1" Name="Name" PropertyName="SelectedValue" />
                <asp:ControlParameter ControlID="GridView1" Name="Surname" PropertyName="SelectedValue" />
                <asp:ControlParameter ControlID="GridView1" Name="Birthday" PropertyName="SelectedValue" />
                <asp:ControlParameter ControlID="GridView1" Name="ID" PropertyName="SelectedValue" />
            </UpdateParameters>
        </asp:SqlDataSource>
        <br />
        <asp:Button ID="Button6" runat="server" OnClick="Button6_Click" Text="Добавить заказчика" />
        <asp:Button ID="Button7" runat="server" OnClick="Button7_Click" Text="Редактировать заказчика" />
        <asp:Button ID="Button8" runat="server" OnClick="Button8_Click" Text="Удалить заказчика" />
        <br />
        <br />
        <asp:Panel ID="Panel2" runat="server" Visible="False">
            Имя:
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            <br />
            Фамилия:
            <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
            <br />
            Год рождения:
            <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button9" runat="server" OnClick="Button9_Click" Text="Добавить" />
            <asp:Button ID="Button10" runat="server" OnClick="Button10_Click" Text="Отменить" />
        </asp:Panel>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Заказы:"></asp:Label>
        <br />
        <div>
            <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" DataKeyNames="Id" DataSourceID="SqlDataSource2">
                <Columns>
                    <asp:BoundField DataField="Id" HeaderText="Номер" InsertVisible="False" ReadOnly="True" SortExpression="Id" />
                    <asp:BoundField DataField="ID_CUST" HeaderText="Номер заказчика" ReadOnly="True" SortExpression="ID_CUST" />
                    <asp:BoundField DataField="Title" HeaderText="Название товара" SortExpression="Title" />
                    <asp:BoundField DataField="Price" HeaderText="Цена" SortExpression="Price" />
                    <asp:BoundField DataField="Quant" HeaderText="Количество" SortExpression="Quant" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:TradeCompanyBDConnectionString %>" DeleteCommand="DELETE FROM Orders WHERE ID = @ID" InsertCommand="INSERT INTO Orders (ID_CUST, Title, Price, Quant) VALUES (@ID_CUST, @Title, @Price, @Quant)" SelectCommand="SELECT * FROM [Orders] WHERE ([ID_CUST] = @ID_CUST)" UpdateCommand="UPDATE Orders SET ID_CUST = @ID_CUST, Title = @Title, Price = @Price, Quant = @Quant WHERE ID = @ID">
                <DeleteParameters>
                    <asp:ControlParameter ControlID="GridView2" Name="ID" PropertyName="SelectedValue" />
                </DeleteParameters>
                <InsertParameters>
                    <asp:ControlParameter ControlID="GridView1" Name="ID_CUST" PropertyName="SelectedValue" />
                    <asp:ControlParameter ControlID="TextBox1" Name="Title" PropertyName="Text" />
                    <asp:ControlParameter ControlID="TextBox2" Name="Price" PropertyName="Text" />
                    <asp:ControlParameter ControlID="TextBox3" Name="Quant" PropertyName="Text" />
                </InsertParameters>
                <SelectParameters>
                    <asp:ControlParameter ControlID="GridView1" Name="ID_CUST" PropertyName="SelectedValue" Type="Int32" />
                </SelectParameters>
                <UpdateParameters>
                    <asp:ControlParameter ControlID="GridView1" Name="ID_CUST" PropertyName="SelectedValue" />
                    <asp:ControlParameter ControlID="GridView2" Name="Title" PropertyName="SelectedValue" />
                    <asp:ControlParameter ControlID="GridView2" Name="Price" PropertyName="SelectedValue" />
                    <asp:ControlParameter ControlID="GridView2" Name="Quant" PropertyName="SelectedValue" />
                    <asp:ControlParameter ControlID="GridView2" Name="ID" PropertyName="SelectedValue" />
                </UpdateParameters>
            </asp:SqlDataSource>
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Добавить заказ" />
            <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Редактировать заказы" />
            <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="Удалить заказ" />
            <br />
            <br />
            <asp:Panel ID="Panel1" runat="server" Visible="False">
                Название товара:
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                <br />
                Цена:
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                <br />
                Количество:
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                <br />
                <br />
                <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Добавить" />
                <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Отменить" />
            </asp:Panel>
        </div>
    </form>
</body>
</html>
