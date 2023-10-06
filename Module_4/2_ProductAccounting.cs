using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_4
{
    public interface IProduct
    {
        string GetName(); // получение имени товара
        double GetCost(); // стоимость товара
        int GetStock(); // остаток товара на складе
    }

    public class Product : IProduct
    {
        private string name;
        private double price;
        private int stock;

        public Product(string name, double price, int stock)
        {
            this.name = name;
            this.price = price;
            this.stock = stock;
        }

        public string GetName()
        {
            return name;
        }

        public double GetCost()
        {
            return price;
        }

        public int GetStock()
        {
            return stock;
        }
    }

    public class Electronics : IProduct
    {
        private string name;
        private double price;
        private int stock;

        public Electronics(string name, double price, int stock)
        {
            this.name = name;
            this.price = price;
            this.stock = stock;
        }

        public string GetName()
        {
            return name;
        }

        public double GetCost()
        {
            return price;
        }

        public int GetStock()
        {
            return stock;
        }
    }

    public class Products
    {
        public void ProductRealization()
        {
            // Создание массива (или списка) товаров
            Product[] products = new Product[]
            {
                new Product("Война и Мир", 8.99, 125),
                new Product("Преступление и наказание", 9.99, 49),
                new Product("Мальчик-рыба", 12.99, 6),
            };

            Electronics[] electronics = new Electronics[] 
            {
                new Electronics("Honor x9a", 899, 15),
                new Electronics("Lenovo IdeaPad 5", 2599, 23),
                new Electronics("Samsung Fridge XB", 1899, 10)
            };

            // вывод информации
            foreach (var enumerable in products)
            {
                Console.WriteLine($"Товар: {enumerable.GetName()}");
                Console.WriteLine($"Стоимость: {enumerable.GetCost()} BYN");
                Console.WriteLine($"Остаток на складе: {enumerable.GetStock()} шт.");
                Console.WriteLine();
            }

            foreach (var enumerable in electronics)
            {
                Console.WriteLine($"Товар: {enumerable.GetName()}");
                Console.WriteLine($"Стоимость: {enumerable.GetCost()} BYN");
                Console.WriteLine($"Остаток на складе: {enumerable.GetStock()} шт.");
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}   
