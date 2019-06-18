using System;
using System.Collections.Generic;
using System.Text;

namespace AlugaSe.DomainModel.ValueObjects
{
    public struct Gender
    {
        public string Description { get; set; }

        public Gender(string desciption)
        {
            this.Description = desciption;
        }

        public static Gender NewGender(string description)
        {
            return new Gender(description);
        }

        public static Gender Parse(string description)
        {
            return new Gender(description);
        }

        public static bool operator ==(Gender gender1, Gender gender2)
        {
            return gender1.Description.Trim().ToLower() == gender2.Description.Trim().ToLower();
        }

        public static bool operator !=(Gender gender1, Gender gender2)
        {
            return gender1.Description.Trim().ToLower() != gender2.Description.Trim().ToLower();
        }

        public override bool Equals(object obj)
        {
            return this == ((Gender)obj);
        }

        public override int GetHashCode()
        {
            return this.Description.GetHashCode();
        }

        public override string ToString()
        {
            return $"{Description.ToString()}";
        }
    }
}
