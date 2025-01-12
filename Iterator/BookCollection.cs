namespace Iterator;

// Iterator Interface
public interface IIterator<T>
{
    bool HasNext();
    T Next();
}

// Aggregate Interface
public interface IBookCollection
{
    IIterator<Book> CreateIterator();
}

// Concrete Book Class
public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }

    public Book(string title, string author)
    {
        Title = title;
        Author = author;
    }
}

// Concrete Iterator: Iterating through the list of books
public class BookIterator : IIterator<Book>
{
    private readonly List<Book> _books;
    private int _currentIndex = 0;

    public BookIterator(List<Book> books)
    {
        _books = books;
    }

    public bool HasNext()
    {
        return _currentIndex < _books.Count;
    }

    public Book Next()
    {
        if (HasNext())
        {
            return _books[_currentIndex++];
        }
        throw new InvalidOperationException("No more elements.");
    }
}

// Concrete Aggregate: Book Collection
public class BookCollection : IBookCollection
{
    private readonly List<Book> _books = new();

    public void AddBook(Book book)
    {
        _books.Add(book);
    }

    public IIterator<Book> CreateIterator()
    {
        return new BookIterator(_books);
    }
}