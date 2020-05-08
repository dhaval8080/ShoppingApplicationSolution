using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderApi.Model
{
    public interface IOrderRepository
    {
        Task<List<Orders>> GetAll();
        Task<Orders> GetOne(int id);
        void Add(Orders newOrder);
        void Remove(Orders newOrder);
        Task SaveChanges();
    }
}
