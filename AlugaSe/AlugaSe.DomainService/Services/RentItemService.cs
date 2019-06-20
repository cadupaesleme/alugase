using AlugaSe.DomainModel.Entities;
using AlugaSe.DomainModel.Interfaces.Repositories;
using AlugaSe.DomainService.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlugaSe.DomainService.Services
{
    public class RentItemService : IRentItemService
    {
        private readonly IRentItemRepository _RentItemRepository;

        public RentItemService(IRentItemRepository RentItemRepository)
        {
            _RentItemRepository = RentItemRepository;
        }

        public IEnumerable<RentItem> ReadAll()
        {
            return _RentItemRepository.ReadAll();
        }

        public void Create(RentItem RentItem)
        {
            _RentItemRepository.Create(RentItem);
        }

        public void Update(RentItem RentItem)
        {
            _RentItemRepository.Update(RentItem);
        }

        public RentItem Read(Guid id)
        {
            return _RentItemRepository.Read(id);
        }

        public void Delete(Guid id)
        {
            _RentItemRepository.Delete(id);
        }

        public void Complete()
        {
            _RentItemRepository.SaveChanges();
        }
    }
}
