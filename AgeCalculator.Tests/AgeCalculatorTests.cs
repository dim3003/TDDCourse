using NUnit.Framework;

namespace AgeCalculator.Tests;

[TestFixture]
public class AgeCalculatorTests
{
    [TestCase("1984/06/27", "2002/11/01", 18)]
    [TestCase("1982/09/30", "2001/10/05", 19)]
    [TestCase("2000/01/01", "2010/01/02", 10)]
    [TestCase("1979/02/15", "2022/02/15", 43)]
    public void GivenOnOrAfterBirthDate_ShouldReturnDifferenceInYears(DateTime birthDate, DateTime currentDate, int expectedAge)
    {
        // Arrange
        var ageCalculator = new AgeCalculator();
        // Act
        var actualAge = ageCalculator.GetAge(birthDate, currentDate);
        // Assert
        Assert.That(actualAge, Is.EqualTo(expectedAge));
    }

    [TestCase("1984/06/27", "2002/04/01", 17)]
    [TestCase("1982/09/30", "2001/08/05", 18)]
    [TestCase("2000/01/02", "2010/01/01", 9)]
    public void GivenBeforeBirthDate_ShouldReturnDifferenceInYearsMinusOne(DateTime birthDate, DateTime currentDate, int expectedAge)
    {
        // Arrange
        var ageCalculator = new AgeCalculator();
        // Act
        var actualAge = ageCalculator.GetAge(birthDate, currentDate);
        // Assert
        Assert.That(actualAge, Is.EqualTo(expectedAge));
    }

}
