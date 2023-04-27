using Polimorfism;

class Solution
{
    static void Main(string[] args)
    {
        var cars = new List<Car>()
        {
            new Audi("A4", "2000", "red"),
            new BMW("X3", "3000", "blue")
        };

        foreach (var car in cars)
        {
            car.Repair();
        }

        Car car1 = new BMW("CX5", "3000", "Blue");
        Car car2 = new Audi("Superb", "1000", "Yellow");

        car1.ShowDetails();
        car2.ShowDetails();

        BMW m1 = new BMW("M5", "3400", "white");
        m1.ShowDetails();

        Car carB = (Car)m1;
        carB.ShowDetails();

        M3 myM3 = new M3("m3 superturbo", "200", "Blue");
        myM3.ShowDetails();

        Console.ReadKey();
    }
}
