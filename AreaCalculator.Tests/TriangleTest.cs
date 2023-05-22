using AreaCalculator.Domain;

namespace AreaCalculator.Tests;

public class TriangleTest
{
    [Theory]
    [InlineData(-1, 3, 10)]
    [InlineData(1, -3, 10)]
    [InlineData(1, 3, -10)]
    [InlineData(-1, -3, -10)]
    [InlineData(0, 3, 10)]
    [InlineData(1, 0, 10)]
    [InlineData(1, 3, 0)]
    [InlineData(0, 0, 0)]
    public void Triangle_WithNegativeFirstValue_ThrowsArgumentException(double firstSide, double secondSide,
        double thirdSide)
    {
        Assert.Throws<ArgumentException>(() => new Triangle(firstSide, secondSide, thirdSide));
    }

    [Fact]
    public void CalculateArea_WithIntrinsicValues_ReturnsResult()
    {
        var triangle = new Triangle(3, 3, 5);

        Assert.Equal(4.14578098794425, triangle.CalculateArea());
    }

    [Fact]
    public void CalculateArea_WithFractionalValues_ReturnsResult()
    {
        var triangle = new Triangle(3.1, 3.2, 5.5);

        Assert.Equal(4.2239318176315326, triangle.CalculateArea());
    }

    [Fact]
    public void IsRightTriangle_ReturnsTrue()
    {
        var triangle = new Triangle(21, 28, 35);

        Assert.True(triangle.IsRightTriangle());
    }

    [Fact]
    public void IsRightTriangle_ReturnsFalse()
    {
        var triangle = new Triangle(3.1, 3.2, 5.5);

        Assert.False(triangle.IsRightTriangle());
    }
}