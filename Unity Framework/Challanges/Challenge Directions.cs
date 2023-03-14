class Solution
{
    enum Directions { North = 1, South, East, West }
    static void Main(string[] args)
    {
            Directions choice;

            int x = 0, y = 0;

            while (true) 
            { 
                 Console.WriteLine($"Your current position is x:{x} and y:{y}");
                 Console.WriteLine("Pick a direction");
                 Console.WriteLine("1. North, 2. South, 3. East, 4. West");

                 int input = int.Parse(Console.ReadLine());

                 choice = (Directions) input;
            
                 switch (choice)
                 {
                      case Directions.North:
                          Console.WriteLine("Going up North");
                          y++;
                          break;
                      case Directions.South:
                          Console.WriteLine("Going down South");
                          y--;
                          break;
                      case Directions.East:
                          Console.WriteLine("Moving to East");
                          x++;
                          break;
                      case Directions.West:
                          Console.WriteLine("Moving to West");
                          x--;
                          break;
                 }
                 Console.WriteLine();
            }
    }
}
