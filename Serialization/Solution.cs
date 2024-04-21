// Serialization and Deserialization in .NET

// Serialization -> the process of converting the state of an object, that is, the value or its proprieties, into a form that can be stored or transmitted.
//               -> the serialized form doesn't include any information about an object's associated methods

// Deserialization -> reconstructs an object from the serialized form.
//                 -> a way to deserialize a json is to create a .NET class that has prop and fields with more Json prop. 

using System.Net.Http.Json;
using System.Text.Json;

public struct User
{
    public int Id {  get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }

}

public class Program
{
    public static async Task Main()
    {
        using HttpClient client = new() { BaseAddress = new Uri("https://.....") }; // http client is used to do the mechanism of request-response based on a specific URI

        // Get the user information

        User user = await client.GetFromJsonAsync<User>("users/1"); // GET Request to URI and returns the value that result from deserializing the response body as JSON in async op.

        Console.WriteLine(user.Name);
        Console.WriteLine(user.Description);
        Console.WriteLine(user.Id);

        // Post a new user

        HttpResponseMessage response = await client.PostAsJsonAsync("users", user); // POST Request to specific URI, containing the value serialized as JSON in request body
    }
}

// Serialize example

public struct WeatherForecast
{
    public DateTimeOffset Date { get; set; }
    public int TemperatureCelsius { get; set; }
    public string Summary { get; set; }

}

public class ImplementForecast
{
    static async Task Main()
    {
        var weatherForecast = new WeatherForecast()
        {
            Date = DateTime.Parse("2019-08-01"),
            TemperatureCelsius = 25,
            Summary = "Hot"
        };

        string fileName = "weather.json";

        // async

        await using FileStream createStream = File.Create(fileName);
        await JsonSerializer.SerializeAsync(createStream, weatherForecast);

        // not async

        string jsonString = JsonSerializer.Serialize(weatherForecast); // json string representation of a value, basically the transformation of an object to a json
        File.WriteAllText(fileName, jsonString);

        Console.WriteLine(jsonString);
    }
}

public class Books
{
    //[JsonRequired]
    public string Description { get; set; }
    public string Author { get; set; }
    public string Title { get; set; }
    public double Price { get; set; }
}

public class ImplementBooks<T> where T : Books
{
    public static void Main()
    {
        string fileName = "books.json";
        string jsonString = File.ReadAllText(fileName);
        Books books = JsonSerializer.Deserialize<T>(jsonString)!; // a book representation of a Json Value
    }
}
