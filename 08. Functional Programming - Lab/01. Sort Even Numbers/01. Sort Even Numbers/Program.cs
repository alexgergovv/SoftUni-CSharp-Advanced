namespace _01._Sort_Even_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
               .Split(", ")
               .Select(int.Parse)
               .Where(x => x % 2 == 0)
               .OrderBy(n => n)
               .ToArray();
            Console.WriteLine(String.Join(", ", array));
        }
    }
}
