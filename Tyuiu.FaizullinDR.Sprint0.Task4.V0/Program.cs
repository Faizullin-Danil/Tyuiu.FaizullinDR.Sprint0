using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.FaizullinDR.Sprint0.Task4.V0.Lib;

namespace Tyuiu.FaizullinDR.Sprint0.Task4.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            //Пример линейной структуры программы
            //Вызов метода сложения Addt=ition
            Console.WriteLine(DataService.Addition(1, 5));
            //Вызов метода вычитания Substraction
            Console.WriteLine(DataService.Subtraction(1, 5));
            //Вызов метода умножение Multiplication
            Console.WriteLine(DataService.Multiplication(3, 5));
            //Вызов метода деления Division
            Console.WriteLine(DataService.Division(9, 3));

            Console.ReadKey();
        }
    }
}
