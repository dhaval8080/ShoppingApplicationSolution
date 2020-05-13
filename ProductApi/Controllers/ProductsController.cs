using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProductApi.model;
using ProductApi.Model;

namespace ProductApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductRepository _productRepository;

        public ProductsController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<Product> GetProducts()
        {
             return  _productRepository.GetAll();
            
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public Product GetProducts(int id)
        {
            Product p = _productRepository.GetOne(id);
            return p;
        }

        // POST api/<controller>
       // [Authorize]
        [HttpPost]
        public ActionResult PostProducts(Product products)
        {
            _productRepository.Add(products);
            _productRepository.SaveChanges();
            return Ok();
        }

        // PUT api/<controller>/5
      //  [Authorize]
        [HttpPut()]
        public IActionResult PutProducts(Product products)
        {
            Product p = _productRepository.GetOne(products);

            if (p != null)
            {
                p.Productname = products.Productname;
                p.Productdesciption = products.Productname;
                p.Quantity = products.Quantity;
                p.Imgurl = products.Imgurl;
                p.Price = products.Price;

                _productRepository.SaveChanges();
            }
            else { 
                return BadRequest();
            }

            return Ok();
        }

        // DELETE api/<controller>/5
     //   [Authorize]
        [HttpDelete("{id}")]
        public ActionResult DeleteProducts(int id)
        {
            var products = _productRepository.GetOne(id);
            if (products == null)
            {
                return NotFound();
            }

            _productRepository.Remove(products);
            _productRepository.SaveChanges();

            return Ok();
        }

        /*private bool ProductsExists(int id)
        {
            return _context.Product.Any(e => e.Id == id);
        }*/
    }
}
