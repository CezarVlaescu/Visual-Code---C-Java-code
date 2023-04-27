
namespace Polimorfism
{
    internal class Car
    {
        public string HP { get; set; }
        public string Color { get; set; }

        //default class 
        public Car()
        {
            HP = "2.000 CP";
            Color = "Red";
        }

        public Car(string HP, string Color)
        {
            this.HP = HP;
            this.Color = Color;
        }

        public virtual void ShowDetails()
        {
            Console.WriteLine($"The car has {this.HP} and color {this.Color}");
        }

        public override void Repair()
        {
            Console.WriteLine("Car was repaired");
        }
    }
}
