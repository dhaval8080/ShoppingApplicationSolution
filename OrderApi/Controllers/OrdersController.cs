using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using OrderApi.Model;

namespace OrderApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
   // [Authorize]
    public class OrdersController : ControllerBase
    {
        private readonly IOrderRepository _orderRepository;

        public OrdersController(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        // GET: api/Orders
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Orders>>> GetOrders()
        {
            return await _orderRepository.GetAll();
            //var order = await _orderRepository.GetAll();
            //return Ok(order);
        }

        // GET: api/Orders/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Orders>> GetOrders(int id)
        {
            var orders = await _orderRepository.GetOne(id);

            if (orders == null)
            {
                return NotFound();
            }
            return orders;
            //return Ok();
        }

        [HttpPost]
        public async Task<ActionResult<Orders>> PostOrders(Orders orders)
        {
            _orderRepository.Add(orders);
            await _orderRepository.SaveChanges();
            return orders;
            //return Ok();
        }

        // DELETE: api/Orders/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Orders>> DeleteOrders(int id)
        {
            var orders = await _orderRepository.GetOne(id);
            if (orders == null)
            {
                return NotFound();
            }

            _orderRepository.Remove(orders);
            await _orderRepository.SaveChanges();

            return Ok();
        }

        /*
        private bool OrdersExists(int id)
        {
            return _context.Orders.Any(e => e.Id == id);
        }
        */
    }
}
