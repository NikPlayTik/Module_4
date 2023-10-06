using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_4
{
    public interface IBook
    {
        string Available();
        void Extradition();
    }

    public class Book : IBook
    {
        private string title;
        private string author;
        private bool flagExtradition;

        public Book(string title, string author)
        {
            this.title = title;
            this.author = author;
            flagExtradition = false;
        }

        // добавление свойства
        public string Title
        {
            get 
            {
                return title; 
            }
        }

        // проверка доступности книги
        public string Available()
        {
            if (flagExtradition)
            {
                return "нет";
            }
            else
            {
                return "да";
            }
        }

        // выдача книг
        public void Extradition()
        {
            if (!flagExtradition)
            {
                flagExtradition = true;
                Console.WriteLine($"Книга \"{title}\" автора {author} выдана.");
            }
            else
            {
                Console.WriteLine($"Книга \"{title}\" автора {author} уже выдана.");
            }
        }
    }

    public class Library
    {
        public void LibraryBook()
        {
            Book book1 = new Book("Война и мир", "Лев Толстой");
            Book book2 = new Book("Мальчик-рыба", "Чахон Фетт");

            // проверка доступности и выдача книг
            Console.WriteLine($"Книга \"{book1.Title}\" доступна: {book1.Available()}");
            book1.Extradition();
            Console.WriteLine($"Книга \"{book1.Title}\" доступна: {book1.Available()}");

            Console.WriteLine($"Книга \"{book2.Title}\" доступна: {book2.Available()}");
            book2.Extradition();
            Console.WriteLine($"Книга \"{book2.Title}\" доступна: {book2.Available()}");
            Console.ReadLine();
        }
    }
}
