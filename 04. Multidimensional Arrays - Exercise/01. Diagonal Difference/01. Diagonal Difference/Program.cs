namespace _01._Diagonal_Difference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[,] matrix = new int[size, size];
            int primaryDiagonal = 0;
            int secondaryDiagonal = 0;

            for (int row = 0; row < size; row++)
            {
                int[] nums = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                for (int col = 0; col < size; col++)
                {
                    matrix[row, col] = nums[col];
                }
            }

            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    if (row == col)
                    {
                        primaryDiagonal += matrix[row, col];
                    }
                }
            }
            for (int i = size - 1; i >= 0; i--)
            {
                secondaryDiagonal += matrix[i, size - i - 1];
            }

            Console.WriteLine(Math.Abs(primaryDiagonal - secondaryDiagonal));
        }
    }
}
