using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Car
    {
        //Properties of the Class Car
        public int HP { get; set; }
        public string Color { get; set; }

        public Car(int HP, string Color)
        {
            this.HP = HP;
            this.Color = Color;
        }

        public void ShowDetails()
        {
            Console.WriteLine("Horse Power: {0}! \nColor: {1}", HP, Color);
        }

        public virtual void Repair()
        {
            Console.WriteLine("Car was repaired");
        }

    }
}
