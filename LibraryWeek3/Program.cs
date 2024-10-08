namespace LibraryWeek3
{
    class Book
    {
        string Title;
        string Author;
        string ISBN;
        int NoOfPages;

        Book(string bookTitle, string bookAuthor, string bookISBN, int bookNoOfPages)
        {
            Title = bookTitle;
            Author = bookAuthor;
            ISBN = bookISBN;
            NoOfPages = bookNoOfPages;
        }

        void DisplayInfo()
        {
            Console.WriteLine("Book infromation");
            Console.WriteLine("________________");
            Console.WriteLine($"Book title: {Title}");
            Console.WriteLine($"Book Author: {Author}");
            Console.WriteLine($"Book ISBN: {ISBN}");
            Console.WriteLine($"Number of pages: {NoOfPages}");
            Console.WriteLine();
        }

        class Program
        {
            static void Main(string[] args)
            {
                // Create a new instance (object) of the Book class
                // Note how the object name differs from the class name
                Book book = new Book("C# for beginners", "Bill Gates", "1234567", 200);
                Book book2 = new Book("C# for intermediate", "Microsoft", "45364", 543);

                book.DisplayInfo();
                book2.DisplayInfo();
            }
        }
    }
}