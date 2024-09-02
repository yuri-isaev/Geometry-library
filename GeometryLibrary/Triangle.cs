using System;

namespace GeometryLibrary;

/**
 * Определим класс для треугольника
 */
public class Triangle : IFigure
{
  public double SideA { get; }
  public double SideB { get; }
  public double SideC { get; }

  public Triangle(double sideA, double sideB, double sideC)
  {
    SideA = sideA;
    SideB = sideB;
    SideC = sideC;
  }

  public double CalculateArea()
  {
    double s = (SideA + SideB + SideC) / 2;
    return Math.Sqrt(s * (s - SideA) * (s - SideB) * (s - SideC));
  }

  public bool IsRightAngled()
  {
    var sides = new[] {SideA, SideB, SideC};
    Array.Sort(sides);
    return Math.Abs(sides[0] * sides[0] + sides[1] * sides[1] - sides[2] * sides[2]) < 1e-10;
  }
}
