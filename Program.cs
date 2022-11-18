// See https://aka.ms/new-console-template for more information
using Polymorphism;

Car car = new Car(400, "Green");

car.ShowDetails();
car.Repair();

Audi myAudi = new Audi(500, "Black", "A4");

myAudi.ShowDetails();
myAudi.Repair(); //Parent classes method

BMW myBMW = new BMW(450, "White", "540i");

myBMW.ShowDetails();
myBMW.Repair();

