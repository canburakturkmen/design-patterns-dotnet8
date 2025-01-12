namespace TemplateMethod;

// Abstract Class: Template Method
public abstract class DataProcessor
{
    // Template Method
    public void ProcessData()
    {
        ReadData();
        ProcessDataContent();
        SaveResults();
    }

    // Step 1: Reading data (to be implemented by subclass)
    protected abstract void ReadData();

    // Step 2: Processing data (to be implemented by subclass)
    protected abstract void ProcessDataContent();

    // Step 3: Saving results (can be the same for all subclasses)
    protected void SaveResults()
    {
        Console.WriteLine("Results have been saved to the database.");
    }
}

// Concrete Class 1: Reading from a file and processing data
public class FileDataProcessor : DataProcessor
{
    protected override void ReadData()
    {
        Console.WriteLine("Reading data from a file...");
    }

    protected override void ProcessDataContent()
    {
        Console.WriteLine("Processing file data...");
    }
}

// Concrete Class 2: Reading from a database and processing data
public class DatabaseDataProcessor : DataProcessor
{
    protected override void ReadData()
    {
        Console.WriteLine("Fetching data from the database...");
    }

    protected override void ProcessDataContent()
    {
        Console.WriteLine("Processing database data...");
    }
}