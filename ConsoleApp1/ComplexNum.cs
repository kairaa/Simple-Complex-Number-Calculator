using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ComplexNum
    {
        public double real;
        public double imaginary;

        public ComplexNum(double r, double i)
        {
            real = r;
            imaginary = i;
        }

        public void print()
        {
            Console.WriteLine(imaginary >= 0 ? real + "+" + imaginary + "i" : real + "" + imaginary + "i");
        }

        public static implicit operator ComplexNum(double sayi)
        {
            return new ComplexNum(sayi, 0);
        }

        public static explicit operator double (ComplexNum c)
        {
            return Math.Sqrt((c.real*c.real) + (c.imaginary*c.imaginary));
        }

        public static ComplexNum calculateConjugate(ComplexNum c)
        {
            return new ComplexNum(c.real, (-1)*c.imaginary);
        }

        public static ComplexNum operator+(ComplexNum c1,ComplexNum c2)
        {
            double r = c1.real + c2.real;
            double i = c1.imaginary + c2.imaginary;
            return new ComplexNum(r, i);
        }

        public static ComplexNum operator-(ComplexNum c1, ComplexNum c2)
        {
            double r = c1.real - c2.real;
            double i = c1.imaginary - c2.imaginary;
            return new ComplexNum(r, i);
        }

        public static ComplexNum operator*(ComplexNum c1, ComplexNum c2)
        {
            double r = (c1.real * c2.real)-(c2.imaginary*c1.imaginary);
            double i = (c1.real * c2.imaginary) + (c1.imaginary*c2.real);
            return new ComplexNum(r, i);
        }

        public static ComplexNum operator/(ComplexNum c1,ComplexNum c2)
        {
            double a = c1.real;
            double b = c1.imaginary;
            double c = c2.real;
            double d = c2.imaginary;


            double real = ((a * c) + (b * d)) / (c * c + d * d);
            double imaginary = ((b * c) - (a * d)) / (c * c + d * d);

            return new ComplexNum(real, imaginary);
        }

        public static bool operator==(ComplexNum c1,ComplexNum c2)
        {
            return c1.real == c2.real && c1.imaginary == c2.imaginary;
        }

        public static bool operator!=(ComplexNum c1, ComplexNum c2)
        {
            return c1.real != c2.real || c1.imaginary != c2.imaginary;
            //return !(c1==c2)
        }


    }
}
