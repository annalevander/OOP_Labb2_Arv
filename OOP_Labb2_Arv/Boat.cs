namespace OOP_Labb2_Arv
{
    internal class Boat : Vehicle
    {
        public Boat()
        {
            HorsePower = 100;
            MaxSpeed = 180;
            Brand = "Nimbus";
            Model = "C9";
            ProductionYear = 2021;
            Worth = 300000000;
            TypeOfVehicle = "Båt";
        }
        public string Sails { get; set; } = "Using motor";

        public void UseSails()
        {
            if (Sails == "Using motor")
            {
                Sails = "Using sails";
                Console.WriteLine("Båten använder nu seglen.");
            }
        }

        public void UseMotor()
        {
            if (Sails == "Using sails")
            {
                Sails = "Using Motor";
                Console.WriteLine("Båten använder nu motor.");
            }
        }

        public override void StartEngine()
        {
            Console.WriteLine("Båten låter brrrrrrrrrrrr");
        }
    }
}
