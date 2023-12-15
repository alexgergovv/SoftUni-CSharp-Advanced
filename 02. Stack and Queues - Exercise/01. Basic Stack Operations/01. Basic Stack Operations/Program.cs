namespace _01._Basic_Stack_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            int[] array = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int N = array[0];
            int S = array[1];
            int X = array[2];
            int[] addedNums = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            for (int i = 0; i < N; i++)
            {
                stack.Push(addedNums[i]);
            }

            for (int i = 0; i < S; i++)
            {
                stack.Pop();
            }
            if (stack.Contains(X))
            {
                Console.WriteLine("true");
            }
            else if (stack.Count == 0)
            {
                Console.WriteLine("0");
            }
            else
            {
                Console.WriteLine(stack.Min());
            }
        }
    }
}
