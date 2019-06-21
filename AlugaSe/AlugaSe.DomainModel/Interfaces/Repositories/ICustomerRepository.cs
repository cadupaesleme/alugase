using AlugaSe.DomainModel.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlugaSe.DomainModel.Interfaces.Repositories
{
    public interface ICustomerRepository : IRepository<Customer, Guid>
    {
    }
}
