namespace _02._Sum_Matrix_Columns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int[,] matrix = new int[input[0], input[1]];
            int sum = 0;

            for (int row = 0; row < input[0]; row++)
            {
                int[] nums = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                for (int col = 0; col < input[1]; col++)
                {
                    matrix[row, col] = nums[col];
                }
            }

            for (int col = 0; col < input[1]; col++)
            {
                for (int row = 0; row < input[0]; row++)
                {
                    sum += matrix[row, col];
                }
                Console.WriteLine(sum);
                sum = 0;
            }
        }
    }
}
