namespace TEST.src.OopPrinciples.Polymorphism
{

    public class Vehicule
    {

        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public virtual void Start()
        {
            Console.WriteLine("Vehicule is starting");
        }

        public virtual void Stop()
        {
            Console.WriteLine("Vehicule is stopping");
        }
    }
}