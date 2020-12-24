using System;
using System.Collections.Generic;
using System.Text;
namespace Arthmetic
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape.AreaOfCircle(3.14);
            int x = 6;
            int y = 5;
            int z = (x - y);
            Console.WriteLine("value of z is:" + z);
            Console.WriteLine("multifications of x*y:" + (x * y));
        }
    }
    //  static void AreaOfCircle(double radius)
    //{
    //    double pi = 3.14;
    //    Console.WriteLine("area of circle is:" + (pi * radius * radius));
       


    //}
}
