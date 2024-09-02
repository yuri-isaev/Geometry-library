namespace GeometryLibrary;

/**
 * Определим класс для вычисления площади фигуры без знания типа.
 */
public static class UnknownArea
{
  public static double CalculateArea(IFigure figure)
  {
    return figure.CalculateArea();
  }
}
