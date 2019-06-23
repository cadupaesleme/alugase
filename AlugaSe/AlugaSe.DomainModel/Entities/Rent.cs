using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace AlugaSe.DomainModel.Entities
{
    public class Rent : EntityBase<Guid>
    {
        public virtual ICollection<RentItem> RentItems { get; set; }
        public DateTime Date { get; set; }
        public virtual Customer Customer { get; set; }

        [ForeignKey("Customer")]
        [DisplayName("Customer")]
        public Guid CustomerId { get; set; }


        [NotMapped]
        public int ItemsQt
        {
            get
            {
                return RentItems.Sum(ri => ri.Quantity);
            }
        }

        [NotMapped]
        public decimal Total
        {
            get
            {
                return RentItems.Sum(ri => ri.UnitPrice * ri.Quantity * ri.NumberOfDays);
            }
        }
    }
}
