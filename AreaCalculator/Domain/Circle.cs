namespace AreaCalculator.Domain;

public class Circle : IShape
{
    private readonly double _radius;

    public Circle(double radius)
    {
        if (radius <= 0)
        {
            throw new ArgumentException($"The radius must be greater than 0. " +
                                        $"Trying to create circle with radius = {radius}.");
        }

        _radius = radius;
    }

    public double CalculateArea()
    {
        return Math.PI * _radius * _radius;
    }
}