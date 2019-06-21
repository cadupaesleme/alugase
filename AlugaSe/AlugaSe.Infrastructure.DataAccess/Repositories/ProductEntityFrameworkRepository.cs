using AlugaSe.DomainModel.Entities;
using AlugaSe.DomainModel.Interfaces.Repositories;
using AlugaSe.Infrastructure.DataAccess.Contexts;
using AlugaSe.Infrastructure.DataAccess.Factories;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlugaSe.Infrastructure.DataAccess.Repositories
{
    public class ProductEntityFrameworkRepository : IProductRepository
    {
        private readonly AlugaSeContext _db;

        public ProductEntityFrameworkRepository()
        {
            _db = new AlugaSeContextFactory().CreateDbContext(null);
        }

        public void Create(Product entity)
        {
            _db.Products.Add(entity);
        }

        public void Delete(Guid id)
        {
            _db.Remove(Read(id));
        }

        public Product Read(Guid id)
        {
            return _db.Products.Find(id);
        }

        public IEnumerable<Product> ReadAll()
        {
            return _db.Products;
        }

        public void Update(Product entity)
        {
            _db.Products.Update(entity);
        }

        public void SaveChanges()
        {
            _db.SaveChanges();
        }
    }
}
