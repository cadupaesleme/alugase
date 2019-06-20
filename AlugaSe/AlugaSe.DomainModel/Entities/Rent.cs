using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AlugaSe.DomainModel.Entities
{
    public class Rent : EntityBase<Guid>
    {
        public virtual ICollection<RentItem> RentItems { get; set; }
        public DateTime Date { get; set; }
        public virtual Customer Customer { get; set; }

        [ForeignKey("Customer")]
        public Guid CustomerId { get; set; }
    }
}
