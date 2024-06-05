using System;

namespace lb_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("C# Programming");
            book.Author = new Author("John Doe");
            book.Content = new Content("This is a book about C# programming.");

            book.Show();
        }
    }
}