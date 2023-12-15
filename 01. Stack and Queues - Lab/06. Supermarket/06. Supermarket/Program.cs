namespace _06._Supermarket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Queue<string> queue = new Queue<string>();

            while (input != "End")
            {
                if (input == "Paid")
                {
                    string[] array = queue.ToArray();
                    for (int i = 0; i < array.Length; i++)
                    {
                        Console.WriteLine(array[i]);
                    }
                    queue.Clear();
                }
                else
                {
                    queue.Enqueue(input);
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"{queue.Count} people remaining.");
        }
    }
}
