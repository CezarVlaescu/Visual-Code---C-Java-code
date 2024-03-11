        Dictionary<char, int> orderMap = new Dictionary<char, int>();
        for (int i = 0; i < order.Length; i++)
        {
            orderMap.Add(order[i], i);
        }

        // Custom sorting using LINQ
        var sortedChars = s.ToCharArray().OrderBy(c => orderMap.ContainsKey(c) ? orderMap[c] : int.MaxValue);

        // Concatenate the sorted characters into a string
        return new string(sortedChars.ToArray());
