namespace _06._Jagged_Array_Manipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[][] jagged = new int[N][];

            for (int row = 0; row < N; row++)
            {
                jagged[row] = Console.ReadLine().Split().Select(int.Parse).ToArray();
            }
            for (int row = 0; row < N - 1; row++)
            {
                if (jagged[row].Length == jagged[row + 1].Length)
                {
                    jagged[row] = jagged[row].Select(el => el * 2).ToArray();
                    jagged[row + 1] = jagged[row + 1].Select(el => el * 2).ToArray();
                }
                else
                {
                    jagged[row] = jagged[row].Select(el => el / 2).ToArray();
                    jagged[row + 1] = jagged[row + 1].Select(el => el / 2).ToArray();
                }
            }
            string command = Console.ReadLine();

            while (command != "End")
            {
                int row = int.Parse(command.Split()[1]);
                int col = int.Parse(command.Split()[2]);
                int value = int.Parse(command.Split()[3]);

                if (command.StartsWith("Add"))
                {
                    if (row >= 0 && row < N && col >= 0 && col < jagged[row].Length)
                    {
                        jagged[row][col] += value;
                    }
                }
                else if (command.StartsWith("Subtract"))
                {
                    if (row >= 0 && row < N && col >= 0 && col < jagged[row].Length)
                    {
                        jagged[row][col] -= value;
                    }
                }
                command = Console.ReadLine();
            }
            foreach (int[] row in jagged)
            {
                Console.WriteLine(String.Join(' ', row));
            }
        }
    }
}
