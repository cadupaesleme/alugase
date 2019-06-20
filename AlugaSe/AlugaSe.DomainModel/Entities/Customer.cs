using AlugaSe.DomainModel.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlugaSe.DomainModel.Entities
{
    public class Customer : Role<Guid>
    {
        public virtual ICollection<Rent> Rents { get; set; }
    }
}
