namespace OOP_Labb2_Arv
{
    internal class McLaren : Car
    {              
            public bool HasLuxuryInterior { get; set; } = true;

            public McLaren()
            {
                Brand = "McLaren";
                Model = "720S";
                HorsePower = 720;
                MaxSpeed = 341;
                TypeOfVehicle = "Superbil";
                Worth = 2300000;
            }

            
        
            public void ActivateComfortMode()
            {
                Console.WriteLine("McLaren aktiverar komfortläget mjukare fjädring och tystare motorljud.");
            }

            public override void StartEngine()
            {
                Console.WriteLine("McLaren låter tyst");
            }
        

    }
}
