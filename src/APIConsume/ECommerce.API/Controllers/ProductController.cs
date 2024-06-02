using ECommerce.BusinessLayer.Abstract;
using ECommerce.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        private readonly IWebHostEnvironment _webHostEnvironment;
        public ProductController(IProductService productService, IWebHostEnvironment webHostEnvironment)
        {
            _productService = productService;
            _webHostEnvironment = webHostEnvironment;

        }
        //---------------------------------------------------------
        [HttpGet]
        public IActionResult ProductList()
        {
            try
            {
                var values = _productService.GetAll();
                return Ok(values);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }

        }    
        //---------------------------------------------------------
        [HttpPost]
        public IActionResult AddProduct(Product product)
        {
            try
            {
                _productService.Add(product);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
        //---------------------------------------------------------
        [HttpPut]
        public IActionResult UpdateProduct(Product product)
        {
            try
            {
                _productService.Update(product);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
        //---------------------------------------------------------
        [HttpDelete("DeleteProduct/{id}")]
        public IActionResult DeleteProduct(int id)
        {
            try
            {
                var values = _productService.GetById(id);
                _productService.Destroy(values);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
        //---------------------------------------------------------
        [HttpDelete("DeletedStatusProduct/{id}")]
        public IActionResult DeletedStatusProduct(int id)
        {
            try
            {
                var values = _productService.GetById(id);
                _productService.Delete(values);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }

        }
        
        //---------------------------------------------------------
        [HttpGet("GetActiveProduct/{id}")]
        public IActionResult GetActiveProduct(int id)
        {
            try
            {
                var values = _productService.GetById(id);
                _productService.GetActive(values);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}
