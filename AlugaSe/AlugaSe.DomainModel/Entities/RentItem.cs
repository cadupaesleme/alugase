using System;
using System.Collections.Generic;
using System.Text;

namespace AlugaSe.DomainModel.Entities
{
    public class RentItem : EntityBase<Guid>
    {
        public virtual Rent Rent { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Quantity { get; set; }
        public Product Product { get; set; }
        public DateTime InitialDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
