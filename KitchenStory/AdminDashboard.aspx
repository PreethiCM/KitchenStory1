<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminDashboard.aspx.cs" Inherits="KitchenStory.AdminDashboard" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Admin Dashboard</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Admin Dashboard</h2>
            <asp:GridView ID="GridViewFoodItems" runat="server"></asp:GridView>
            <div>
                <asp:Button ID="btnAddItem" runat="server" Text="Add Food Item" OnClick="btnAddItem_Click" />
                <asp:Button ID="btnRemoveItem" runat="server" Text="Remove Food Item" OnClick="btnRemoveItem_Click" />
            </div>
        </div>
    </form>
</body>
</html>
