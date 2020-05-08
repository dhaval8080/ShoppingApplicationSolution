using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaymentApi.Model
{
    public interface IPaymentRepository
    {
        Task<List<Payment>> GetAll();
        Task<Payment> GetOne(int id);
        void Add(Payment newPayment);
        void Remove(Payment newPayment);
        Task SaveChanges();
    }
}
