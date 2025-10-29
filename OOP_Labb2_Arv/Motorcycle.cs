namespace OOP_Labb2_Arv
{
    internal class Motorcycle : Vehicle
    {

        public Motorcycle()
        {
            HorsePower = 100;
            MaxSpeed = 180;
            Brand = "Suzuki";
            Model = "GSX-R750";
            ProductionYear = 2020;
            Worth = 100000;
            TypeOfVehicle = "Motorcykel";
        }
        public string SportsMode { get; set; } = "Off";

        public void TurnOnSportsMode()
        {
            if (SportsMode == "Off")
            {
                SportsMode = "On";
                Console.WriteLine("Sportläget är på");
            }
            else
            {
                SportsMode = "Off";
                Console.WriteLine("Sportläget är av");
            }
        }

        public override void StartEngine()
        {
            Console.WriteLine("Motorcykeln låter vrrrrrvrrrrr");
        }
    }
}
