namespace OOP_Labb2_Arv
{
    internal class Car : Vehicle
    {
        public Car()
        {
            HorsePower = 100;
            MaxSpeed = 180;
            Brand = "Okänt";
            Model = "Standard";
            ProductionYear = 2020;
            Worth = 20000;
            TypeOfVehicle = "Bil";
        }
        public string Color { get; set; } = "Red";

        public void ChangeColor()
        {
            Console.WriteLine("Vilken färg vill du ändra bilen till");
            string newColor = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(newColor))
            {
                Color = newColor;
                Console.WriteLine($"Bilen är nu {Color}!");
            }
            else
            {
                Console.WriteLine("Ogiltigt val. bilen behåller sin färg");
            }
        }

        public override void StartEngine()
        {
            Console.WriteLine("Bilen låter bruum bruum");
        }
    }
}
