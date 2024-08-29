
using LinqJoinFirstPractice;

class Program
{
    static void Main(string[] args)
    {

        //Data Created by chatgpt

        List<Author> authors = new List<Author>
            {
                new Author { AuthorId = 1, Name = "George Orwell" },
                new Author { AuthorId = 2, Name = "J.K. Rowling" },
                new Author { AuthorId = 3, Name = "J.R.R. Tolkien" },
                new Author { AuthorId = 4, Name = "Agatha Christie" },
                new Author { AuthorId = 5, Name = "Ernest Hemingway" }
            };

        // Kitaplar Tablosu (Books)
        List<Book> books = new List<Book>
            {
                new Book { BookId = 1, Title = "1984", AuthorId = 1 },
                new Book { BookId = 2, Title = "Animal Farm", AuthorId = 1 },
                new Book { BookId = 3, Title = "Harry Potter and the Philosopher's Stone", AuthorId = 2 },
                new Book { BookId = 4, Title = "Harry Potter and the Chamber of Secrets", AuthorId = 2 },
                new Book { BookId = 5, Title = "The Hobbit", AuthorId = 3 },
                new Book { BookId = 6, Title = "The Lord of the Rings", AuthorId = 3 },
                new Book { BookId = 7, Title = "Murder on the Orient Express", AuthorId = 4 },
                new Book { BookId = 8, Title = "The Old Man and the Sea", AuthorId = 5 }
            };


        var bookTable = authors.Join(
            books,
            author=>author.AuthorId, //table key
            book=>book.AuthorId,    //table key
            (author, book) => new  //temporary created new table
            {
                BooksId=book.BookId,
                AuthorName=author.Name,
                BookTitle=book.Title,

            }
            );

        foreach(var item in bookTable)
        {
            Console.WriteLine($"Book:{item.BookTitle} Author:{item.AuthorName}");
        }

    }





}