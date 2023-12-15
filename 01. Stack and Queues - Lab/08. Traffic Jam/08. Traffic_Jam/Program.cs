namespace _08._Traffic_Jam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            Queue<string> queue = new Queue<string>();
            int carsPassed = 0;

            while (input != "end")
            {
                if (input == "green")
                {
                    for (int i = 0; i < number; i++)
                    {
                        if (queue.Count > 0)
                        {
                            Console.WriteLine(queue.Dequeue() + " passed!");
                            carsPassed++;
                        }
                        else
                        {
                            continue;
                        }
                    }
                }
                else
                {
                    queue.Enqueue(input);
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"{carsPassed} cars passed the crossroads.");
        }
    }
}
