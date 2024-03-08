class Solution
{
    static void Main(string[] args)
    {
        int[] nums = { 1, 2, 2, 3, 1, 4 };
        int[] nums2 = { 6, 13, 15, 15, 11, 6, 7, 12, 4, 11 };

        Console.WriteLine(MaximumFrequency(nums2));
    }

    static int MaximumFrequency(int[] nums)
    {
        Dictionary<int, int> myDict = DictionarizeTheArray(nums);

        if (myDict.All(v => v.Value == 1)) return nums.Length;

        int[] values = ExtractingValues(DictionarizeTheArray(nums)).ToArray();
        Array.Sort(values);

        int max = values[^1];
        int afterMax = max;

        for (int i = values.Length - 2; i >= 0; i--)
        {
            if (max == values[i]) afterMax += values[i];
            else continue;
        }

        return afterMax;
    }

    static Dictionary<int, int> DictionarizeTheArray(int[] nums)
    {
        Dictionary<int, int> dict = new();

        foreach(int i in nums)
        {
            if (!dict.ContainsKey(i)) dict.Add(i, 1);
            else dict[i]++;
        }

        return dict;
    }

    static List<int> ExtractingValues(Dictionary<int, int> dict)
    {
        List<int> list = new();

        foreach(KeyValuePair<int, int> pair in dict)
        {
            list.Add(pair.Value);
        }

        return list;
    }
}
