namespace TEST.src.SOLID.dISP
{
    //BAD
    // public class Circle : IShape
    //GOOD
    public class Circle : IShape2D
    {
        public double Radius { get; set; }
        public double Area()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        // BAD: 2D shape n'ont pas de Volume !
        // public double Volume()
        // {
        //     throw new InvalidOperationException("Volume not applicable to the 2D shapes");
        // }
    }
}