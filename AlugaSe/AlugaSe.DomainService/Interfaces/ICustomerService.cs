using AlugaSe.DomainModel.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlugaSe.DomainService.Interfaces
{
    public interface ICustomerService
    {
        IEnumerable<Customer> ReadAll();
        void Create(Customer Customer);
        void Update(Customer Customer);
        Customer Read(Guid id);
        void Delete(Guid id);
        void Complete();
    }
}
