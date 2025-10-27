namespace OOP_Labb2_Arv
{
    internal class Car : Vehicle
    {
        public string Color { get; set; } = "Red";

        public void ChangeColor()
        {

        }

        public override void StartEngine()
        {
            Console.WriteLine("Bilen låter bruum bruum");
        }
    }
}
