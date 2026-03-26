using NSubstitute;
using NUnit.Framework;
using Bogus;

namespace CsvFile.Tests;

[TestFixture]
public class CsvFileWriterTests
{
    [Test]
    public void Write_GivenOneCustomer_ShouldWriteCustomerDataAsCsvLineToProvidedFile()
    {
        // Arrange
        var customers = CustomerFaker.Generate(1);
        var fileSystem = CreateMockFileSystem();
        var sut = CreateCustomerCsvFileWriter(fileSystem);
        // Act
        sut.Write("customers.csv", customers);
        // Assert
        AssertCustomerWasWrittenToFile(fileSystem, "customers.csv", customers.First());
    }

    [Test]
    public void Write_GivenTwoCustomers_ShouldWriteBothCustomersDataAsCsvLinesToProvidedFile()
    {
        // Arrange
        var customers = CustomerFaker.Generate(2);
        var fileSystem = CreateMockFileSystem();
        var sut = CreateCustomerCsvFileWriter(fileSystem);
        // Act
        sut.Write("cust.csv", customers);
        // Assert
        foreach(var customer in customers)
        {
            AssertCustomerWasWrittenToFile(fileSystem, "cust.csv", customer);
        }
    }

    [Test]
    public void Write_GivenThreeCustomers_ShouldWriteAllCustomersDataAsCsvLinesToProvidedFile()
    {
        // Arrange
        var customers = CustomerFaker.Generate(3);
        var fileSystem = CreateMockFileSystem();
        var sut = CreateCustomerCsvFileWriter(fileSystem);
        // Act
        sut.Write("cust1.csv", customers);
        // Assert
        foreach(var customer in customers)
        {
            AssertCustomerWasWrittenToFile(fileSystem, "cust1.csv", customer);
        }
    }

    private static void AssertCustomerWasWrittenToFile(IFileSystem fileSystem, string fileName, Customer customer)
    {
        fileSystem.Received(1).WriteLine(fileName, $"{customer.Name},{customer.ContactNumber}");
    }

    private static readonly Faker<Customer> CustomerFaker = new Faker<Customer>()
        .RuleFor(c => c.Name, f => f.Person.FullName)
        .RuleFor(c => c.ContactNumber, f => f.Phone.PhoneNumber("########"));

    private static IFileSystem CreateMockFileSystem()
    {
        return Substitute.For<IFileSystem>();
    }

    private static CustomerCsvFileWriter CreateCustomerCsvFileWriter(IFileSystem fileSystem)
    {
        return new CustomerCsvFileWriter(fileSystem);
    }
}
