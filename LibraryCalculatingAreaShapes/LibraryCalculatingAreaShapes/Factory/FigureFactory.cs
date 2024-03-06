using LibraryCalculatingAreaShapes.Figures;

namespace LibraryCalculatingAreaShapes.Factory;

public class FigureFactory : IFigureFactory
{
    #region Public Methods

    public Circle CreateCircle(double radius)
    {
        var circle = new Circle(radius);
        circle.Validate();

        return circle;
    }

    public Triangle CreateTriangle(
        double side1,
        double side2,
        double side3)
    {
        var triangle = new Triangle(side1, side2, side3);
        triangle.Validate();

        return triangle;
    }

    #endregion
}