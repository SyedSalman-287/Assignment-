using System;
using System.Reflection;
using System.Collections.Generic; 

namespace Project;
class Project
{
     public static void Main(String[] args)
    {
        Book book1 = new Book("hello", "salman", "sal 12");
        book1.display_info();   // calling display_info()
    }
}

class Book
{
    public string Title ="";
   public string Author="";
   public string Book_ID = "";
    public Book(string title, string author, string book_ID)  // Constructor
    {
        Title = title;
        Author = author;
        Book_ID = book_ID;
    }
    public void display_info()
    {
        Console.WriteLine("The information of Book " +"\n"+ Title  );
    }
}
class Person
{
   public string Name;
    public int Age;
    public string Person_ID;
    public Person(string name, int age, string person_ID)  // Constructor
    {
        Name = name;
        Age = age;
        Person_ID = person_ID;
    }
}
class Library
{
    public string Library_Name;
    public string Library_ID;
    public List<string> Books_Information = new List<string>(); // List of books 
    public Library(string library_Name, string library_ID)  // Constructor
    {
        Library_Name = library_Name;
        Library_ID = library_ID;
    }
    public string add_book(string name)
    {
        Books_Information.Add(name);
        Console.WriteLine($"Book '{name}' added to the library.");
        return "";
    }
    public string remove_book(string name)
    {
        Console.WriteLine(Books_Information.Remove(Book_ID));
        return "";
    }
    public void View_Books()
    {
        Console.WriteLine("Books in the library:");
        foreach (string book in Books_Information)
        {
            Console.WriteLine (book);
        }
    }
}