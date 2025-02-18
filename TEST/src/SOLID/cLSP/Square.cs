namespace TEST.src.SOLID.cLSP
{

    //BAD: Liskov Substitution principle: on doit pouvoir substituer une superclasse (Rectangle) par une sub classe (Square) et avoir les mêmes resultats, ici ce n'est pas possible !
    // public class Square : Rectangle
    public class Square : Shape
    {
        // public override double Width
        // {
        //     get => base.Width;
        //     set => base.Width = base.Height = value;
        // }

        // public override double Height
        // {
        //     get => base.Height;
        //     set => base.Height = base.Width = value;
        // }

        public double SideLength { get; set; }

        public override double Area => SideLength * SideLength;
    }
}