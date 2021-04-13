using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/Products")]
    public class ProductsController : ControllerBase
    {
        [HttpGet]
        public string GetProducts()
        {
            return "this will be a list of products";
        }
        
        [HttpGet("{id}")]
        public string GetProducts(int id)
        {
            return "single product by id";
        }
    }
}