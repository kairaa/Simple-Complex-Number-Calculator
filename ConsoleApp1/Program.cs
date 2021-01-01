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

            ComplexNum c3 = c1 + c2;
            c3.print();

            ComplexNum c4 = c1 - c2;
            c4.print();

            ComplexNum c5 = c1 * c2;
            c5.print();

            ComplexNum c6 = c1 / c2;    //doğru çalışmıyor
            c6.print();

            ComplexNum c8 = 8;          //implicit
            c8.print();

            Console.WriteLine(c1 == c2);

            /*ComplexNum c9 = new ComplexNum(2, 3);
            c9.birYaz(c9);*/            

            double c10 = (double)c1;    //explicit
            Console.WriteLine(c10);

            ComplexNum c11 = c10;   //implicit (c1 den geleni X+0i biçimine döndürüyor)
            c11.print();

            Console.ReadLine();
        }
    }
}
