
using Encapsulation_Abstraction;

//Hele konceptet med dette er, at de forskellige subClasses nedarver nogle værdier fra BaseClass, såsom name, ID, House
//det betyder så, at de forskellige subClasses har nogle fælles værdier, men kan så derefter have deres égne værdier samtidigt. 


Teacher Dumbledore1 = new Teacher() { Id = 1, Name = "Dumbledore", House = House.Griffendor };
Teacher Dumbledore2 = new Teacher() { Id = 2, Name = "Dumbledore", House = House.Slytherin };
Teacher Dumbledore3 = new Teacher() { Id = 3, Name = "Dumbledore", House = House.Slytherin };

StudentClass Harry = new StudentClass() { Id = 117, Name = "Harry", House= House.Griffendor };


List<Teacher> Teachers = new() { Dumbledore1, Dumbledore2, Dumbledore3 };
foreach(var t in Teachers)
{
    Console.WriteLine(t);
}

//Console.WriteLine( Dumbledore.ToString());
Console.WriteLine( Harry.ToString());
Console.WriteLine();

