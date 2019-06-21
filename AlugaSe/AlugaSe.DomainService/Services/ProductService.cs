using AlugaSe.DomainModel.Entities;
using AlugaSe.DomainModel.Interfaces.Repositories;
using AlugaSe.DomainService.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlugaSe.DomainService.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _ProductRepository;

        public ProductService(IProductRepository ProductRepository)
        {
            _ProductRepository = ProductRepository;
        }

        public IEnumerable<Product> ReadAll()
        {
            return _ProductRepository.ReadAll();
        }

        public void Create(Product Product)
        {
            _ProductRepository.Create(Product);
        }

        public void Update(Product Product)
        {
            _ProductRepository.Update(Product);
        }

        public Product Read(Guid id)
        {
            return _ProductRepository.Read(id);
        }

        public void Delete(Guid id)
        {
            _ProductRepository.Delete(id);
        }

        public void Complete()
        {
            _ProductRepository.SaveChanges();
        }
    }
}
