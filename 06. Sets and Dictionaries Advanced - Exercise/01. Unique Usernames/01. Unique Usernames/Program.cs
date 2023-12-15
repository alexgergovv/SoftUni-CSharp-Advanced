namespace _01._Unique_Usernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> usernames = new HashSet<string>();
            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                string username = Console.ReadLine();
                usernames.Add(username);
            }
            foreach (var username in usernames)
            {
                Console.WriteLine(username);
            }
        }
    }
}
