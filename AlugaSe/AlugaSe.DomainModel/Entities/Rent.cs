using System;
using System.Collections.Generic;
using System.Text;

namespace AlugaSe.DomainModel.Entities
{
    public class Rent : EntityBase<Guid>
    {
        public virtual ICollection<RentItem> RentItems { get; set; }
        public DateTime Date { get; set; }
        public Customer Customer { get; set; }
    }
}
