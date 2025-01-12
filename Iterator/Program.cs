using Iterator;

var bookCollection = new BookCollection();

// Adding books to the collection
bookCollection.AddBook(new Book("The Catcher in the Rye", "J.D. Salinger"));
bookCollection.AddBook(new Book("To Kill a Mockingbird", "Harper Lee"));
bookCollection.AddBook(new Book("1984", "George Orwell"));

// Create an iterator for the book collection
var iterator = bookCollection.CreateIterator();

// Iterate through the books
while (iterator.HasNext())
{
    var book = iterator.Next();
    Console.WriteLine($"Title: {book.Title}, Author: {book.Author}");
}