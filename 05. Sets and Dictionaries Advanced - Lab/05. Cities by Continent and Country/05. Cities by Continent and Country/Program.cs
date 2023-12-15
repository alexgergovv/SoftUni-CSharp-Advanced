namespace _05._Cities_by_Continent_and_Country
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, List<string>>> continentData = new Dictionary<string, Dictionary<string, List<string>>>();

            for (int i = 0; i < N; i++)
            {
                string[] command = Console.ReadLine().Split(" ");
                string continent = command[0];
                string country = command[1];
                var city = command[2];
                if (!continentData.ContainsKey(continent))
                {
                    continentData.Add(continent, new Dictionary<string, List<string>>());
                }
                if (!continentData[continent].ContainsKey(country))
                {
                    continentData[continent].Add(country, new List<string>());
                }
                continentData[continent][country].Add(city);
            }
            foreach (var el in continentData)
            {
                Console.WriteLine($"{el.Key}:");
                var current = el.Value;

                foreach (var els in current)
                {
                    Console.WriteLine($"  {els.Key} -> {string.Join(", ", els.Value)}");
                }
            }
        }
    }
}
