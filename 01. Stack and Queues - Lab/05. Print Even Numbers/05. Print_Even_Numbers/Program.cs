namespace _05._Print_Even_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> queue = new Queue<int>();
            foreach (var ch in input)
            {
                if (ch % 2 == 0)
                {
                    queue.Enqueue(ch);
                }
            }
            int[] array = queue.ToArray();
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
                if (i < array.Length - 1)
                {
                    Console.Write(", ");
                }
            }
        }
    }
}
