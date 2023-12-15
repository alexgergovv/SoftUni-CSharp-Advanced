namespace _02._Basic_Queue_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> Queue = new Queue<int>();
            int[] array = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int N = array[0];
            int S = array[1];
            int X = array[2];
            int[] addedNums = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            for (int i = 0; i < N; i++)
            {
                Queue.Enqueue(addedNums[i]);
            }

            for (int i = 0; i < S; i++)
            {
                Queue.Dequeue();
            }
            if (Queue.Contains(X))
            {
                Console.WriteLine("true");
            }
            else if (Queue.Count == 0)
            {
                Console.WriteLine("0");
            }
            else
            {
                Console.WriteLine(Queue.Min());
            }
        }
    }
}
