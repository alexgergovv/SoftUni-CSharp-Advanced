namespace _02._Sets_of_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int N = input[0];
            int M = input[1];
            HashSet<int> setOne = new HashSet<int>();
            HashSet<int> setTwo = new HashSet<int>();

            for (int i = 0; i < N; i++)
            {
                setOne.Add(int.Parse(Console.ReadLine()));
            }
            for (int i = 0; i < M; i++)
            {
                setTwo.Add(int.Parse(Console.ReadLine()));
            }
            setOne.IntersectWith(setTwo);
            foreach (var item in setOne)
            {
                Console.Write(item + " ");
            }
        }
    }
}
