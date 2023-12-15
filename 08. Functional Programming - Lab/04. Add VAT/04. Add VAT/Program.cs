namespace _04._Add_VAT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] array = Console.ReadLine()
                .Split(", ")
                .Select(double.Parse)
                .ToArray();

            foreach (double x in array)
            {
                Console.WriteLine($"{(x * 1.2):f2}");
            }
        }
    }
}
