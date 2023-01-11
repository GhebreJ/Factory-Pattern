namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the vehicle factory! How many wheels does vehicle have? :");
            var vehicle = VehicleFactory.GetVehicle(int.Parse(Console.ReadLine()));

            vehicle.Drive();
        }
    }
}
