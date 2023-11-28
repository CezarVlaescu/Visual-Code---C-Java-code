class Solution
{
    static void Main(string[] args)
    {
        int[][] matrix = new int[][] // m x n
        {
            new int[] {1, 3, 5, 7 },
            new int[] {10, 11, 16, 20 },
            new int[] {23, 30, 34, 60}
        };

        Console.WriteLine(SearchMatrix(matrix, -1));
        Console.WriteLine(SearchMatrix(matrix, 3));
    }

    public static bool SearchMatrix(int[][] matrix, int target)
    {
        int start = 0;
        int end = matrix.Length - 1;

        while (start < end)
        {
            for(int i = 0; i <= matrix.Length -1; i++)
            {
                for(int j = 0; j < matrix[i].Length - 1; j++)
                {
                    if (matrix[i][j] == target) return true;
                }
            }
            start++;
        }

        return false;
    }

    public static bool SearchMatrix2(int[][] matrix, int target)
    {
        int start = 0;
        int end = matrix.Length - 1;

        while(start < end)
        {
            int mid = start + (end - start) / 2;

            for(int i = 0; i< matrix.Length; i++)
            {
                if (matrix[i][mid] == target) return true;
                else if (matrix[i][mid] < target) start = mid + 1;
                else end = mid - 1;
            }
        }

        return false;
    }

    public static bool SearchMatrix3(int[][] matrix, int target)
    {
        int m = matrix.Length;
        int n = matrix[0].Length;
        int start = 0;
        int end = m * n - 1;

        while(start <= end)
        {
            int mid = start + (end - start) / 2;
            int mid_val = matrix[mid / n][mid % n];

            if(mid_val == target) return true;
            else if(mid_val < target) start = mid + 1;
            else end = mid - 1;
        }

        return false;
    }
}
