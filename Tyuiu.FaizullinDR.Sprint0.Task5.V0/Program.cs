using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.FaizullinDR.Sprint0.Task5.V0.Lib;

namespace Tyuiu.FaizullinDR.Sprint0.Task5.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Пример линейной структуры
            Console.WriteLine("A + B = " + DataService.Addition(1, 5));
            Console.WriteLine("A - B = " + DataService.Substraction(6, 2));
            Console.WriteLine("A * B = " + DataService.Multiplication(3, 4));

            //Пример разветвляющейся структуры
            Console.WriteLine("A / B = " + DataService.Division(6, 3));

            Console.ReadKey();
        }
    }
}
