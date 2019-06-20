using System;
using System.Collections.Generic;
using System.Text;

namespace AlugaSe.DomainModel.ValueObjects
{
    public struct Identification
    {
        public string Type { get; set; }
        public string Number { get; set; }

        public Identification(string type, string number)
        {
            this.Number = number;
            this.Type = type;
        }

        public static Identification NewIdentification(string type, string number)
        {
            return new Identification(type, number);
        }

        public static Identification Parse(string identificationStr)
        {
            var splittedIdentification = identificationStr.Split(' ');

            return new Identification(splittedIdentification[0], splittedIdentification[1]);
        }

        public static bool operator ==(Identification identification1, Identification identification2)
        {
            return identification1.Type.Trim().ToLower() == identification2.Type.Trim().ToLower() && identification1.Number.Trim().ToLower() == identification2.Number.Trim().ToLower();
        }

        public static bool operator !=(Identification identification1, Identification identification2)
        {
            return !(identification1.Type.Trim().ToLower() == identification2.Type.Trim().ToLower() && identification1.Number.Trim().ToLower() == identification2.Number.Trim().ToLower());
        }

        public override bool Equals(object obj)
        {
            return this == ((Identification)obj);
        }

        public override int GetHashCode()
        {
            return this.Type.GetHashCode() + this.Number.GetHashCode();
        }

        public override string ToString()
        {
            return $"{Type.ToString()} {Number.ToString()}";
        }

        public static List<string> ListTypes()
        {
            return new List<string>() { "CPF", "CNPJ", "RG", "Passaporte" };
        }
    }
}
