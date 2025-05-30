using System;
using System.Collections.Generic;
using System.Linq;
using System;

namespace GenericPointApp
{
    // Обобщённый класс Point
    public class Point<T>
    {
        // Внутренние поля
        private T x;
        private T y;

        // Конструктор с двумя параметрами
        public Point(T x, T y)
        {
            this.x = x;
            this.y = y;
        }

        // Свойства доступа к внутренним полям
        public T X
        {
            get { return x; }
            set { x = value; }
        }

        public T Y
        {
            get { return y; }
            set { y = value; }
        }

        // Метод вывода значений полей
        public void Print()
        {
            Console.WriteLine($"Point coordinates: X = {x}, Y = {y}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Точка с int
            Point<int> intPoint = new Point<int>(10, 20);
            intPoint.Print();

            // Точка с uint
            Point<uint> uintPoint = new Point<uint>(15, 25);
            uintPoint.Print();

            // Точка с double
            Point<double> doublePoint = new Point<double>(12.5, 30.7);
            doublePoint.Print();

            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}
