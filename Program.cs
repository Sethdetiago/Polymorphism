// See https://aka.ms/new-console-template for more information
using Polymorphism;


Audi audi = new Audi(300, "Black", "A4");

audi.ShowDetails();
audi.Repair();

//Creating object as a Car will call parent Method fir show detail
Car audi2 = new Audi(300, "Black", "A4");

audi2.ShowDetails();
audi2.Repair();


Console.ReadKey();

