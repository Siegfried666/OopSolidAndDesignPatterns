namespace TEST.src.SOLID.eDIP
{
    public class Car
    {
        //BAD
        // private Engine engine;

        //GOOD
        private IEngine engine;

        //BAD
        // public Car(IEngine engine)

        //GOOD
        public Car(IEngine engine)
        {
            this.engine = engine;
        }

        public void StartCar()
        {
            engine.Start();
            Console.WriteLine("Car Started");
        }
    }
}