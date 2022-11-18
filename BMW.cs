using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class BMW : Car
    {
        public string Model { get; set; }

        //Private member which specifies the brand
        private string Brand = "BMW";
        public BMW(int HP, string Color, string model) : base(HP, Color)
        {
            Model = model;
        }

        public override void ShowDetails()
        {
            Console.WriteLine("This {0}'s Details", Brand); //This can be reused in other Brand subclasses
            base.ShowDetails();         //Reuse of parents method
            Console.WriteLine("Model: {0}", Model); //Addition of the Model to the method
        }

        public override void Repair()
        {
            Console.WriteLine("Message from BMW Dealership:");
            base.Repair();  //Using part of parent classes code
        }
    }
}
