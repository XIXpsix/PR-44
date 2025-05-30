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
            //Person <int> tom = new Person <int>(546, "Tom");
            //Person <string> bob = new Person <string>("a1", "Bob");
            //int TomId = (int)tom.Id;
            //string BobId = (string)bob.Id;
            //Console.WriteLine(TomId);
            //Console.WriteLine(BobId);

            Person<int> tom = new Person<int>(546, "Tom");
            Company<Person<int>> microsoft = new Company<Person<int>>(tom);
            Console.WriteLine(microsoft.CEO.Id);
            Console.WriteLine(microsoft.CEO.Name);
        }
    }
}
