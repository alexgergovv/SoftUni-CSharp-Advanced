namespace _05._Count_Symbols
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char[] brackets = new char[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                brackets[i] = input[i];
            }

            SortedDictionary<char, int> data = new SortedDictionary<char, int>();

            for (int i = 0; i < brackets.Length; i++)
            {
                if (!data.ContainsKey(brackets[i]))
                {
                    data[brackets[i]] = 1;
                }
                else
                {
                    data[brackets[i]]++;
                }
            }
            foreach (var el in data)
            {
                Console.WriteLine(el.Key + ": " + el.Value + " time/s");
            }
        }
    }
}
