namespace _05._Fashion_Boutique
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!"); Queue<int> queue = new Queue<int>(Console.ReadLine().Split(" ").Select(int.Parse).ToArray());
            int capacity = int.Parse(Console.ReadLine());
            int count = queue.Count;
            int sum = 0;
            int output = 0;

            for (int i = 0; i < count; i++)
            {
                while (queue.Count > 0)
                {
                    if (queue.Count == 1 && queue.Peek() + sum <= capacity)
                    {
                        output++;
                        queue.Dequeue();
                    }
                    else if (queue.Peek() + sum <= capacity)
                    {
                        sum += queue.Peek();
                        queue.Dequeue();
                    }
                    else if (queue.Peek() + sum == capacity)
                    {
                        sum += queue.Peek();
                        queue.Dequeue();
                        output++;
                    }
                    else
                    {
                        output++;
                        sum = 0;
                        break;
                    }

                }
            }
            Console.WriteLine(output);
        }
    }
}
