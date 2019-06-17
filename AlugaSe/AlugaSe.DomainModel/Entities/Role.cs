using AlugaSe.DomainModel.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlugaSe.DomainModel.Entities
{
    public abstract class Role<EntityBase> : EntityBase<EntityBase>
    {
        public string Name { get; set; }
        public string Address { get; set; }
        //public Identification Identification { get; set; }
        public decimal Rating { get; set; }
        public DateTime? BirthDay { get; set; }
        //public Gender Gender { get; set; }
    }
}
