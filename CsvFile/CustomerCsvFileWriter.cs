namespace CsvFile;

public class CustomerCsvFileWriter
{
    private readonly IFileSystem _fileSystem;

    public CustomerCsvFileWriter(IFileSystem fileSystem)
    {
        _fileSystem = fileSystem;
    }

    public void Write(string fileName, IEnumerable<Customer> customers)
    {
        foreach (var customer in customers)
        {
            _fileSystem.WriteLine(fileName, customer.ToString());
        }
    }
}
