using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation_Abstraction
{
    internal class StudentClass : PersonBaseClass
    {
        //Når jeg ikke henter værdierne ned her, som jeg har gjort i Teacher (return), så sørger den blot for at
        //override det som står i BaseClass, som er: return $"{Id}, {Name}, {House}";
    }
}
