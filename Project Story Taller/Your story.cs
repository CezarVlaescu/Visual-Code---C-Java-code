using System;

namespace MadLibs
{
  class Program
  {
    static void Main(string[] args)
    {
      /*
      This program reads a story
      Author: Cezar
      */
      Console.WriteLine("The program is running");

      string title = "Blestemul lui Hawk";

      Console.WriteLine(title);

      Console.Write("Enter a name: ");
      string name = Console.ReadLine();

      Console.Write("Enter a color: ");
      string color = Console.ReadLine();

      Console.Write("Enter a feeling: ");
      string feeling = Console.ReadLine();

      Console.Write("Enter a texture: ");
      string texture = Console.ReadLine();

      Console.Write("Enter a verb: ");
      string verb = Console.ReadLine();

      Console.Write("Enter first noun: ");
      string firstNoun = Console.ReadLine();

      Console.Write("Enter second noun: ");
      string secondNoun = Console.ReadLine();

      Console.Write("Enter an animal: ");
      string animal = Console.ReadLine();

      Console.Write("Enter a food: ");
      string food = Console.ReadLine();

      Console.Write("Enter a fruit: ");
      string fruit = Console.ReadLine();

      Console.Write("Enter a superhero: ");
      string superhero = Console.ReadLine();

      Console.Write("Enter a country: ");
      string country = Console.ReadLine();

      Console.Write("Enter a dessert: ");
      string dessert = Console.ReadLine();

      Console.Write("Enter a year: ");
      string year = Console.ReadLine();


      // The template for the story:

      string story = $"This morning {name} woke up feeling {feeling}. 'It is going to be a {texture} day!' Outside, a bunch of {animal}s were protesting to keep {food} in stores. They began to {verb} to the rhythm of the {firstNoun}, which made all the {fruit}s very {color}. Concerned, {name} texted {superhero}, who flew {name} to {country} and dropped {name} in a puddle of frozen {dessert}. {name} woke up in the year {year}, in a world where {secondNoun}s ruled the world.";
      

      Console.WriteLine(story);

    }
  }
}
