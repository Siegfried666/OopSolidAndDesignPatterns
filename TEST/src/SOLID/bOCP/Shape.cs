namespace TEST.src.SOLID.bOCP
{
    //BAD: Transformé en classe Abstract pour être overridée suivant les besoins !
    // public class Shape
    public abstract class Shape
    {
        //BAD: ne respecte pas OCP
        // public ShapeType Type { get; set; }
        // public double Radius { get; set; }
        // public double Length { get; set; }
        // public double Width { get; set; }

        // OCP:Si on ajoute a ShapeType un triangle, on est obligé de modifier CalculateArea et ajouter un case dans le switch, ajouter une propriété liée au triangle etc.
        // public double CalculateArea()
        public abstract double CalculateArea();
        //{
        // switch (Type)
        // {
        //     case ShapeType.Circle:
        //         return Math.PI * Math.Pow(Radius, 2);
        //     case ShapeType.Rectangle:
        //         return Length * Width;
        //     default:
        //         throw new InvalidOperationException("Unsupported shape type");
        // }
        // }

    }
}