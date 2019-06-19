using AlugaSe.DomainModel.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlugaSe.DomainService.Interfaces
{
    public interface IVendorService
    {
        IEnumerable<Vendor> ReadAll();
        void Insert(Vendor vendor);
        void Edit(Vendor vendor);
    }
}
