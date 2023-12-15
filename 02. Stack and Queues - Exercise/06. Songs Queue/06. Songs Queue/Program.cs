namespace _06._Songs_Queue
{
    public class Program
    {
        static void Main(string[] args)
        {
            Queue<string> queue = new Queue<string>(Console.ReadLine().Split(", "));
            string song = string.Empty;

            while (queue.Count > 0)
            {
                string command = Console.ReadLine();
                if (command == "Play")
                {
                    queue.Dequeue();
                }
                else if (command == "Show")
                {
                    Console.WriteLine(string.Join(", ", queue));
                }
                else
                {
                    for (int i = 1; i < command.Length; i++)
                    {
                        song = command.Substring(4);
                    }
                    if (queue.Contains(song))
                    {
                        Console.WriteLine($"{song} is already contained!");
                    }
                    else
                    {
                        queue.Enqueue(song);
                    }
                }
            }
            Console.WriteLine("No more songs!");
        }
    }
}
