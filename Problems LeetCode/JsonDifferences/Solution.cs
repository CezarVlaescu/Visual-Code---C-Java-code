using System;
using System.Collections.Generic;
using Newtonsoft.Json;

public class Result
{
    public static List<string> getJSONDiff(string json1, string json2)
    {
        var dict1 = JsonConvert.DeserializeObject<Dictionary<string, string>>(json1);
        var dict2 = JsonConvert.DeserializeObject<Dictionary<string, string>>(json2);

        var diff = new List<string>();

        // Check each entry in the first dictionary to see if it is in the second dictionary with a different value
        foreach (var entry in dict1)
        {
            if (dict2.TryGetValue(entry.Key, out var value))
            {
                if (entry.Value != value)
                {
                    diff.Add(entry.Key);
                }
            }
        }

        // Check each entry in the second dictionary to see if it is in the first dictionary and not already included
        foreach (var entry in dict2)
        {
            if (dict1.TryGetValue(entry.Key, out var value))
            {
                if (entry.Value != value && !diff.Contains(entry.Key))
                {
                    diff.Add(entry.Key);
                }
            }
        }

        // Sort the list of differing keys before returning
        diff.Sort();
        
        return diff;
    }
}

// Usage example:
string json1 = "{\"hello\":\"world\", \"hi\":\"hello\", \"you\":\"me\"}";
string json2 = "{\"hello\":\"world\", \"hi\":\"hola\", \"you\":\"me\"}";

var differences = Result.getJSONDiff(json1, json2);
foreach (var key in differences)
{
    Console.WriteLine(key);
}
