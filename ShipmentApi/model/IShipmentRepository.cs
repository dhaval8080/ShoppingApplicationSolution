using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShipmentApi.model
{
    public interface IShipmentRepository
    {
        Task<List<Shipmentagent3>> GetAll();
        Task<Shipmentagent3> GetOne(int id);
        Shipmentagent3 GetOne(Shipmentagent3 shipmentagent3);
        void Add(Shipmentagent3 newShipmentAgent);
        void Remove(Shipmentagent3 newShipmentAgent);
        Task SaveChanges();
    }
}
