namespace Shapes

type Square(x) =
    inherit Shape(x,x)
    override this.Area = x * x;
    override this.Perimeter = x * 4;