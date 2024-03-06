using LibraryCalculatingAreaShapes.Figures;

namespace LibraryCalculatingAreaShapes.Factory;

public interface IFigureFactory
{
    #region Public Methods

    public Circle CreateCircle(double radius);

    public Triangle CreateTriangle(double side1, double side2, double side3);

    #endregion
}