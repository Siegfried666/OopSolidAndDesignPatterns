namespace TEST.src.OopPrinciples.Polymorphism
{
    public class Plane : Vehicule
    {
         public override void Start()
        {
            Console.WriteLine("Plane is starting");
        }

        public override void Stop()
        {
            Console.WriteLine("Plane is stoppîng");
        }
    }

}