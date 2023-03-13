class Solution
{
    static void Main(string[] args)
    {
        int health, hits, dmg, dodge;

        Console.WriteLine("Enter the players health");
        health = int.Parse(Console.ReadLine());

        Console.WriteLine("How many hits should player take?");
        hits = int.Parse(Console.ReadLine());

        Console.WriteLine("How much damage per hit?");
        dmg = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the player's dodge change");
        dodge = int.Parse(Console.ReadLine());

        Random random = new Random();
        
        for (int i = 0; i < hits; i++)
        {
            int hitChance = random.Next(0, 100);
            Console.WriteLine($"The hit change is {hitChance}");

            if (hitChance < dodge) 
            {
                Console.WriteLine("The player dodged the attack!");
                continue;
            }
            health -= dmg;

            Console.WriteLine($"The player took a hit and has {health} left");

            if (health <= 0)
            {
                Console.WriteLine("The player is dead!");
                break;
            }

        }
        Console.WriteLine($"The player survived with {health} health");
    }
}
