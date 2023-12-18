using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Library_management
{

    public class BookShelf
    {
        public string? Name { get; set; }
        public string? Order { get; set; }
        public string? Id { get; set; }
    }

    public class FileWriterFromBookShelf
    {
        public void WriteBookShelfInfoToFile(BookShelf bookshelf, string path)
        {
            string json = JsonSerializer.Serialize(bookshelf);

            using (StreamWriter file = new StreamWriter(path, append: true))
            {
                file.WriteLine(json);
            }
        }

        public void WriteBookShelfsInfoToFile(List<BookShelf> bookShelves, string path)
        {
            using (StreamWriter file = new StreamWriter(path, append: false))
            {
                foreach (BookShelf bookShel in bookShelves)
                {
                    string json = JsonSerializer.Serialize(bookShel);
                    file.WriteLine(json);
                }
            }
        }


        public List<BookShelf> ReadBookShelfInfoFromFile(string path)
        {
            List<BookShelf> bookShelves = new List<BookShelf>();

            using (StreamReader file = new StreamReader(path))
            {
                string line;
                while ((line = file.ReadLine()) != null)
                {
                    BookShelf bookshelf = JsonSerializer.Deserialize<BookShelf>(line);
                    bookShelves.Add(bookshelf);
                }
            }

            return bookShelves;
        }

        public void DeleteBookShelf(string bookshelfID, string path)
        {
            string json = File.ReadAllText(path);
            List<BookShelf> bookShelves = new List<BookShelf>();

            foreach (string line in File.ReadLines(path))
            {
                BookShelf bookshelf = JsonSerializer.Deserialize<BookShelf>(line);
                bookShelves.Add(bookshelf);
            }


            bookShelves.RemoveAll(bookshelf => bookshelf.Id == bookshelfID);


            using (StreamWriter file = new StreamWriter(path, append: false))
            {
                foreach (BookShelf bookShelf in bookShelves)
                {
                    json = JsonSerializer.Serialize(bookShelf);
                    file.WriteLine(json);
                }
            }

        }
    }
}
