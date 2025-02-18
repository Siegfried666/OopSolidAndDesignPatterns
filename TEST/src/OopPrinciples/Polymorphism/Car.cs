namespace TEST.src.OopPrinciples.Polymorphism
{
    public class Car : Vehicule
    {
        public int NumberOfDoors { get; set; }
        public int NumberOfWheels { get; set; }

        public override void Start()
        {
            Console.WriteLine("Car is starting");
        }

        public override void Stop()
        {
            Console.WriteLine("Car is stoppîng");
        }
    }

}