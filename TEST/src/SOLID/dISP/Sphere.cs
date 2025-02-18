namespace TEST.src.SOLID.dISP
{

    //BAD
    // public class Sphere : IShape
    //GODD
    public class Sphere : IShape3D
    {
        public double Radius { get; set; }
        public double Area()
        {
            return 4 * Math.PI * Math.Pow(Radius, 2);
        }

        // BAD: 2D shape n'ont pas de Volume à partir de IShape !
        public double Volume()
        {
            return (4.0 / 3.0) * Math.PI * Math.Pow(Radius, 3);
        }
    }
}