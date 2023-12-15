namespace _07._Parking_Lot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cars = new HashSet<string>();

            var input = Console.ReadLine().Split(", ");
            while (input[0] != "END")
            {
                if (input[0] == "IN")
                {
                    cars.Add(input[1]);
                }
                else if (input[0] == "OUT")
                {
                    cars.Remove(input[1]);
                }
                input = Console.ReadLine().Split(", ");
            }
            if (cars.Count > 0)
            {
                foreach (var car in cars)
                    Console.WriteLine(car);
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }
    }
}
