class Solution
{
    static void Main(string[] args)
    {
        string faction, race, charClass, gender;

        Console.WriteLine("Choose your faction: (1/2)");
        Console.WriteLine("1. Horde");
        Console.WriteLine("2. Alliance");
        faction = Console.ReadLine();
        Console.Clear();

        Console.WriteLine("Choose your race: (1/2/3)");
        Console.WriteLine("1. Troll");
        Console.WriteLine("2. Human");
        Console.WriteLine("3. Elf");
        race = Console.ReadLine();
        Console.Clear();

        Console.WriteLine("Choose your class: (1/2)");
        Console.WriteLine("1. Mage");
        Console.WriteLine("2. Paladin");
        charClass = Console.ReadLine();
        Console.Clear();

        Console.WriteLine("Choose your geneder: (1/2)");
        Console.WriteLine("1. Male");
        Console.WriteLine("2. Female");
        gender = Console.ReadLine();
        Console.Clear();

        switch (faction)
        {
            case "1":
                faction = "Horde";
                break;
            case "2":
                faction = "Alliance";
                break;
        }

        switch (race)
        {
            case "1":
                race = "Troll";
                break;
            case "2":
                race = "Human";
                break;
            case "3":
                race = "Elf";
                break;
        }

        switch (charClass)
        {
            case "1":
                charClass = "Mage";
                break;
            case "2":
                charClass = "Paladin";
                break;
        }

        switch (gender)
        {
            case "1":
                gender = "Male";
                break;
            case "2":
                gender = "Female";
                break;
        }

        Console.WriteLine($"Your character faction is {faction}, race {race}, character {charClass}, geneder {gender}");
        Console.ReadLine();
    }

}
