using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AlugaSe.DomainModel.Entities
{
    public class RentItem : EntityBase<Guid>
    {
        public virtual Rent Rent { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Quantity { get; set; }
        public virtual Product Product { get; set; }
        public DateTime InitialDate { get; set; }
        public DateTime EndDate { get; set; }

        [ForeignKey("Rent")]
        public Guid RentId { get; set; }

        [ForeignKey("Product")]
        public Guid ProductId { get; set; }
    }
}
