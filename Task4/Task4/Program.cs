namespace Task4
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public bool Availability { get; set; } = true;

        public Book(string Title, string Author, string ISBN) 
        {
            this.Title = Title;
            this.Author = Author;
            this.ISBN = ISBN;
        }
    }

    public class Library
    {
        private List<Book> books = new List<Book>();

        public string AddBook(Book book)
        {
            books.Add(book);
            return "Added Successfully";
        }

        public List<Book> SearchForBook(string search)
        {
            List<Book> searchList = new List<Book>(); 
            for (int i = 0; i < books.Count; i++) 
            {
                if(books[i].Title.Contains(search) || books[i].Author.Contains(search))
                {
                    searchList.Add(books[i]);
                }
            }

            return searchList;
        }

        public string BorrowBook(string bookTitle)
        {
            int bookIndex = SearchByTitle(bookTitle);
            if (bookIndex >= 0)
            {
                books[bookIndex].Availability = false;
                return "Borrowed";
            }
            return "Not Found";

        }

        public string ReturnBook(string bookTitle)
        {
            int bookIndex = SearchByTitle(bookTitle);
            if (bookIndex >= 0)
            {
                if (!books[bookIndex].Availability)
                {
                    books[bookIndex].Availability = true;
                    return "Returned";
                }
                return "This book has not been borrowed.";
                
            }
            return "Not Found";

        }

        private int SearchByTitle(string search)
        {
            for (int i = 0; i < books.Count; i++)
            {
                if (books[i].Title.Contains(search) )
                {
                    return i;
                }
            }
            return -1;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();
            library.AddBook(new Book("The Great Gatsby", "F. Scott Fitzgerald", "9780743273565"));
            library.AddBook(new Book("To Kill a Mockingbird", "Harper Lee", "9780061120084"));
            library.AddBook(new Book("1984", "George Orwell", "9780451524935"));

            var searchBooks = library.SearchForBook("The Great Gatsby");
            if(searchBooks.Count > 0)
            {
                for (int i = 0; i < searchBooks.Count; i++)
                {
                    Console.WriteLine($"{i} - Title : {searchBooks[i].Title}, Author : {searchBooks[i].Author}, ISBN : {searchBooks[i].ISBN}\n");
                }
            }
            else
            {
                Console.WriteLine($"Not Found");
            }

            Console.WriteLine(library.BorrowBook("Gatsby"));

            Console.WriteLine(library.ReturnBook("Gatsby"));
        }
    }
}
