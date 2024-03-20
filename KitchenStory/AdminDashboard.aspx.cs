using System;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KitchenStory
{
    public partial class AdminDashboard : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Load food items into GridView
                BindFoodItems();
            }
        }

        private void BindFoodItems()
        {
            // Retrieve food items from database and bind to GridView
            // Implement this method based on your database access logic
        }

        protected void btnAddItem_Click(object sender, EventArgs e)
        {
            // Redirect to AddFoodItem.aspx for adding a new food item
            Response.Redirect("AddFoodItem.aspx");
        }

        protected void btnRemoveItem_Click(object sender, EventArgs e)
        {
            // Implement logic to remove selected food item from database
        }
    }
}
