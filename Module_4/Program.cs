using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // обьекты класса
            Figure figure = new Figure();
            Products products = new Products();
            StudentAccouting studentAccouting = new StudentAccouting();
            Library library = new Library();
            DrawCanvas draw_canvas = new DrawCanvas();
            while (true)
            {
                // меню выбора
                Console.WriteLine("\t---Меню---" +
                    "\n1. Создание интерфейса «Фигура» с методами для вычисления площади и периметра" +
                    "\n2. Приложение для учета продуктов в магазине с использованием интерфейсов" +
                    "\n3. Система учета студентов в университете с помощью интерфейсов" +
                    "\n4. Приложение для работы с библиотекой книг с использованием интерфейсов" +
                    "\n5. Приложение для рисования на холсте с использованием интерфейсов");

                string choiceNumber = Console.ReadLine();

                switch (choiceNumber)
                {
                    case "1":
                        Console.Clear();
                        figure.FigureRealization();
                        Console.Clear();
                        break;
                    case "2":
                        Console.Clear();
                        products.ProductRealization(); 
                        Console.Clear();
                        break;
                    case "3":
                        Console.Clear();
                        studentAccouting.Student();
                        Console.Clear();
                        break;
                    case "4":
                        Console.Clear();
                        library.LibraryBook();
                        Console.Clear();
                        break;
                    case "5":
                        Console.Clear();
                        draw_canvas.Draw();
                        Console.Clear();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Некорректный выбор. Попробуйте еще раз.");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                }
            }
        }
    }
}
