using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShipmentApi.model
{
    public class ShipmentRepository : IShipmentRepository
    {
        private readonly NewShoppingDbContext _context;

        public ShipmentRepository(NewShoppingDbContext context)
        {
            _context = context;
        }

        public void Add(Shipmentagent3 newShipmentAgent)
        {
            _context.Shipmentagent3.Add(newShipmentAgent);
        }

        public async Task<List<Shipmentagent3>> GetAll()
        {
           return await _context.Shipmentagent3.ToListAsync();
        }

        public async Task<Shipmentagent3> GetOne(int id)
        {
           return await _context.Shipmentagent3.FindAsync(id);
        }

        public Shipmentagent3 GetOne(Shipmentagent3 newShipmentAgent)
        {
            return _context.Shipmentagent3.Find(newShipmentAgent.Id);
        }

        public void Remove(Shipmentagent3 newShipmentAgent)
        {
            _context.Shipmentagent3.Remove(newShipmentAgent);
        }

        public Task SaveChanges()
        {
            return _context.SaveChangesAsync();
        }
    }
}
