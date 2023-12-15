namespace _04._Fast_Food
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int quantityFood = int.Parse(Console.ReadLine());
            int[] array = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            Queue<int> queue = new Queue<int>(array);
            int biggestOrder = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (quantityFood >= array[i])
                {
                    quantityFood -= array[i];
                    if (array[i] > biggestOrder)
                    {
                        biggestOrder = array[i];
                    }
                    queue.Dequeue();

                }
                else
                {
                    break;
                }
            }
            Console.WriteLine(biggestOrder);
            if (queue.Count > 0)
            {
                Console.WriteLine("Orders left: " + string.Join(" ", queue));
            }
            else
            {
                Console.WriteLine("Orders complete");
            }
        }
    }
}
