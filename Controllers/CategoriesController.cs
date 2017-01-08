using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData;

namespace odataservicesample.Controllers
{

    public class Category {
        public int CategoryId {get; set;}
        public string CategoryName {get;set;}
        public string Description {get;set;}
    }

    public interface ICategoryService{
        IEnumerable<Category> Categories {get;}
    }

    [Route("api/[controller]")]
    [EnableQuery]
    public class CategoriesController : Controller
    {
        private static List<Category> _categories = new List<Category>{
            new Category(){CategoryId=1, CategoryName="Beverages",Description="Drinks"},
            new Category(){CategoryId=1, CategoryName="Condiments",Description="Sweets"},
            new Category(){CategoryId=1, CategoryName="Confectionaries",Description="Desserts"}
        };
        
        // GET api/values
        [HttpGet]
        public IEnumerable<Category> Get()
        {
            return _categories;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
