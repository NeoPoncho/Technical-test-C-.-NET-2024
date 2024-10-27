using Microsoft.AspNetCore.Mvc;
using RESTful_API.Models;

namespace RESTful_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductManager : ControllerBase
    {
        //this code was tested using postman and swagger UI

        private static readonly List<Product> products =
        [
            //adds elements to the list using the Product entity and it's properties

            new() { ID = 1, Name = "Smartphone", Price = 699.99 },
            new() { ID = 2, Name = "PC", Price = 1199.99 },
            new() { ID = 3, Name = "Tablet", Price = 749.99 },
            new() { ID = 4, Name = "TV", Price = 499.99 },
            new() { ID = 5, Name = "Gaming Console", Price = 699.99 }
        ];

        [HttpGet]
        public ActionResult<IEnumerable<Product>> GetProducts()
        {
            //returns a list of all the products

            return products;
        }

        [HttpGet("{id}")]
        public ActionResult<Product> GetProduct(int id)
        {
            //returns a product by it's ID

            var product = products.FirstOrDefault(p => p.ID == id);

            if (product == null)
            {
                return NotFound();
            }

            return product;
        }

        [HttpPost]
        public ActionResult<Product> CreateProduct(Product product)
        {
            //adds a new product using Product entity and inserts it to the list

            product.ID = products.Count > 0 ? products.Max(p => p.ID) + 1 : 1;
            products.Add(product);

            return CreatedAtAction(nameof(GetProduct), new { id = product.ID }, product);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateProduct(int id, Product updatedProduct)
        {
            //updates a product that's already on the list

            var product = products.FirstOrDefault(p => p.ID == id);

            if (product == null)
            {
                return NotFound();
            }

            product.Name = updatedProduct.Name;
            product.Price = updatedProduct.Price;

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteProduct(int id)
        {
            //deletes a product by it's ID

            var product = products.FirstOrDefault(p => p.ID == id);

            if (product == null)
            {
                return NotFound();
            }

            products.Remove(product);

            return NoContent();
        }
    }
}