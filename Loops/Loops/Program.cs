namespace Loops
{
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }

        public Book(string title, string author, int year)
        {
            Title = title;
            Author = author;
            Year = year;
        }

        public string GetInfo()
        {
            return $"Название: {Title}, Автор: {Author}, Год: {Year}";
        }            
    }
}

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("1984", "George Orwell", 1949);
            Console.WriteLine(book.GetInfo());
        }
    }
}
