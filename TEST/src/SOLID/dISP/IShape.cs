namespace TEST.src.SOLID.dISP
{

    //BAD: Segregation de IShape en 2 interface=> IShape2D, IShape3D
    public interface IShape
    {
        double Area();
        double Volume();
    }

    //GOOD
    public interface IShape2D
    {
        double Area();
    }

    //GOOD
    public interface IShape3D
    {
        double Volume();
    }
}