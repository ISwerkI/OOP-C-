using OOP.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point A = new Point(2, 3);
            /*A.SetX(10);
            A.SetY(10);
            Console.WriteLine($"X = {A.GetX()}, Y = {A.GetY()}");*/
            A.Print();
            Point B = new Point(7, 8);
            Console.WriteLine(A.Distance(B));

        }
    }
}
