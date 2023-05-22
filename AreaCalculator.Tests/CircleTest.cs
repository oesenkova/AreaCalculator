using AreaCalculator.Domain;

namespace AreaCalculator.Tests;

public class CircleTest
{
    [Fact]
    public void Circle_WithNegativeValue_ThrowsArgumentException()
    {
        Assert.Throws<ArgumentException>(() => new Circle(-1));
    }
    
    [Fact]
    public void Circle_WithZero_ThrowsArgumentException()
    {
        Assert.Throws<ArgumentException>(() => new Circle(0));
    }

    [Fact]
    public void CalculateArea_WithIntrinsicValue_ReturnsResult()
    {
        var circle = new Circle(10);
        
        Assert.Equal(314.1592653589793, circle.CalculateArea());
    }
    
    [Fact]
    public void CalculateArea_WithFractionalValue_ReturnsResult()
    {
        var circle = new Circle(5.5);

        Assert.Equal(95.033177771091232, circle.CalculateArea());
    }
}