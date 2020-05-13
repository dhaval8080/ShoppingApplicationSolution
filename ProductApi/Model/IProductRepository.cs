using ProductApi.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductApi.Model
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAll();
        Product GetOne(int id);
        Product GetOne(Product newProduct);
        void Add(Product newProduct);
        void Remove(Product newProduct);
        void SaveChanges();
    }
}
