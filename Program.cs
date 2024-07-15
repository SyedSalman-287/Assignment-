using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Book book1 = new Book("Dear World", "Salman", "B001");
        book1.DisplayInfo(); // calling display_info()

        Person user1 = new Person("Kiyani", 23, "L2354");

        Librarian librarian = new Librarian("John Doe", 30, "12345", "L123");

        Library library = new Library("City Library", "L001", librarian);
        library.AddBook(book1);

        library.ViewBooks();
    }
}

class Book
{
    public string Title;
    public string Author;
    public string BookID;

    public Book(string title, string author, string bookID)
    {
        Title = title;
        Author = author;
        BookID = bookID;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Book Title: {Title}, Author: {Author}, Book ID: {BookID}");
    }
}

class Person
{
    public string Name;
    public int Age;
    public string PersonID;

    public Person(string name, int age, string personID)
    {
        Name = name;
        Age = age;
        PersonID = personID;
    }
}

class Librarian : Person
{
    public string EmployeeID;

    public Librarian(string name, int age, string personID, string employeeID)
        : base(name, age, personID)
    {
        EmployeeID = employeeID;
    }

    public void IssueBook(Book book, Person user, List<Book> issuedBooks)
    {
        issuedBooks.Add(book);
        Console.WriteLine($"The book '{book.Title}' is issued to {user.Name}");
    }

    public void ReturnBook(Book book, Person user, List<Book> issuedBooks)
    {
        issuedBooks.Remove(book);
        Console.WriteLine($"The book '{book.Title}' is returned by {user.Name}");
    }
}

class Library
{
    public string LibraryName;
    public string LibraryID;
    public List<Book> Books;
    public Librarian Librarian;
    public List<Book> IssuedBooks;

    public Library(string libraryName, string libraryID, Librarian librarian)
    {
        LibraryName = libraryName;
        LibraryID = libraryID;
        Books = new List<Book>();
        IssuedBooks = new List<Book>();
        Librarian = librarian;
    }

    public void AddBook(Book book)
    {
        Books.Add(book);
        Console.WriteLine($"Book '{book.Title}' added to the library.");
    }

    public void RemoveBook(string bookID)
    {
        Book bookToRemove = Books.Find(book => book.BookID == bookID);
        if (bookToRemove != null)
        {
            Books.Remove(bookToRemove);
            Console.WriteLine($"Book with ID '{bookID}' removed from the library.");
        }
        else
        {
            Console.WriteLine($"Book with ID '{bookID}' not found in the library.");
        }
    }

    public void ViewBooks()
    {
        Console.WriteLine($"Books in Library '{LibraryName}':");
        foreach (Book book in Books)
        {
            Console.WriteLine($"- {book.Title} by {book.Author} (ID: {book.BookID})");
        }
    }

    public void SearchBook(string title)
    {
        Book foundBook = Books.Find(book => book.Title == title);
        if (foundBook != null)
        {
            Console.WriteLine($"Book '{title}' found in the library.");
        }
        else
        {
            Console.WriteLine($"Book '{title}' not found in the library.");
        }
    }

    public void ListIssuedBooks()
    {
        Console.WriteLine("Issued Books:");
        foreach (Book book in IssuedBooks)
        {
            Console.WriteLine($" {book.Title} by {book.Author} (ID: {book.BookID})");
        }
    }
}
