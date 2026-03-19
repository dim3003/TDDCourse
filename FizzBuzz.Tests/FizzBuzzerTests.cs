using NUnit.Framework;

namespace FizzBuzz.Tests;

[TestFixture]
public class FizzBuzzerTests
{
    [TestFixture]
    public class Go
    {
        [TestFixture]
        public class WhenNumberDivisibleBy3
        {
            [TestCase(3)]
            [TestCase(21)]
            [TestCase(99)]
            public void ShouldReturnFizz(int number)
            {
                // Arrange
                var sut = new FizzBuzzer();
                // Act
                var actual = sut.Go(number);
                // Assert
                Assert.That(actual, Is.EqualTo("Fizz"));
            }
        }

        [TestFixture]
        public class WhenNumberDivisibleBy5
        {
            [TestCase(5)]
            [TestCase(20)]
            [TestCase(100)]
            public void ShouldReturnBuzz(int number)
            {
                // Arrange
                var sut = CreateFizzBuzzer();
                // Act
                var actual = sut.Go(number);
                // Assert
                Assert.That(actual, Is.EqualTo("Buzz"));
            }
        }

        [TestFixture]
        public class WhenNumberDivisibleBy3And5
        {
            [TestCase(15)]
            [TestCase(30)]
            [TestCase(150)]
            public void ShouldReturnFizzBuzz(int number)
            {
                // Arrange
                FizzBuzzer sut = CreateFizzBuzzer();
                // Act
                var actual = sut.Go(number);
                // Assert
                Assert.That(actual, Is.EqualTo("FizzBuzz"));
            }

        }

        [TestFixture]
        public class WhenNumberNotDivisibleBy3Or5
        {
            [TestCase(1)]
            [TestCase(2)]
            [TestCase(4)]
            public void ShouldReturnNumberAsString(int number)
            {
                // Arrange
                var sut = CreateFizzBuzzer();
                // Act
                var actual = sut.Go(number);
                // Assert
                Assert.That(actual, Is.EqualTo(number.ToString()));
            }
        }

        private static FizzBuzzer CreateFizzBuzzer()
        {
            // Arrange
            return new FizzBuzzer();
        }
    }
}
