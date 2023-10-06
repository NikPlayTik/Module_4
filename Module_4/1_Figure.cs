using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Module_4
{
    interface IFigure
    {
        double CalculateArea();
        double CalculatePerimetr();
    }

    public class Rectangle : IFigure
    {
        private double length;
        private double width;

        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }

        public double CalculateArea()
        {
            return width * length;
        }
        public double CalculatePerimetr() 
        {
            return 2 * (width + length);
        }
    }

    public class Circle : IFigure
    {
        public double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public double CalculateArea()
        {
            return Math.PI * radius * radius;
        }

        public double CalculatePerimetr()
        {
            return 2 * Math.PI * radius;
        }
    }

    public class Triangle : IFigure
    {
        private double side_1;
        private double side_2;
        private double side_3;

        public Triangle(double side1, double side2, double side3)
        {
            this.side_1 = side1;
            this.side_2 = side2;
            this.side_3 = side3;
        }

        public double CalculateArea()
        {
            // формула Герона для вычисление площади
            double s = (side_1 + side_2 + side_3) / 2;
            return Math.Sqrt(s * (s - side_1) * (s - side_2) * (s - side_3));
        }

        public double CalculatePerimetr()
        {
            return side_1 + side_2 + side_3;
        }
    }

    public class Figure
    {
        private double radiusC;
        private double lengthR;
        private double widthR;
        private double side_1T;
        private double side_2T;
        private double side_3T;
        bool flagCalculations = true;

        public void FigureRealization()
        {
            while (flagCalculations)
            {
                Console.WriteLine("Выберите фигуру: ");
                Console.WriteLine("1. Круг");
                Console.WriteLine("2. Прямоугольник");
                Console.WriteLine("3. Треугольник");
                Console.WriteLine("4. Выйти");

                string numberChoice = Console.ReadLine();

                switch (numberChoice)
                {
                    case "1":                        
                        Console.Write("Введите радиус круга: ");
                        if (double.TryParse(Console.ReadLine(), out radiusC))
                        {
                            Circle circle = new Circle(radiusC);
                            if (radiusC > 0)
                            {
                                Console.WriteLine($"Площадь круга: {circle.CalculateArea():F2}");
                                Console.WriteLine($"Периметр круга: {circle.CalculatePerimetr():F2}");
                            }
                            else
                            {
                                Console.WriteLine("Радиус не может быть отрицателен");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Некорректный ввод");
                        }
                        
                        break;

                    case "2":
                        Console.Write("Введите длину прямоугольника: ");
                        if (double.TryParse(Console.ReadLine(), out lengthR))
                        {
                            Console.Write("Введите ширину прямоугольника: ");
                            if (double.TryParse(Console.ReadLine(), out widthR))
                            {
                                Rectangle rectangle = new Rectangle(lengthR, widthR);
                                if (lengthR > 0 && widthR > 0)
                                {
                                    Console.WriteLine($"Площадь прямоугольника: {rectangle.CalculateArea():F2}");
                                    Console.WriteLine($"Периметр прямоугольника: {rectangle.CalculatePerimetr():F2}");
                                }
                                else
                                {
                                    Console.WriteLine("Радиус не может быть отрицателен");
                                }
                            }
                            
                        }
                        else
                        {
                            Console.WriteLine("Некорректный ввод");
                        }
                        break;

                    case "3":
                        Console.Write("Введите длину первой стороны треугольника: ");
                        if (double.TryParse(Console.ReadLine(), out side_1T))
                        {
                            Console.Write("Введите длину второй стороны треугольника: ");
                            if (double.TryParse(Console.ReadLine(), out side_2T))
                            {
                                Console.Write("Введите длину третьей стороны треугольника: ");
                                if (double.TryParse(Console.ReadLine(), out side_3T))
                                {
                                    Triangle triangle = new Triangle(side_1T, side_2T, side_3T);
                                    if (side_1T > 0 && side_2T > 0 && side_3T > 0)
                                    {
                                        Console.WriteLine($"Площадь треугольника: {triangle.CalculateArea():F2}");
                                        Console.WriteLine($"Периметр треугольника: {triangle.CalculatePerimetr():F2}");
                                    }
                                }
                            }
                        }
                        break;

                    case "4":
                        flagCalculations = false;
                        break;

                    default:
                        Console.WriteLine("Неверный выбор.");
                        break;
                }
            }
            flagCalculations = true;
        }
    }
}
