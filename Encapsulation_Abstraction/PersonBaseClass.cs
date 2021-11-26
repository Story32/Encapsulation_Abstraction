using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation_Abstraction
{
    internal class PersonBaseClass
    {
        public int Id { get; set; } 
        public string Name { get; set; }

        public House House { get; set; }

        public override string ToString()
        {
            return $"{Id}, {Name}, {House}";
        }

    }

    public enum House
    {
        None, Griffendor, Huffelpuf, Ravenclas, Slytherin
    }
}
