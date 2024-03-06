using LibraryCalculatingAreaShapes.Figures;

namespace LibraryCalculatingAreaShapes.Extensions;

public static class TriangleExtension
{
    #region Public Methods

    public static bool IsRightTriangle(this Triangle triangle)
    {
        double[] sides = { triangle.Side1, triangle.Side2, triangle.Side3 };
        Array.Sort(sides);

        return Math.Abs(Math.Pow(sides[2], 2) - (Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2))) < 0.0001;
    }

    #endregion
}