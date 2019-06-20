using System;
using System.Collections.Generic;
using System.Text;

namespace AlugaSe.DomainModel.Entities
{
    public class Vendor : Role<Guid>
    {
        public virtual ICollection<Product> Products { get; set; }
    }
}
