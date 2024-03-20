<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="KitchenStory.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Kitchen Story - Home</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Welcome to Kitchen Story!</h2>
            <div>
                <label for="txtSearch">Search Food Items:</label>
                <asp:TextBox ID="txtSearch" runat="server"></asp:TextBox>
                <asp:Button ID="btnSearch" runat="server" Text="Search" OnClick="btnSearch_Click" />
            </div>
            <div>
                <!-- Display search results here -->
                <asp:GridView ID="GridViewSearchResults" runat="server" AutoGenerateColumns="False">
                    <Columns>
                        <asp:BoundField DataField="ID" HeaderText="ID" />
                        <asp:BoundField DataField="Name" HeaderText="Name" />
                        <asp:BoundField DataField="Price" HeaderText="Price" />
                    </Columns>
                </asp:GridView>
            </div>
        </div>
    </form>
</body>
</html>
