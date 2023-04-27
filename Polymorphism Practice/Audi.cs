using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfism
{
    internal class Audi : Car
    {
        private string brand = "Audi";
        public string Model { get; set; }


        public Audi(string Model, string HP, string Color) : base(HP, Color)
        {
            this.Model = Model;
        }

        public override void ShowDetails()
        {
            Console.WriteLine($"The car is brand {this.Model} has {this.HP} and color {this.Color}");
        }

        public override void Repair()
        {
            Console.WriteLine($"The Audi {this.Model} was repaired");
        }
    }
}
