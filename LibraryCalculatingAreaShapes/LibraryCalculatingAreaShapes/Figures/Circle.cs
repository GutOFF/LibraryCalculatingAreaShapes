namespace LibraryCalculatingAreaShapes.Figures;

public class Circle : FigureBase
{
    #region Private Field

    private readonly double radius;

    #endregion

    #region Constructors

    internal Circle(double radius)
    {
        this.radius = radius;
    }

    #endregion

    #region Public Methods

    public override double CalculateArea()
    {
        return Math.PI * Math.Pow(this.radius, 2);
    }

    public override double CalculatePerimeter()
    {
        return 2 * Math.PI * this.radius;
    }

    public override void Validate()
    {
        if (this.radius <= 0)
        {
            throw new ArgumentException("Radius must be a positive number.");
        }
    }

    #endregion
}