namespace _05._Square_With_Maximum_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int[,] matrix = new int[input[0], input[1]];

            for (int row = 0; row < input[0]; row++)
            {
                int[] nums = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                for (int col = 0; col < input[1]; col++)
                {
                    matrix[row, col] = nums[col];
                }
            }
            int sum = 0;
            int biggestSum = 0;
            int[,] biggestSquare = new int[2, 2];
            for (int row = 1; row < input[0]; row++)
            {
                for (int col = 1; col < input[1]; col++)
                {
                    sum = matrix[row - 1, col - 1] + matrix[row - 1, col] + matrix[row, col - 1] + matrix[row, col];
                    if (sum > biggestSum)
                    {
                        biggestSum = sum;
                        sum = 0;
                        biggestSquare[0, 0] = matrix[row - 1, col - 1];
                        biggestSquare[0, 1] = matrix[row - 1, col];
                        biggestSquare[1, 0] = matrix[row, col - 1];
                        biggestSquare[1, 1] = matrix[row, col];
                    }
                }
            }
            for (int row = 0; row < 2; row++)
            {
                for (int col = 0; col < 2; col++)
                {
                    Console.Write(biggestSquare[row, col] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine(biggestSum);
        }
    }
}
