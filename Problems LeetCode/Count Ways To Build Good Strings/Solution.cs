public int CountGoodStrings(int low, int high, int zero, int one)
    {

        // Append character '0' -> zero times ( if int zero = 1, append one time )
        // Append character '1' -> one times ( if int one = 2, append two times )

        // A good string -> constructed by above processs having a length between low and high (inclusive)

        // return all the possible strings, count as int

        int[] dp = new int[high + 1]; // dp = Dynammic Programming
        int res = 0, mod = 1000000007;
        dp[0] = 1;
        
        for(int i = 1; i <= high; i++)
        {
            if(i >= zero) dp[i] = (dp[i] + dp[i - zero]) % mod;
            if(i >= one) dp[i] = (dp[i] + dp[i - one]) % mod;
            if(i >= low) res = (res + dp[i]) % mod;
        }

        return res;
    }
