using AlugaSe.DomainModel.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlugaSe.DomainService.Interfaces
{
    public interface IRentItemService
    {
        IEnumerable<RentItem> ReadAll();
        void Create(RentItem RentItem);
        void Update(RentItem RentItem);
        RentItem Read(Guid id);
        void Delete(Guid id);
        void Complete();
    }
}
