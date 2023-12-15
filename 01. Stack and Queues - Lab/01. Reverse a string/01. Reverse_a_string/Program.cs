namespace _01._Reverse_a_string
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var stack = new Stack<char>();
            foreach (var ch in input)
            {
                stack.Push(ch);
            }
            while (stack.Count > 0)
            {
                Console.Write(stack.Pop());
            }
            Console.WriteLine();
        }
    }
}
