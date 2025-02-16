class Arrayclass
{
    // 1. Kadane’s Algorithm - Maximum Subarray Sum
    public void maxsum(int[] arr)
    {
        int nowSum = arr[0];
        int bigSum = arr[0];

        for (int i = 1; i < arr.Length; i++)
        {
            nowSum = Math.Max(arr[i], nowSum + arr[i]);
            bigSum = Math.Max(bigSum, nowSum);
        }

        Console.WriteLine("Max Sum of SubArray: " + bigSum);
    }

    // 2. Find Intersection and Union of Two Arrays
    

    // 3. Sparse Matrix Multiplication
   
        

    // 4. Find First Missing Positive Integer
    public void firstMissingNum(int[] num)
    {
        int n = num.Length;

        for (int i = 0; i < n; i++)
        {
            while (num[i] > 0 && num[i] <= n && num[num[i] - 1] != num[i])
            {
                int temp = num[num[i] - 1];
                num[num[i] - 1] = num[i];
                num[i] = temp;
            }
        }

        for (int i = 0; i < n; i++)
        {
            if (num[i] != i + 1)
            {
                Console.WriteLine("Smallest Missing Num: " + (i + 1));
                return;
            }
        }

        Console.WriteLine("Smallest Missing Num: " + (n + 1));
    }

    // 5. Rotate 2D Matrix 90 Degrees Clockwise
    public void rotateMat(int[,] mat)
    {
        int n = mat.GetLength(0);

        // Swap across diagonal
        for (int i = 0; i < n; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                int temp = mat[i, j];
                mat[i, j] = mat[j, i];
                mat[j, i] = temp;
            }
        }

        // Flip horizontally
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n / 2; j++)
            {
                int temp = mat[i, j];
                mat[i, j] = mat[i, n - 1 - j];
                mat[i, n - 1 - j] = temp;
            }
        }

        Console.WriteLine("Turned Matrix:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(mat[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}

class Program
{
    static void Main()
    {
        Arrayclass obj = new Arrayclass();

        // 1. Test Kadane’s Algorithm
        Console.WriteLine("Max Sum SubArray");
        int[] arr = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
        obj.maxsum(arr);
        Console.WriteLine();

        // 2. Test Intersection and Union
       

        // 3. Test Sparse Matrix Multiplication
        

        // 4. Test First Missing Positive Integer
        Console.WriteLine("first missing positive integer");
        int[] num = { 3, 4, -1, 1 };
        obj.firstMissingNum(num);
        Console.WriteLine();

        // 5. Test Rotate 2D Matrix 90 Degrees Clockwise
        Console.WriteLine("2D matrix (NxN) 90 degrees clockwise");
        int[,] mat = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
        obj.rotateMat(mat);
    }
}
