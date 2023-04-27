using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfism
{
    internal class Car
    {
        public string HP { get; set; }
        public string Color { get; set; }

        // has a relationship

        protected CarIDInfo carIDInfo = new CarIDInfo();

        public void SetCarIDInfo(int idNum, string owner) 
        {
            carIDInfo.IDNum = idNum;
            carIDInfo.Owner = owner;
        }

        public void GetCarIDInfo()
        {
            Console.WriteLine($"The car has the ID of {carIDInfo.IDNum} and is owned by {carIDInfo.Owner}");
        }

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
