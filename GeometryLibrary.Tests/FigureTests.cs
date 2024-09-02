using System;

namespace GeometryLibrary.Tests;

[TestFixture]
public class FigureTests
{
  [Test]
  public void Circle_CalculateArea_ReturnsCorrectArea()
  {
    // Arrange
    var circle = new Circle(5);
    double expectedArea = Math.PI * 25;

    // Act
    double actualArea = circle.CalculateArea();

    // Assert
    Assert.AreEqual(expectedArea, actualArea, 1e-10);
  }

  [Test]
  public void CalculateArea_ReturnsCorrectArea_ForRightAngledTriangle()
  {
    // Arrange
    var triangle = new Triangle(3, 4, 5);

    // Act
    double actualArea = triangle.CalculateArea();

    // Assert
    Assert.AreEqual(6, actualArea, 1e-10);
  }

  [Test]
  public void IsRightAngled_ReturnsTrue_ForRightAngledTriangle()
  {
    var triangle = new Triangle(3, 4, 5);
    Assert.IsTrue(triangle.IsRightAngled());
  }

  [Test]
  public void IsRightAngled_ReturnsFalse_ForEquilateralTriangle()
  {
    var triangle = new Triangle(5, 5, 5);
    Assert.IsFalse(triangle.IsRightAngled());
  }

  [Test]
  public void IsRightAngled_ReturnsFalse_ForScaleneNonRightAngledTriangle()
  {
    var triangle = new Triangle(5, 5, 8);
    Assert.IsFalse(triangle.IsRightAngled());
  }


  [Test]
  public void IsRightAngled_ReturnsFalse_ForObtuseTriangle()
  {
    var triangle = new Triangle(5, 6, 10);
    Assert.IsFalse(triangle.IsRightAngled());
  }

  [Test]
  public void CalculateArea_ShouldReturn_CorrectValue()
  {
    // Arrange
    double side = 4;
    var square = new Square(side);
    double expectedArea = side * side;

    // Act
    double actualArea = square.CalculateArea();

    // Assert
    Assert.AreEqual(expectedArea, actualArea);
  }
}
