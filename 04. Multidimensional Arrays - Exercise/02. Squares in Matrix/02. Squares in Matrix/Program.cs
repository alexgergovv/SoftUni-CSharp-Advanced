namespace _02._Squares_in_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            char[,] matrix = new char[size[0], size[1]];
            char[] bestNums = new char[4];


            for (int row = 0; row < size[0]; row++)
            {
                char[] letters = Console.ReadLine().Split(" ").Select(char.Parse).ToArray();
                for (int col = 0; col < size[1]; col++)
                {
                    matrix[row, col] = letters[col];
                }
            }

            int count = 0;

            for (int row = 1; row < size[0]; row++)
            {
                for (int col = 1; col < size[1]; col++)
                {
                    if (matrix[row - 1, col - 1] == matrix[row, col] && matrix[row, col] == matrix[row, col - 1] && matrix[row, col] == matrix[row - 1, col])
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}
