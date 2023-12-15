namespace _02._Stack_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> stack = new Stack<int>(input);
            var command = Console.ReadLine().ToLower();

            while (command != "end")
            {
                var cmnds = command.Split(" ");
                var com = cmnds[0].ToLower();
                if (com == "add")
                {
                    for (int i = 1; i <= 2; i++)
                    {
                        stack.Push(int.Parse(cmnds[i]));
                    }
                }
                else if (com == "remove")
                {
                    if (int.Parse(cmnds[1]) < stack.Count)
                    {

                        for (int i = 0; i < int.Parse(cmnds[1]); i++)
                        {
                            stack.Pop();
                        }
                    }
                }
                command = Console.ReadLine().ToLower();
            }
            int sum = stack.Sum();
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
