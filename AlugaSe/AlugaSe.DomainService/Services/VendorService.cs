using AlugaSe.DomainModel.Entities;
using AlugaSe.DomainModel.Interfaces.Repositories;
using AlugaSe.DomainService.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlugaSe.DomainService.Services
{
    public class VendorService : IVendorService
    {
        private readonly IVendorRepository _vendorRepository;

        public VendorService(IVendorRepository vendorRepository)
        {
            _vendorRepository = vendorRepository;
        }

        public IEnumerable<Vendor> ReadAll()
        {
            return _vendorRepository.ReadAll();
        }

        public void Insert(Vendor vendor)
        {
            _vendorRepository.Create(vendor);
        }

        public void Edit(Vendor vendor)
        {
            _vendorRepository.Update(vendor);
        }
    }
}
