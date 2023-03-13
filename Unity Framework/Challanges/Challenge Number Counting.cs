class Solution
{
    static void Main(string[] args)
    {
        while (true)

        {
            int minCount, maxCount;

            Console.WriteLine("Enter the count from");
            minCount = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the count to");
            maxCount = int.Parse(Console.ReadLine());

            Console.Clear();

            Console.WriteLine($"Counting from {minCount} to {maxCount}.");

            Console.WriteLine("Counting....");

            while (maxCount != minCount)
            {
                if (minCount > maxCount)
                {
                    minCount--;
                    Console.WriteLine(minCount);
                }
                else
                {
                    minCount++;
                    Console.WriteLine(minCount);
                }
            }
            Console.WriteLine("Wanna do it again? (yes/no)");
            string answer = Console.ReadLine();
            if (answer == "yes")
            {
                Console.Clear();
            }
            else
            {
                break;
            }
        }
       
    }
}
