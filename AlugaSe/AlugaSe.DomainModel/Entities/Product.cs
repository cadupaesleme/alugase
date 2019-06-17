using System;
using System.Collections.Generic;
using System.Text;

namespace AlugaSe.DomainModel.Entities
{
    public class Product : EntityBase<Guid>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal UnitPrice { get; set; }
        public Vendor Vendor { get; set; }
        public decimal Rating { get; set; }
    }
}
