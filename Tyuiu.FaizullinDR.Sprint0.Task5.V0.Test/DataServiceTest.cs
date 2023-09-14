using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
//Подключение библиотеки
using Tyuiu.FaizullinDR.Sprint0.Task5.V0.Lib;


namespace Tyuiu.FaizullinDR.Sprint0.Task5.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedAdditionValid()
        {
            //Сложение
            Assert.AreEqual(9, DataService.Addition(3, 6));
        }

        [TestMethod]
        public void CheckedSubstracionValid()
        {
            //Вычитание
            Assert.AreEqual(5, DataService.Substraction(12, 7));
        }

        [TestMethod]
        public void CheckedMultiplication()
        {
            //Умножение
            Assert.AreEqual(12, DataService.Multiplication(6, 2));
        }

        [TestMethod]
        public void CheckedDivisionValid()
        {
            //Деление
            Assert.AreEqual(3, DataService.Division(9, 3));
        }
    }
}
