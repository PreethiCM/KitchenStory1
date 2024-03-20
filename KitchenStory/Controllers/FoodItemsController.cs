using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;

namespace KitchenStory.Controllers
{
    [EnableCors(origins:"*",headers: "*",methods: "*")]
    public class FoodItemsController : ApiController
    {
        private readonly List<FoodItem> _foodItems = new List<FoodItem>();

        // GET api/FoodItems
        public IEnumerable<FoodItem> Get()
        {
            return _foodItems;
        }

        // POST api/FoodItems
        public IHttpActionResult Post(FoodItem foodItem)
        {
            _foodItems.Add(foodItem);
            return Ok();
        }

        // PUT api/FoodItems/5
        public IHttpActionResult Put(int id, FoodItem foodItem)
        {
            var existingFoodItem = _foodItems.FirstOrDefault(fi => fi.ID == id);
            if (existingFoodItem == null)
                return NotFound();

            existingFoodItem.Name = foodItem.Name;
            existingFoodItem.Price = foodItem.Price;
            return Ok();
        }

        // DELETE api/FoodItems/5
        public IHttpActionResult Delete(int id)
        {
            var existingFoodItem = _foodItems.FirstOrDefault(fi => fi.ID == id);
            if (existingFoodItem == null)
                return NotFound();

            _foodItems.Remove(existingFoodItem);
            return Ok();
        }
    }
}
