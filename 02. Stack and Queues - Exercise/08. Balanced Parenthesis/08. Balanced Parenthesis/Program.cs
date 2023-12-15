namespace _08._Balanced_Parenthesis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char[] array = new char[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                array[i] = input[i];
            }

            Queue<char> patern1 = new Queue<char>();
            Stack<char> patern2 = new Stack<char>();

            for (int i = 0; i < array.Length; i++)
            {
                if (i < array.Length / 2)
                {
                    patern1.Enqueue(array[i]);
                }
                else
                {
                    patern2.Push(array[i]);
                }
            }
            int count = patern1.Count;
            for (int i = 0; i < count; i++)
            {
                if ((patern1.Peek() == '{' && patern2.Peek() == '}') || (patern1.Peek() == '[' && patern2.Peek() == ']') || (patern1.Peek() == '(' && patern2.Peek() == ')'))
                {
                    if (patern1.Count == 1)
                    {
                        Console.WriteLine("YES");
                    }
                    patern1.Dequeue();
                    patern2.Pop();
                }
                else
                {
                    Console.WriteLine("NO");
                    break;
                }
            }
        }
    }
}
