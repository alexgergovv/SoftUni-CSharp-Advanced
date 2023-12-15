namespace _03._Simple_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split().ToArray();
            Stack<string> mathProblem = new Stack<string>();
            int result = 0;
            for (int i = input.Length - 1; i >= 0; i--)
            {
                mathProblem.Push(input[i]);
            }
            int stackCount = mathProblem.Count;
            string symbol = string.Empty;
            for (int i = 0; i < stackCount; i++)
            {
                if (mathProblem.Peek() == "-")
                {
                    mathProblem.Pop();
                    symbol = "-";
                }
                else if (mathProblem.Peek() == "+")
                {
                    mathProblem.Pop();
                    symbol = "+";
                }
                else
                {
                    if (i == 0 || symbol == "+")
                    {
                        result += int.Parse(mathProblem.Pop());
                    }
                    else if (symbol == "-")
                    {
                        result -= int.Parse(mathProblem.Pop());
                    }
                    symbol = string.Empty;
                }

            }
            Console.WriteLine(result);
        }
    }
}
