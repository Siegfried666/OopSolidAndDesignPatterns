namespace TEST.src.OopPrinciples.Polymorphism
{
    public class Motocycle : Vehicule
    {
        public override void Start()
        {
            Console.WriteLine("Motocycle is starting");
        }

        public override void Stop()
        {
            Console.WriteLine("Motocycle is stoppîng");
        }
    }

}