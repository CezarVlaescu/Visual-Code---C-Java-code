using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

class Solution
{
    static void Main(string[] args)
    {
        List<int> list = new List<int>();
        List<int> list1 = new List<int>();
        List<int> empty = new List<int>();
        

        for(int i = 0; i<4 ; i++)
        {
            
            int value;
            Console.WriteLine("Give the values to list");
            value = int.Parse(Console.ReadLine());
            if (value > 0)
            {
                list.Add(value);
            }
            else if (value <= 0)
            {
                empty.Add(value);
                foreach(int v in empty)
                {
                    Console.WriteLine(v);
                }
            }
           
        }
        Console.WriteLine("\n");
        foreach(int i in list)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine("\n");
        for (int i = 0; i<4; i++)
        {
            int value1;
            Console.WriteLine("Give the values to list1");
            value1 = int.Parse(Console.ReadLine());
            list1.Add(value1);
            if (value1 == 0)
            {
                empty.Add(0);
                Console.WriteLine(empty);
            }
        }

        Console.WriteLine("\n");
        foreach (int i in list1)
        {
            Console.WriteLine(i);
        }

        list.AddRange(list1);
        list.Sort();
        Console.WriteLine(String.Join(',', list));
    }
}
