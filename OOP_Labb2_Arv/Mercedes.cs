namespace OOP_Labb2_Arv
{
    internal class Mercedes : Car
    {        
            public string DriveMode { get; set; } = "Normal";

            public Mercedes()
            {
                Brand = "Mercedes";
                Model = "C63 AMG";
                HorsePower = 450;
                MaxSpeed = 250;
                TypeOfVehicle = "Sportbil";
                Worth = 900000;
            }

            public void EngageSportMode()
            {
                DriveMode = "Sport";
                Console.WriteLine("Mercedesen växlar till sportläge!");
            }

            public override void StartEngine()
            {
                Console.WriteLine("Mercedesen låter VROOOOOM!");
            }        
    }
}
