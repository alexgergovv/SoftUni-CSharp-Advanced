namespace _03._Periodic_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            SortedSet<string> set = new SortedSet<string>();

            for (int i = 0; i < n; i++)
            {
                string info = Console.ReadLine();
                string[] input = info.Split(" ");
                foreach (string item in input)
                {
                    set.Add(item);
                }
            }

            Console.WriteLine(string.Join(" ", set));
        }
    }
}
