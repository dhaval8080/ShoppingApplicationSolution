using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderApi.Model
{
    public class OrderRepository : IOrderRepository
    {
        private readonly shoppingdbContext _context;

        public OrderRepository(shoppingdbContext context)
        {
            _context = context;
        }
        public void Add(Orders newOrder)
        {
            _context.Orders.Add(newOrder);
        }

        public async Task<List<Orders>> GetAll()
        {
            return await _context.Orders.ToListAsync();
        }

        public async Task<Orders> GetOne(int id)
        {
            return await _context.Orders.FindAsync(id);
        }

        public void Remove(Orders newOrder)
        {
            _context.Orders.Remove(newOrder);
        }

        public async Task SaveChanges()
        {
            await _context.SaveChangesAsync();
        }
    }
}
