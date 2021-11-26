using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation_Abstraction
{
    internal class Teacher : PersonBaseClass
    {

        public override string ToString()
        {
            return $"{Id}, {Name}, Hej";
        }
    }
}
