using Microsoft.AspNetCore.Mvc;
using Floristeria.Application.Contract; 
using System.Threading.Tasks;

namespace FloristeriaM.G.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")] 
    public class ProductController : ControllerBase
    {
        // Private field to hold the injected service instance
        private readonly IProductService _productService;

        //CONSTRUCTOR: The framework automatically injects the IProductService
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        // Endpoint for CREATING a Product
        [HttpPost]
        public async Task<IActionResult> CreateProduct([FromBody] object productDto) 
            
            return StatusCode(201, new { Message = "Product created successfully (Service placeholder)." });
        }
        
    }
}