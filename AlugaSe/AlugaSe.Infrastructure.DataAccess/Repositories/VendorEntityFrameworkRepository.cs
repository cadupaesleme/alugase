using AlugaSe.DomainModel.Entities;
using AlugaSe.DomainModel.Interfaces.Repositories;
using AlugaSe.Infrastructure.DataAccess.Contexts;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlugaSe.Infrastructure.DataAccess.Repositories
{
    public class VendorEntityFrameworkRepository : IVendorRepository
    {
        private readonly AlugaSeContext _db;

        public VendorEntityFrameworkRepository(AlugaSeContext db)
        {
            _db = db;
        }

        public void Create(Vendor entity)
        {
            _db.Vendors.Add(entity);
            _db.SaveChanges();
        }

        public void Delete(Guid id)
        {
            _db.Remove(Read(id));
            _db.SaveChanges();
        }

        public Vendor Read(Guid id)
        {
            return _db.Vendors.Find(id);
        }

        public IEnumerable<Vendor> ReadAll()
        {
            return _db.Vendors;
        }

        public void Update(Vendor entity)
        {
            _db.Vendors.Update(entity);
            _db.SaveChanges();
        }
    }
}
