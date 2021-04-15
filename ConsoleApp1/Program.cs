using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            ComplexNum c1 = new ComplexNum(4, 3);
            ComplexNum c2 = new ComplexNum(2, 3);
            c1.print();
            c2.print();

            ComplexNum sum = c1 + c2;
            sum.print();

            ComplexNum subtraction = c1 - c2;
            subtraction.print();

            ComplexNum multiplication = c1 * c2;
            multiplication.print();

            ComplexNum division = c1 / c2;
            division.print();

            ComplexNum implicitt = 9;
            implicitt.print();

            Console.WriteLine(c1 == c2);    

            double explicitt = (double)c1;    //explicit
            Console.WriteLine(explicitt);

            Console.WriteLine(c1 == c2);

            Console.ReadLine();
        }
    }
}
