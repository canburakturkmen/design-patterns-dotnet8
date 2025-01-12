using TemplateMethod;

// Client chooses which processing workflow to use

Console.WriteLine("Processing File Data:");
DataProcessor fileProcessor = new FileDataProcessor();
fileProcessor.ProcessData();

Console.WriteLine();

Console.WriteLine("Processing Database Data:");
DataProcessor dbProcessor = new DatabaseDataProcessor();
dbProcessor.ProcessData();