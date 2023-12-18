using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Library_management
{
    public class Books
    {
        public string? Name { get; set; }
        public string? Code { get; set; }
        public string? Id { get; set; }
        public string? Picture { get; set; }
        public string? Author { get; set; }
        public string? Price { get; set; }
        public string? Publisher { get; set; }
        public string? Bookshelf { get; set; }
        public bool? Status { get; set; }
        public string? CreatedAt { get; set; }
        public string? UpdatedAt { get; set; }
    }

    public class FileWriterFromBooks
    {
        public void WriteBookInfoToFile(Books book, string path)
        {
            string json = JsonSerializer.Serialize(book);

            using (StreamWriter file = new StreamWriter(path, append: true))
            {
                file.WriteLine(json);
            }
        }

        public void WriteBooksInfoToFile(List<Books> books, string path)
        {
            using (StreamWriter file = new StreamWriter(path, append: false))
            {
                foreach (Books book in books)
                {
                    string json = JsonSerializer.Serialize(book);
                    file.WriteLine(json);
                }
            }
        }


        public List<Books> ReadBooksInfoFromFile(string path)
        {
            List<Books> books = new List<Books>();

            using (StreamReader file = new StreamReader(path))
            {
                string line;
                while ((line = file.ReadLine()) != null)
                {
                    Books book = JsonSerializer.Deserialize<Books>(line);
                    books.Add(book);
                }
            }

            return books;
        }

        public void DeleteBook(string bookId, string path)
        {
            string json = File.ReadAllText(path);
            List<Books> books = new List<Books>();

            foreach (string line in File.ReadLines(path))
            {
                Books book = JsonSerializer.Deserialize<Books>(line);
                books.Add(book);
            }


            books.RemoveAll(book => book.Id == bookId);


            using (StreamWriter file = new StreamWriter(path, append: false))
            {
                foreach (Books book in books)
                {
                    json = JsonSerializer.Serialize(book);
                    file.WriteLine(json);
                }
            }

        }
    }
}
