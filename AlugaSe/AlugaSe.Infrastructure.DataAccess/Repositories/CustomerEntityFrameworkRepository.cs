using AlugaSe.DomainModel.Entities;
using AlugaSe.DomainModel.Interfaces.Repositories;
using AlugaSe.Infrastructure.DataAccess.Contexts;
using AlugaSe.Infrastructure.DataAccess.Factories;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlugaSe.Infrastructure.DataAccess.Repositories
{
    public class CustomerEntityFrameworkRepository : ICustomerRepository
    {
        private readonly AlugaSeContext _db;

        public CustomerEntityFrameworkRepository()
        {
            _db = new AlugaSeContextFactory().CreateDbContext(null);
        }

        public void Create(Customer entity)
        {
            _db.Customers.Add(entity);
        }

        public void Delete(Guid id)
        {
            _db.Remove(Read(id));
        }

        public Customer Read(Guid id)
        {
            return _db.Customers.Find(id);
        }

        public IEnumerable<Customer> ReadAll()
        {
            return _db.Customers;
        }

        public void Update(Customer entity)
        {
            _db.Customers.Update(entity);
        }

        public void SaveChanges()
        {
            _db.SaveChanges();
        }
    }
}
