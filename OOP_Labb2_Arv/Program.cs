namespace OOP_Labb2_Arv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Transportföretagets fordon\n");

            Car car1 = new Car();
            Boat boat1 = new Boat();
            Motorcycle MC1 = new Motorcycle();
            Mercedes mercedes1 = new Mercedes();
            McLaren mclaren1 = new McLaren();

            car1.ShowAllInfo();
            car1.StartEngine();
            Console.WriteLine();

            boat1.ShowAllInfo();
            boat1.StartEngine();
            Console.WriteLine();

            MC1.ShowAllInfo();
            MC1.StartEngine();
            Console.WriteLine();

            mercedes1.ShowAllInfo();
            mercedes1.EngageSportMode();
            mercedes1.StartEngine();            
            Console.WriteLine();

            mclaren1.ShowAllInfo();
            mclaren1.ActivateComfortMode();
            mclaren1.StartEngine();            
            Console.WriteLine();
        }
    }
}
