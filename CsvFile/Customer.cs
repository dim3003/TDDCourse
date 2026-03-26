namespace CsvFile;

public class Customer
{
    public required string Name { get; set; }
    public required string ContactNumber { get; set; }

    public override string ToString()
    {
        return string.Join(",",Name,ContactNumber);
    }

}
