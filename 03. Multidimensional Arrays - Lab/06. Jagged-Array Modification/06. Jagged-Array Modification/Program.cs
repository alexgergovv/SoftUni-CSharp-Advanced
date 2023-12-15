namespace _06._Jagged_Array_Modification
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int[][] jagged = new int[input][];

            for (int r = 0; r < jagged.Length; r++)
            {
                jagged[r] = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            }

            while (true)
            {
                string[] command = Console.ReadLine().Split(" ");
                if (command[0] == "END")
                {
                    break;
                }
                if ((int.Parse(command[1]) >= 0 && int.Parse(command[1]) < input) && (int.Parse(command[2]) >= 0
                    && int.Parse(command[2]) < input))
                {

                    if (command[0] == "Add")
                    {
                        jagged[int.Parse(command[1])][int.Parse(command[2])] += int.Parse(command[3]);
                    }
                    else if (command[0] == "Subtract")
                    {
                        jagged[int.Parse(command[1])][int.Parse(command[2])] -= int.Parse(command[3]);
                    }
                }
                else
                {
                    Console.WriteLine("Invalid coordinates");
                }
            }
            for (int row = 0; row < input; row++)
            {
                for (int col = 0; col < input; col++)
                {
                    Console.Write(jagged[row][col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
