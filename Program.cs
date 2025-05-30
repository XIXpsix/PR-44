using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR_44
{
    class Program
    {
        static void Main(string[] args)
        {
            Point<int> P1 = new Point<int>(10, 20);
            P1.Print();
            Point<uint> P2 = new Point<uint>(110, 400);
            P2.Print();
            Point<double> P3 = new Point<double>(110, 400);
            P3.Print();
            Console.ReadKey();
        }
    }
}
