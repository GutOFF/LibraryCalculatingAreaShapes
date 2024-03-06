using LibraryCalculatingAreaShapes.Extensions;
using LibraryCalculatingAreaShapes.Factory;

namespace Test;

[Parallelizable]
public class TriangleTest
{
    private readonly IFigureFactory figureFactory;

    public TriangleTest()
    {
        this.figureFactory = new FigureFactory();
    }

    [TestCaseSource(nameof(GetSide))]
    public void CalculateAreaCorrectValue(int side1, int side2, int side3, double expected)
    {
        // Arrange
        var triangle = this.figureFactory.CreateTriangle(side1, side2, side3);

        // Act
        var actualArea = triangle.CalculateArea();

        // Assert
        Assert.That(actualArea, Is.EqualTo(expected), "Incorrect figure calculation");
    }

    private static IEnumerable<TestCaseData> GetSide()
    {
        yield return new TestCaseData(1, 2, 3, 0);
        yield return new TestCaseData(3, 4, 5, 6);
        yield return new TestCaseData(1200032, 232334, 999123, 63791380681.76783);
    }

    [TestCaseSource(nameof(GetZeroSide))]
    public void CalculateAreaZeroSide(int side1, int side2, int side3)
    {
        // Act
        // Assert
        Assert.Throws<ArgumentException>(() => this.figureFactory.CreateTriangle(side1, side2, side3), "Should have received an error because they passed 0 as the side.");
    }

    private static IEnumerable<TestCaseData> GetZeroSide()
    {
        yield return new TestCaseData(0, 2, 3);
        yield return new TestCaseData(3, 0, 1);
        yield return new TestCaseData(1, 2, 0);
    }

    [TestCaseSource(nameof(GetNegativeSide))]
    public void CalculateAreaNegativeSide(int side1, int side2, int side3)
    {
        // Act
        // Assert
        Assert.Throws<ArgumentException>(() => this.figureFactory.CreateTriangle(side1, side2, side3), "Should have received an error because they passed a negative number as a side.");
    }

    private static IEnumerable<TestCaseData> GetNegativeSide()
    {
        yield return new TestCaseData(-1, 2, 3);
        yield return new TestCaseData(3, -2, 1);
        yield return new TestCaseData(1, 2, -6);
    }

    [TestCaseSource(nameof(GetRightTriangleSide))]
    public void TestRightTriangle(int side1, int side2, int side3)
    {
        // Arrange
        var triangle = this.figureFactory.CreateTriangle(side1, side2, side3);

        // Act
        var actualResult = triangle.IsRightTriangle();

        // Assert
        Assert.That(actualResult, Is.True, $"This is a regular triangle {side1}, {side2}, {side3}.");
    }

    private static IEnumerable<TestCaseData> GetRightTriangleSide()
    {
        yield return new TestCaseData(3, 4, 5);
        yield return new TestCaseData(5, 3, 4);
        yield return new TestCaseData(5, 12, 13);
        yield return new TestCaseData(8, 15, 17);
    }

    [TestCaseSource(nameof(GetNotRightTriangleSide))]
    public void TestNotRightTriangle(int side1, int side2, int side3)
    {
        // Arrange
        var triangle = this.figureFactory.CreateTriangle(side1, side2, side3);

        // Act
        var actualResult = triangle.IsRightTriangle();

        // Assert
        Assert.That(actualResult, Is.False, $"This is not a right triangle {side1}, {side2}, {side3}.");
    }

    private static IEnumerable<TestCaseData> GetNotRightTriangleSide()
    {
        yield return new TestCaseData(7, 8, 9);
        yield return new TestCaseData(4, 6, 7);
        yield return new TestCaseData(2, 3, 4);
    }

    [TestCaseSource(nameof(GetSidePerimeter))]
    public void CalculatePerimeterCorrectValue(int side1, int side2, int side3, double expected)
    {
        // Act
        var triangle = this.figureFactory.CreateTriangle(side1, side2, side3);
        var actual = triangle.CalculatePerimeter();

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    private static IEnumerable<TestCaseData> GetSidePerimeter()
    {
        yield return new TestCaseData(3, 12, 24, 19.5d);
        yield return new TestCaseData(1250, 6332, 7123, 7352.5d);
        yield return new TestCaseData(123, 453, 643, 609.5d);
    }
}