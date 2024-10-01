using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите длину первого основания трапеции: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите длину второго основания трапеции: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите высоту трапеции: ");
            double h = Convert.ToDouble(Console.ReadLine());
            double S = Math.Abs(a + b) * h / 2 ;
            Console.WriteLine("Площадь трапеции: {0:0.00}", S);
            double P = Math.Sqrt(Math.Pow(Math.Abs(a - b) / 2, 2) + Math.Pow(h, 2)) * 2 + a + b;
            Console.WriteLine("Периметр трапеции: {0:0.00}", P);
            Console.ReadLine();
        }
    }
}
