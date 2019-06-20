using AlugaSe.DomainModel.Entities;
using AlugaSe.DomainModel.Interfaces.Repositories;
using AlugaSe.Infrastructure.DataAccess.Contexts;
using AlugaSe.Infrastructure.DataAccess.Factories;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlugaSe.Infrastructure.DataAccess.Repositories
{
    public class RentEntityFrameworkRepository : IRentRepository
    {
        private readonly AlugaSeContext _db;

        public RentEntityFrameworkRepository()
        {
            _db = new AlugaSeContextFactory().CreateDbContext(null);
        }

        public void Create(Rent entity)
        {
            _db.Rents.Add(entity);
        }

        public void Delete(Guid id)
        {
            _db.Remove(Read(id));
        }

        public Rent Read(Guid id)
        {
            return _db.Rents.Find(id);
        }

        public IEnumerable<Rent> ReadAll()
        {
            return _db.Rents;
        }

        public void Update(Rent entity)
        {
            _db.Rents.Update(entity);
        }

        public void SaveChanges()
        {
            _db.SaveChanges();
        }
    }
}
