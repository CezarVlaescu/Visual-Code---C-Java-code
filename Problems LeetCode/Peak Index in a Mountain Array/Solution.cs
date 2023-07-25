class Solution
{
    static void Main(string[] args)
    {
        int[] ints = { 0, 1, 0 };
        Console.WriteLine(PeakIndexInMountainArray(ints));
    }

    static public int PeakIndexInMountainArray(int[] array)
    {
        int index = 0;

        for(int i = index; index < array.Length; index++) 
        {
            if(LengthCheck(array) && CompareCheck(array, index) && IsGreater(array))
            {
                return index;
            }
        }
        return -1;
    }

    static bool LengthCheck(int[] array)
    {
        return array.Length >= 3;
    }

    static bool CompareCheck(int[] array, int index)
    {
        return 0 < index && index < array.Length - 1;
    }

    static bool IsGreater(int[] array) 
    {
        for(int i =0; i < array.Length; i++)
        {
            if (array[i] < array[i + 1])
            {
                return true;
            }
        }
        return false;
    }
}
