using Microsoft.EntityFrameworkCore;
using ProductApi.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductApi.Model
{
    public class ProductRepository : IProductRepository
    {
        private readonly shoppingdbContext _context;

        public ProductRepository(shoppingdbContext context)
        {
            _context = context;
        }

        public void Add(Product newProduct)
        {
            _context.Product.Add(newProduct);
        }

        public IEnumerable<Product> GetAll()
        {
            return _context.Product.ToList();
        }

        public Product GetOne(int id)
        {
            return _context.Product.Find(id);
        }

        public Product GetOne(Product newProduct)
        {
           return _context.Product.Find(newProduct.Id);
        }

        public void Remove(Product newProduct)
        {
            _context.Product.Remove(newProduct);
        }

        public void SaveChanges()
        {
            _context.SaveChangesAsync();
        }
    }
}
