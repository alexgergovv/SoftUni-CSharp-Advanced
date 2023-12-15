namespace _03._Primary_Diagonal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int[,] matrix = new int[input, input];
            int sum = 0;

            for (int row = 0; row < input; row++)
            {
                int[] nums = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                for (int col = 0; col < input; col++)
                {
                    matrix[row, col] = nums[col];
                }
            }

            for (int row = 0; row < input; row++)
            {
                for (int col = 0; col < input; col++)
                {
                    if (row == col)
                    {
                        sum += matrix[row, col];
                    }
                }
            }
            Console.WriteLine(sum);
        }
    }
}
