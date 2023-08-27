using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class MathUtilityTests
{
  [TestMethod]
  public void TestSumPositiveNumbers()
  {
    // Arrange
    MathUtility mathUtility = new MathUtility();

    // Act
    int result = mathUtility.Sum(3, 5);

    // Assert
    Assert.AreEqual(8, result);
  }

  [TestMethod]
  public void TestSumNegativeNumbers()
  {
    // Arrange
    MathUtility mathUtility = new MathUtility();

    // Act
    int result = mathUtility.Sum(-3, -5);

    // Assert
    Assert.AreEqual(-8, result);
  }
}
