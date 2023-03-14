class Program
{
    enum WeekDays { Not, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday }
    static void Main(string[] args)
    {
        WeekDays day;

        Console.WriteLine("Wanna know the mood of the day?");

        Console.WriteLine("Choose a number 1 to 7, where 0 is Monday and 6 is Sunday, and all numbers represent each day!");
        int input = int.Parse(Console.ReadLine());
        day = (WeekDays) input;
        Console.WriteLine($"Today its {day}");

        switch(day)
        {
            case WeekDays.Monday:
                Console.WriteLine("I hate Monday!");
                break;
            case WeekDays.Tuesday:
                Console.WriteLine("Oh gosh is just Tuesday!");
                break;
            case WeekDays.Wednesday:
                Console.WriteLine("Its middle of the week!");
                break;
            case WeekDays.Thursday:
                Console.WriteLine("Close to weekend!");
                break;
            case WeekDays.Friday:
                Console.WriteLine("Horaaay is weekend!");
                break;
            case WeekDays.Saturday:
                Console.WriteLine("Today I'm relaxing!");
                break;
            case WeekDays.Sunday:
                Console.WriteLine("Nooo, weekend is over!");
                break;
        }

    }
}
