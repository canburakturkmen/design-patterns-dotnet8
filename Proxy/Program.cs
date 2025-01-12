using Proxy;

IDataAccess dataAccess = new DataAccessProxy();

// First access - hits the database
Console.WriteLine(dataAccess.GetData(1));
Console.WriteLine();

// Second access - uses cache
Console.WriteLine(dataAccess.GetData(1));
Console.WriteLine();

// Another access - hits the database
Console.WriteLine(dataAccess.GetData(2));