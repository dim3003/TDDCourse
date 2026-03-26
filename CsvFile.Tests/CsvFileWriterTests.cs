using NSubstitute;
using NUnit.Framework;

namespace CsvFile.Tests;

[TestFixture]
public class CsvFileWriterTests
{
    [Test]
    public void Write_GivenOneCustomer_ShouldWriteCustomerDataAsCsvLineToProvidedFile()
    {
        // Arrange
        var customer = CreateCustomer("Brandon Page", "12345678");
        var fileSystem = CreateMockFileSystem();
        var sut = CreateCustomerCsvFileWriter(fileSystem);
        // Act
        sut.Write("customers.csv", new List<Customer> { customer });
        // Assert
        AssertCustomerWasWrittenToFile(fileSystem, "customers.csv", customer);
    }

    [Test]
    public void Write_GivenTwoCustomers_ShouldWriteBothCustomersDataAsCsvLinesToProvidedFile()
    {
        // Arrange
        var customer1 = CreateCustomer("Brandon Page", "12345678");
        var customer2 = CreateCustomer("John Doe", "87654321");
        var fileSystem = CreateMockFileSystem();
        var sut = CreateCustomerCsvFileWriter(fileSystem);
        // Act
        sut.Write("cust.csv", new List<Customer> { customer1, customer2 });
        // Assert
        AssertCustomerWasWrittenToFile(fileSystem, "cust.csv", customer1);
        AssertCustomerWasWrittenToFile(fileSystem, "cust.csv", customer2);
    }

    [Test]
    public void Write_GivenThreeCustomers_ShouldWriteAllCustomersDataAsCsvLinesToProvidedFile()
    {
        // Arrange
        var customer1 = CreateCustomer("Brandon Page", "12345678");
        var customer2 = CreateCustomer("John Doe", "87654321");
        var customer3 = CreateCustomer("Jane Smith", "11223344");
        var fileSystem = CreateMockFileSystem();
        var sut = CreateCustomerCsvFileWriter(fileSystem);
        // Act
        sut.Write("cust1.csv", new List<Customer> { customer1, customer2, customer3 });
        // Assert
        AssertCustomerWasWrittenToFile(fileSystem, "cust1.csv", customer1);
        AssertCustomerWasWrittenToFile(fileSystem, "cust1.csv", customer2);
        AssertCustomerWasWrittenToFile(fileSystem, "cust1.csv", customer3);
    }

    private static void AssertCustomerWasWrittenToFile(IFileSystem fileSystem, string fileName, Customer customer)
    {
        fileSystem.Received(1).WriteLine(fileName, $"{customer.Name},{customer.ContactNumber}");
    }

    private static Customer CreateCustomer(string name, string contactNumber)
    {
        return new Customer 
        { 
            Name = name,
            ContactNumber = contactNumber 
        };
    }

    private static IFileSystem CreateMockFileSystem()
    {
        return Substitute.For<IFileSystem>();
    }

    private static CustomerCsvFileWriter CreateCustomerCsvFileWriter(IFileSystem fileSystem)
    {
        return new CustomerCsvFileWriter(fileSystem);
    }
}
