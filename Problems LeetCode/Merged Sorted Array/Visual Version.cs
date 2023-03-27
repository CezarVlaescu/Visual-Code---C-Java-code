using System.Security.Cryptography.X509Certificates;

class Solution
{
    static void Main(string[] args)
    {
        int[] nums1 = { 1, 4, 5, 6, 0, 0 };
        int[] nums2 = { 0 , 0 , 2, 0, 1 };
        int m,n;
        m = nums1.Length;
        n = nums2.Length;
        
         
        for(int i  = 0; i < nums1.Length; i++)
        {
            if (nums1[i] == 0)
            {
                nums1 = nums1.Where(e => e != nums1[i]).ToArray();
                m = nums1.Length;
            }
        }
        // Console.WriteLine(m);
        
        for (int j = 0; j < nums2.Length; j++)
        {
            if (nums2[j] == 0)
            {
                nums2 = nums2.Where(l => l != nums2[j]).ToArray();
                n = nums2.Length;
            }
        }
        // Console.WriteLine(n);

        int resultLenght = m + n;
        // Console.WriteLine(resultLenght);

        int[] result = new int[resultLenght];
        result = nums1.Union(nums2).ToArray(); 
        Array.Sort(result);
        foreach(int k in result)
        {
            Console.WriteLine(k);   
        }
    }
}
