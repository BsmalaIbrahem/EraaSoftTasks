using System.Text;

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
            return Search(search);
        }

        public string BorrowBook(string bookTitle)
        {
            List<Book> books = Search(bookTitle);
            if (books.Count > 0)
            {
                for (int i = 0; i < books.Count; i++) 
                {
                    if (books[i].Availability)
                    {
                        books[i].Availability = false;
                        return "Borrowed";

                    }
                }
                return "Sorry, All Books are Borrowed";
            }
            return "Not Found";

        }

        public string ReturnBook(string bookTitle)
        {
            List<Book> books = Search(bookTitle);
            if (books.Count > 0)
            {
                for (int i = 0; i < books.Count; i++)
                {
                    if (!books[i].Availability)
                    {
                        books[i].Availability = true;
                        return "Returned";

                    }
                }
                return "Sorry, All Books are Returned";
            }
            return "Not Found";

        }

        private List<Book> Search(string search)
        {
            int seachLen = search.Length;
            List<Book> searchedbooks = new List<Book>();
            for (int i = 0; i < books.Count; i++)
            {
                bool flag = false;

                if (books[i].Title.Length == seachLen)
                {
                    if (books[i].Title == search)
                    {
                        searchedbooks.Add(books[i]);
                        flag = true;
                    }
                }
                else if (books[i].Title.Length < seachLen)
                {
                    break;
                }
                else
                {
                    StringBuilder title = new StringBuilder(books[i].Title);

                    for (int j = 0; j < books[i].Title.Length; j++)
                    {
                        string s = "";
                        if (title.Length >= seachLen)
                        {
                            for (int k = 0; k < seachLen; k++)
                            {
                                s += title[k];
                            }

                            if (s == search)
                            {
                                searchedbooks.Add(books[i]);
                                flag = true;
                                break;
                            }
                            else
                            {

                                title.Remove(0, 1);
                            }

                        }
                        else
                        {
                            break;
                        }
                    }
                }

                if(!flag)
                {
                    SearchByAuthor(search, searchedbooks, i);
                }

            }

            return searchedbooks;
        }

        private List<Book> SearchByAuthor(string search, List<Book>  searchedbooks, int i)
        {
            int seachLen = search.Length;
           



            if (books[i].Author.Length == seachLen)
            {
                if (books[i].Author == search)
                    searchedbooks.Add(books[i]);
            }
            else if (books[i].Author.Length < seachLen)
            {
                return [];
            }
            else
            {
                StringBuilder author = new StringBuilder(books[i].Author);

                for (int j = 0; j < books[i].Author.Length; j++)
                {
                    string s = "";
                    if (author.Length >= seachLen)
                    {
                        for (int k = 0; k < seachLen; k++)
                        {
                            s += author[k];
                        }

                        if (s == search)
                        {
                            searchedbooks.Add(books[i]);
                            break;
                        }
                        else
                        {

                            author.Remove(0, 1);
                        }

                    }
                    else
                    {
                        break;
                    }
                }
            }

            

            return searchedbooks;
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

            var searchBooks = library.SearchForBook("G");
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
            Console.WriteLine(library.BorrowBook("Gatsby"));

            Console.WriteLine(library.ReturnBook("Gatsby"));
            Console.WriteLine(library.ReturnBook("nfkhb"));
        }
    }
}
