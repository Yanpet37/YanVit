namespace DZ5
{
    class Book
    {
        private string title;  
        private string author; 
        private int pages;


        public string Title
        {
            get { return title; }         
            set { title = value; }         
        }


        public string Author
        {
            get { return author; }         
            set { author = value; }        
        }


        public int Pages
        {
            get { return pages; }
            set { pages = value >= 0 ? value : 0; } //тернарный
        }

        public Book()
        {
            Title = "Unknown";   
            Author = "Unknown";  
            Pages = 0;           
        }

        public Book(string title, string author, int pages)
        {
            Title = title;   
            Author = author; 
            Pages = pages;   
        }

        public string GetDescription()
        {
            return $"Название: {Title}, Автор: {Author}, Страниц: {Pages}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Book standart = new Book();
            Console.WriteLine(standart.GetDescription()); 

            Book custom = new Book("Золушка", "Петровский Я.Ю.", 333);
            Console.WriteLine(custom.GetDescription()); 
        }
    }
}
