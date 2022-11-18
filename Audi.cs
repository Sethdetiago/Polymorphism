using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Audi : Car
    {
        public string Model { get; set; }

        //Private member which specifies the brand
        private string Brand = "Audi";
        public Audi(int HP, string Color, string model) : base(HP, Color)
        {
            Model = model;
        }

        public new void ShowDetails() //not overriding but creating own version of method.
        {
            Console.WriteLine("This {0}'s Details", Brand); //This can be reused in other Brand subclasses
            Console.WriteLine("Horse Power: {0}! \nColor: {1}", HP, Color);
            Console.WriteLine("Model: {0}", Model); //Addition of the Model to the method
        }
        public override void Repair()
        {
            Console.WriteLine("Message from {0} Dealership", Brand);
            base.Repair();
        }
    }
}
