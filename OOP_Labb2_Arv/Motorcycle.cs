namespace OOP_Labb2_Arv
{
    internal class Motorcycle : Vehicle
    {
        public string SportsMode { get; set; } = "Off";

        public void TurnOnSportsMode()
        {

        }

        public override void StartEngine()
        {
            Console.WriteLine("Motorcykeln låter vrrrrrvrrrrr");
        }
    }
}
