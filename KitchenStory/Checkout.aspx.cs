using System;
using System.Web.UI.WebControls;

namespace KitchenStory
{
    public partial class Checkout : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Retrieve selected items from session or database
                // For demonstration purpose, I'm binding sample data
                BindSelectedItems();
                CalculateTotalPrice();
            }
        }

        private void BindSelectedItems()
        {
            // Sample data for demonstration
            var selectedItems = new[]
            {
                new { ID = 1, Name = "Apple", Price = 1.99 },
                new { ID = 2, Name = "Banana", Price = 0.99 }
            };

            GridViewSelectedItems.DataSource = selectedItems;
            GridViewSelectedItems.DataBind();
        }

        private void CalculateTotalPrice()
        {
            // Calculate total price of selected items
            double totalPrice = 0;

            foreach (GridViewRow row in GridViewSelectedItems.Rows)
            {
                double price = Convert.ToDouble(row.Cells[2].Text);
                totalPrice += price;
            }

            lblTotalPrice.Text = $"Total Price: ${totalPrice:F2}";
        }

        protected void btnConfirmPayment_Click(object sender, EventArgs e)
        {
            // Implement payment processing logic based on selected payment gateway
            string selectedPaymentGateway = ddlPaymentGateway.SelectedValue;

            // Redirect to payment gateway for processing payment
            // For demonstration purpose, let's just display a confirmation message
            Response.Write("<script>alert('Payment confirmed. Thank you for shopping with us!')</script>");
        }
    }
}
