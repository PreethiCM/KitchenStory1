using System;
using System.Web.UI.WebControls;

namespace KitchenStory
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Load default content
            }
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            string searchTerm = txtSearch.Text;

            // Perform search based on searchTerm
            // Implement your search logic here and bind the search results to GridView

            // For demonstration purpose, I'm binding sample data
            BindSearchResults();
        }

        private void BindSearchResults()
        {
            // Sample data for demonstration
            var searchResults = new[]
            {
                new { ID = 1, Name = "Apple", Price = 1.99 },
                new { ID = 2, Name = "Banana", Price = 0.99 },
                new { ID = 3, Name = "Orange", Price = 2.49 }
            };

            GridViewSearchResults.DataSource = searchResults;
            GridViewSearchResults.DataBind();
        }
    }
}
