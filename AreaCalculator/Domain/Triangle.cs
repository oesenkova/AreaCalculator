namespace AreaCalculator.Domain;

public class Triangle : IShape
{
    private readonly double _firstSide;
    private readonly double _secondSide;
    private readonly double _thirdSide;
    
    public Triangle(double firstSide, double secondSide, double thirdSide)
    {
        if (firstSide <= 0 || secondSide <= 0 || thirdSide <= 0)
        {
            throw new ArgumentException($"The side of triangle can't be less than 0. " +
                                        $"Trying to create triangle with sides {firstSide}, {secondSide}, {thirdSide}.");
        }
        
        _firstSide = firstSide;
        _secondSide = secondSide;
        _thirdSide = thirdSide;
    }
    
    
    public bool IsRightTriangle()
    {
        var firstSideSquare = _firstSide * _firstSide;
        var secondSideSquare = _secondSide * _secondSide;
        var thirdSideSquare = _thirdSide * _thirdSide;
        
        return (firstSideSquare + secondSideSquare) - thirdSideSquare == 0 || 
               firstSideSquare + thirdSideSquare - secondSideSquare == 0 ||
               secondSideSquare + thirdSideSquare - firstSideSquare == 0;
    }
    
    public double CalculateArea()
    {
        var halfPerimeter = (_firstSide + _secondSide + _thirdSide) / 2;
        
        var area = Math.Sqrt(halfPerimeter * (halfPerimeter - _firstSide) * (halfPerimeter - _secondSide) *
                             (halfPerimeter - _thirdSide));

        return area;
    }
}