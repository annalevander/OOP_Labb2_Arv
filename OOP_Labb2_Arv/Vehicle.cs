namespace OOP_Labb2_Arv
{
    internal class Vehicle
    {
        public int HorsePower { get; set; }
        public int MaxSpeed { get; set; }
        public string Brand { get; set; } 
        public string Model { get; set; }
        public int ProductionYear { get; set; }
        public int Worth { get; set; }
        public string TypeOfVehicle { get; set; }

        public Vehicle (int HP, int maxSpeed, string brand, string model, int prodYear, int worth, string type)
        {
            HorsePower = HP;
            MaxSpeed = maxSpeed;
            Brand = brand;
            Model = model;
            ProductionYear = prodYear;
            Worth = worth;
            TypeOfVehicle = type;
        }

        public void Capacity()
        {
            Console.WriteLine($"Fordonets kapacitet\nFordonet har {HorsePower} hästkrafter\nFordonets maxhastighet är {MaxSpeed}");
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Fordonet är en {TypeOfVehicle}\nFordonet av märket {Brand}\nFordonets produktionsår är {ProductionYear}");
        }

        public void Price()
        {
            Console.WriteLine($"Fordonets värde är {Worth}");
        }

        public void ShowAllInfo()
        {
            Console.WriteLine($"Fordon: {TypeOfVehicle}\nMärke: {Brand}\nModell: {Model}\nProduktionsår: {ProductionYear}\nHästkrafter: {HorsePower}\nMaxhastighet: {MaxSpeed}\nVärde: {Worth}\n");
        }

        public virtual void StartEngine()
        {
            Console.WriteLine("Fordonet låter som en motor gör");
        }
    }
}
