namespace LibraryCalculatingAreaShapes.Figures;

public class Triangle : FigureBase
{
    #region Property

    public double Side1 { get; }

    public double Side2 { get; }

    public double Side3 { get; }

    #endregion

    #region Constructor

    internal Triangle(
        double side1,
        double side2,
        double side3)
    {
        this.Side1 = side1;
        this.Side2 = side2;
        this.Side3 = side3;
    }

    #endregion

    #region Public Methods

    public override double CalculateArea()
    {
        var perimeter = this.CalculatePerimeter();

        return Math.Sqrt(
            perimeter * (perimeter - this.Side1) * (perimeter - this.Side2) * (perimeter - this.Side3));
    }

    public override double CalculatePerimeter()
    {
        return (this.Side1 + this.Side2 + this.Side3) / 2;
    }

    public override void Validate()
    {
        if (this.Side1 <= 0 || this.Side2 <= 0 || this.Side3 <= 0)
        {
            throw new ArgumentException("The sides of the triangle must be positive numbers.");
        }
    }

    #endregion
}