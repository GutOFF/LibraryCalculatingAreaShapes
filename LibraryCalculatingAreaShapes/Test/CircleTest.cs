using LibraryCalculatingAreaShapes.Factory;

namespace Test;

[Parallelizable]
public class CircleTest
{
    private readonly IFigureFactory figureFactory;

    public CircleTest()
    {
        this.figureFactory = new FigureFactory();
    }

    [TestCaseSource(nameof(GetRadiusArea))]
    public void CalculateAreaCorrectValue(int radius, double expectedArea)
    {
        // Act
        var circle = this.figureFactory.CreateCircle(radius);
        var actual = circle.CalculateArea();

        // Assert
        Assert.That(actual, Is.EqualTo(expectedArea));
    }

    private static IEnumerable<TestCaseData> GetRadiusArea()
    {
        yield return new TestCaseData(3, 28.274333882308138d);
        yield return new TestCaseData(256, 205887.41614566068d);
        yield return new TestCaseData(10045, 316993060.47233367d);
    }

    [Test]
    public void CalculateAreaZeroRadius()
    {
        // Arrange
        const int radius = 0;

        // Act
        // Assert
        Assert.Throws<ArgumentException>(() => this.figureFactory.CreateCircle(radius));
    }

    [Test]
    public void CalculateAreaNegativeRadius()
    {
        // Arrange
        const int radius = -10;

        // Act
        // Assert
        Assert.Throws<ArgumentException>(() => this.figureFactory.CreateCircle(radius));
    }

    [TestCaseSource(nameof(GetRadiusPerimeter))]
    public void CalculatePerimeterCorrectValue(int radius, double expected)
    {
        // Act
        var circle = this.figureFactory.CreateCircle(radius);
        var actual = circle.CalculatePerimeter();

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    private static IEnumerable<TestCaseData> GetRadiusPerimeter()
    {
        yield return new TestCaseData(40, 251.32741228718345d);
        yield return new TestCaseData(5556, 34909.377566689778d);
        yield return new TestCaseData(95321, 598919.50666566531d);
    }
}