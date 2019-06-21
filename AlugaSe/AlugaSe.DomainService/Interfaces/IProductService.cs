using AlugaSe.DomainModel.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlugaSe.DomainService.Interfaces
{
    public interface IProductService
    {
        IEnumerable<Product> ReadAll();
        void Create(Product Product);
        void Update(Product Product);
        Product Read(Guid id);
        void Delete(Guid id);
        void Complete();
    }
}
