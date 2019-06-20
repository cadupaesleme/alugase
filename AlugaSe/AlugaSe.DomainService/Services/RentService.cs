using AlugaSe.DomainModel.Entities;
using AlugaSe.DomainModel.Interfaces.Repositories;
using AlugaSe.DomainService.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlugaSe.DomainService.Services
{
    public class RentService : IRentService
    {
        private readonly IRentRepository _RentRepository;
        private readonly IRentItemRepository _RentItemRepository;

        public RentService(IRentRepository RentRepository, IRentItemRepository RentItemRepository)
        {
            _RentRepository = RentRepository;
            _RentItemRepository = RentItemRepository;
        }

        //It necessary to delete all RentItems before edit and save new ones        
        public void EditRent(Rent Rent)
        {
            var items = _RentItemRepository.ReadAll().Where(i => i.RentId == Rent.Id);

            foreach (var item in items)
            {
                _RentItemRepository.Delete(item.Id);
            }

            _RentRepository.Update(Rent);
            this.Complete();
        }

        public IEnumerable<Rent> ReadAll()
        {
            return _RentRepository.ReadAll();
        }

        public void Create(Rent Rent)
        {
            _RentRepository.Create(Rent);
        }

        public void Update(Rent Rent)
        {
            _RentRepository.Update(Rent);
        }

        public Rent Read(Guid id)
        {
            return _RentRepository.Read(id);
        }

        public void Delete(Guid id)
        {
            _RentRepository.Delete(id);
        }

        public void Complete()
        {
            _RentRepository.SaveChanges();
        }
    }
}
