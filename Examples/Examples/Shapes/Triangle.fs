namespace Shapes

type Triangle(x,y) =
        inherit Shape(x,y)
        override this.Area = (x * y) / 2;
