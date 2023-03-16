class Program
{
    static void Main(string[] args)
    {
       
        Console.WriteLine("Press 1 to add, press 2 to substract");
        int choice = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Press 1 for int, press 2 for float");
        int varTypes = int.Parse(Console.ReadLine());

     

        if (choice == 1) 
        {
            if (varTypes == 1)
            {
                Console.WriteLine("Enter first value");
                int x = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter second value");
                int y = int.Parse(Console.ReadLine());

                Add(x, y);
            }
            else if (varTypes == 2) 
            {
                Console.WriteLine("Enter first value");
                float x = float.Parse(Console.ReadLine());

                Console.WriteLine("Enter second value");
                float y = float.Parse(Console.ReadLine());
               
                Add(x, y);

                
            }
            else
            {
                Console.WriteLine("Invalid choice!");
            }
        }
        else if (choice == 2) 
        {
            if (varTypes == 1)
            {
                Console.WriteLine("Enter first value");
                int x = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter second value");
                int y = int.Parse(Console.ReadLine());

                Substract(x, y);
            }
            else if (varTypes == 2)
            {
                Console.WriteLine("Enter first value");
                float x = float.Parse(Console.ReadLine());

                Console.WriteLine("Enter second value");
                float y = float.Parse(Console.ReadLine());

                Substract(x, y);
            }
            else
            {
                Console.WriteLine("Invalid choice!");
            }
        }

    }

    static int Add(int x, int y)
    {
        Console.WriteLine($"The result is {x + y}");
        return x + y;
    }

    static float Add(float x, float y)
    {
        Console.WriteLine($"The result is {x + y}");
        return x + y;
    }

    static float Substract(int x, int y)
    {
        Console.WriteLine($"The result is {x - y}");
        return x - y;
    }

    static float Substract(float x, float y)
    {
        Console.WriteLine($"The result is {x - y}");
        return x - y;
    }

}
