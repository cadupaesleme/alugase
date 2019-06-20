using AlugaSe.DomainModel.Entities;
using AlugaSe.DomainModel.Interfaces.Repositories;
using AlugaSe.Infrastructure.DataAccess.Contexts;
using AlugaSe.Infrastructure.DataAccess.Factories;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlugaSe.Infrastructure.DataAccess.Repositories
{
    public class RentItemEntityFrameworkRepository : IRentItemRepository
    {
        private readonly AlugaSeContext _db;

        public RentItemEntityFrameworkRepository()
        {
            _db = new AlugaSeContextFactory().CreateDbContext(null);
        }

        public void Create(RentItem entity)
        {
            _db.RentItems.Add(entity);
        }

        public void Delete(Guid id)
        {
            _db.Remove(Read(id));
        }

        public RentItem Read(Guid id)
        {
            return _db.RentItems.Find(id);
        }

        public IEnumerable<RentItem> ReadAll()
        {
            return _db.RentItems;
        }

        public void Update(RentItem entity)
        {
            _db.RentItems.Update(entity);
        }

        public void SaveChanges()
        {
            _db.SaveChanges();
        }
    }
}
