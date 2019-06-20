using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AlugaSe.DomainModel.Entities
{
    public class Product : EntityBase<Guid>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal UnitPrice { get; set; }
        public Vendor Vendor { get; set; }

        [ForeignKey("Vendor")]
        public Guid VendorId { get; set; }
    }
}
