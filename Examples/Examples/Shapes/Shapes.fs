namespace Shapes

[<AbstractClass>]
type Shape(x, y) =
    member This.X = x;
    member This.Y = y;
    abstract Area : int with get
    default this.Area = this.X  * this.Y;
    abstract Perimeter : int with get
    default this.Perimeter = this.X*2 + this.Y*2;