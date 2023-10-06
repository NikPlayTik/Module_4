using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_4
{
    public interface IDrawing
    {
        void DrawLine(int x1, int y1, int x2, int y2);
        void DrawCircle(int x, int y, int radius);
        void DrawRectangle(int x, int y, int width, int height);
    }

    public class Canvas : IDrawing
    {
        public void DrawLine(int x1, int y1, int x2, int y2)
        {
            Console.WriteLine($"Рисуем линию от ({x1}, {y1}) до ({x2}, {y2})");
        }

        public void DrawCircle(int x, int y, int radius)
        {
            Console.WriteLine($"Рисуем круг с центром в точке ({x}, {y}) и радиусом {radius}");
        }

        public void DrawRectangle(int x, int y, int width, int height)
        {
            Console.WriteLine($"Рисуем прямоугольник с верхним левым углом в точке ({x}, {y}), шириной {width} и высотой {height}");
        }
    }

    class DrawCanvas
    {
        public void Draw()
        {
            // Создание объекта холста
            Canvas canvas = new Canvas();

            // рисование на холсте
            canvas.DrawLine(0, 0, 100, 100);
            canvas.DrawCircle(50, 50, 30);
            canvas.DrawRectangle(10, 10, 80, 60);
        }
    }
}
