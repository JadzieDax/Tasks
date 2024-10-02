using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите целое четырехзначное число: ");
            int user_input = Convert.ToInt32(Console.ReadLine());

            int number1 = Math.Abs(user_input / 1000);
            int number4 = Math.Abs(user_input % 10);
            Console.WriteLine("Число тысяч: " + number1);
            Console.WriteLine("Число единиц: " + number4);

            int number2 = Math.Abs(user_input / 100 % 10);
            int number3 = Math.Abs(user_input / 10 % 10);

            Console.WriteLine("Произведение цифр числа: " + number1 * number2 * number3 * number4);

            Console.ReadLine();
        }
    }
}
