using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR_44
{
    class Point<T>
    {
        private T x;
        private T y;

        public Point(T x, T y)
        {
            this.x = x;
            this.y = y;
        }
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
        public void Print()
        {
            Console.WriteLine($"Координаты x= {x};");
            Console.WriteLine($"Координаты y= {y};");
        }
    }
}
