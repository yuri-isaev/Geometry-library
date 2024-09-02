namespace GeometryLibrary;

/**
 * Для добавления других фигур, просто нужно создать новые классы, реализующие интерфейс IFigure,
 * и добавить соответствующие методы для расчета площади.
 */
public class Square : IFigure
{
  public double Side { get; }

  public Square(double side)
  {
    Side = side;
  }

  public double CalculateArea()
  {
    return Side * Side;
  }
}

