using System;

namespace GeometryLibrary;

/**
 * Определим класс для круга.
 */
public class Circle : IFigure
{
  public double Radius { get; }

  public Circle(double radius)
  {
    Radius = radius;
  }

  public double CalculateArea()
  {
    return Math.PI * Math.Pow(Radius, 2);
  }
}
