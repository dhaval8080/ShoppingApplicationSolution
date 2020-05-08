using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaymentApi.Model
{
    public class PaymentRepository : IPaymentRepository
    {
        private readonly shoppingdbContext _context;

        public PaymentRepository(shoppingdbContext context)
        {
            _context = context;
        }
        public void Add(Payment newPayment)
        {
            _context.Payment.Add(newPayment);
        }

        public async Task<List<Payment>> GetAll()
        {
            return await _context.Payment.ToListAsync();
        }

        public async Task<Payment> GetOne(int id)
        {
            return await _context.Payment.FindAsync(id);
        }

        public void Remove(Payment newPayment)
        {
            _context.Payment.Remove(newPayment);
        }

        public async Task SaveChanges()
        {
            await _context.SaveChangesAsync();
        }
    }
}
