using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("Api/[controller]")]
    public class ProductsController : ControllerBase
    {
        [HttpGet]
        public string GetProducts()
        {
            return "All Products";
        }

        [HttpGet("{id}")]
        public string GetProduct(int id)
        {
            return "Single Products";
        }
    }
}