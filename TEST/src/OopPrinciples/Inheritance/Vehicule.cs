namespace TEST.src.OopPrinciples.Inheritance
{

    public class Vehicule
    {

        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public void Start()
        {
            Console.WriteLine("Vehicule is starting");
        }

        public void Stop()
        {
            Console.WriteLine("Vehicule is stopping");
        }
    }
}