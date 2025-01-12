namespace Proxy;

// Subject Interface
public interface IDataAccess
{
    string GetData(int id);
}

// Real Subject: Expensive Database Access
public class DatabaseAccess : IDataAccess
{
    public string GetData(int id)
    {
        Console.WriteLine($"Fetching data for ID: {id} from the database...");
        // Simulate a database fetch
        return $"Data for ID: {id}";
    }
}

// Proxy: Caching Layer
public class DataAccessProxy : IDataAccess
{
    private readonly DatabaseAccess _databaseAccess = new();
    private readonly Dictionary<int, string> _cache = new();

    public string GetData(int id)
    {
        if (_cache.ContainsKey(id))
        {
            Console.WriteLine($"Returning cached data for ID: {id}");
            return _cache[id];
        }

        Console.WriteLine($"No cache for ID: {id}. Accessing database...");
        var data = _databaseAccess.GetData(id);
        _cache[id] = data;
        return data;
    }
}
