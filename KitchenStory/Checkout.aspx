<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Checkout.aspx.cs" Inherits="KitchenStory.Checkout" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Checkout - Kitchen Story</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Checkout</h2>
            <div>
                <h3>Selected Items</h3>
                <asp:GridView ID="GridViewSelectedItems" runat="server" AutoGenerateColumns="False">
                    <Columns>
                        <asp:BoundField DataField="ID" HeaderText="ID" />
                        <asp:BoundField DataField="Name" HeaderText="Name" />
                        <asp:BoundField DataField="Price" HeaderText="Price" />
                    </Columns>
                </asp:GridView>
            </div>
            <div>
                <h3>Total Price</h3>
                <asp:Label ID="lblTotalPrice" runat="server" Text=""></asp:Label>
            </div>
            <div>
                <h3>Payment Gateway</h3>
                <!-- Add payment gateway options here -->
                <asp:DropDownList ID="ddlPaymentGateway" runat="server">
                    <asp:ListItem Text="PayPal" Value="PayPal"></asp:ListItem>
                    <asp:ListItem Text="Stripe" Value="Stripe"></asp:ListItem>
                    <!-- Add more payment gateway options as needed -->
                </asp:DropDownList>
            </div>
            <div>
                <asp:Button ID="btnConfirmPayment" runat="server" Text="Confirm Payment" OnClick="btnConfirmPayment_Click" />
            </div>
        </div>
    </form>
</body>
</html>
