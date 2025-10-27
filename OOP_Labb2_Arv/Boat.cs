namespace OOP_Labb2_Arv
{
    internal class Boat : Vehicle
    {
        public string Sails { get; set; } = "Using motor";

        public void UseSails()
        {

        }

        public override void StartEngine()
        {
            Console.WriteLine("Båten låter brrrrrrrrrrrr");
        }
    }
}
