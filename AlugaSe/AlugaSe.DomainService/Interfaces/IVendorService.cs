using AlugaSe.DomainModel.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlugaSe.DomainService.Interfaces
{
    public interface IVendorService
    {
        IEnumerable<Vendor> ReadAll();
        void Create(Vendor vendor);
        void Update(Vendor vendor);
        Vendor Read(Guid id);
        void Delete(Guid id);
    }
}
