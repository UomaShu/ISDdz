using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {           
            Content content = new Content();
            content.content = "About elphs";

            Title title = new Title();
            title.title = "This is title";

            Author author = new Author();
            author.author = "Kafka";

            Book book = new Book();
            book._author = author;
            book._content = content;
            book._title = title;
            book.Show();
        }
    }
    public class Title
    {
        private String name;
        public String title
        {
            set => name = value;
            get => name;

        }
        public void show()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Your title {0}", name);
        }
    }

    public class Author
    {
        private String name;
        public String author
        {
            set => name = value;
            get => name;

        }
        public void show()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Your author {0}", name);
        }
    }

    public class Content
    {
        private String name;
        public String content
        {
            set => name = value;
            get => name;
        }
        public void show()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Your title {0}", name);
        }
    }

    public class Book
    {
        Content content = new Content();
        Author author = new Author();
        Title title = new Title();

        public Title _title
        {
            get => title;
            set => title = value;
        }
        public Author _author
        {
            get => author;
            set => author = value;
        }
        public Content _content
        {
            get => content;
            set => content = value;
        }
        public void Show()
        {
            title.show();
            author.show();
            content.show();
        }
    }
}
