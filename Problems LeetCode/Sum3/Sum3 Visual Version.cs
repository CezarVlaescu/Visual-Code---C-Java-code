class Solution
{
    static void Main(string[] args)
    {
        // nums = [ -1, 0, 1, 2, -1, -4 ]
        int[] nums = { -1, 0, 1, 2, -1, 4 };
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = 0; j < nums.Length; j++) 
            {
                for (int k = 0; k < nums.Length; k++)
                {
                    if (i != j && j != k && k != i)
                    {
                        int result = nums[i] + nums[j] + nums[k];   
                        if (result == 0)
                        {
                            // Console.WriteLine(result);
                            Tuple<int, int, int> [] triplets = { Tuple.Create(i, j, k) };
                            foreach(var triplet in triplets)
                            {
                                // To check the index positions in nums where items sum equal to 0
                                
                                var tupleList = new List<(int, int, int)> { (triplet.Item1, triplet.Item2, triplet.Item3) };
                                
                                foreach(var tuple in tupleList)
                                {
                                    Console.WriteLine(tuple);
                                }
                                
                                // To check the nums combinations, where sum eqaul to 0
                                
                                var tupleList1 = new List<(int, int, int)> { (nums[triplet.Item1], nums[triplet.Item2], nums[triplet.Item3]) };
                                {
                                    Console.WriteLine(tuple1);
                                }                      
                                
                            }
                            
                            
                        }
                    }
                }
            }

        }
    }
}
