namespace _04._Matrix_Shuffling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            string[,] matrix = new string[input[0], input[1]];

            for (int row = 0; row < input[0]; row++)
            {
                string[] symbols = Console.ReadLine().Split(" ");
                for (int col = 0; col < input[1]; col++)
                {
                    matrix[row, col] = symbols[col];
                }
            }

            while (true)
            {
                string command = Console.ReadLine();
                string[] commandParts = command.Split();

                if (command == "END")
                {
                    break;
                }

                if (commandParts[0] == "swap" && commandParts.Length == 5)
                {
                    int row1 = int.Parse(commandParts[1]);
                    int col1 = int.Parse(commandParts[2]);
                    int row2 = int.Parse(commandParts[3]);
                    int col2 = int.Parse(commandParts[4]);

                    if (row1 >= 0 && row1 < matrix.GetLength(0) && col1 >= 0 && col1 < matrix.GetLength(1) &&
                        row2 >= 0 && row2 < matrix.GetLength(0) && col2 >= 0 && col2 < matrix.GetLength(1))
                    {
                        string value = matrix[row1, col1];
                        matrix[row1, col1] = matrix[row2, col2];
                        matrix[row2, col2] = value;
                        for (int row = 0; row < matrix.GetLength(0); row++)
                        {
                            for (int col = 0; col < matrix.GetLength(1); col++)
                            {
                                Console.Write(matrix[row, col] + " ");
                            }
                            Console.WriteLine();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }

            }
        }
    }
}
