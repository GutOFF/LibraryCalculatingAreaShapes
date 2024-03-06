using LibraryCalculatingAreaShapes.Calculator;
using LibraryCalculatingAreaShapes.Validation;

namespace LibraryCalculatingAreaShapes.Figures;

public abstract class FigureBase : IFigureCalculator, IValidator
{
    #region Public Methods

    public abstract double CalculateArea();

    public abstract double CalculatePerimeter();

    public abstract void Validate();

    #endregion
}