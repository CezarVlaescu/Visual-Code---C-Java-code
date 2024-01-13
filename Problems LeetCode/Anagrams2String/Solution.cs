public class Solution {
    public int MinSteps(string s, string t) {
        Dictionary<char, int> map = new Dictionary<char, int>();

        return AnagramChecking(map, s, t);
    }

    public bool IsAnagram(Dictionary<char, int> dict) => dict.All(kv => kv.Value == 0);

    public int AnagramChecking(Dictionary<char, int> dict, string s, string t)
    {
        int count = 0;

        foreach (char c in s)
        {
            if (!dict.ContainsKey(c)) dict.Add(c, 1);
            else dict[c]++;
        }

        foreach(char c in t)
        {
            if (dict.ContainsKey(c) && dict[c] != 0) dict[c]--;
            else if (!dict.ContainsKey(c) || dict[c] == 0) count++;
        }

        if (IsAnagram(dict)) return 0;

        return count;
    }
}
