using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.FaizullinDR.Sprint0.Task2.V0.Lib;

namespace Tyuiu.FaizullinDR_Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            //область создания методов тестирования, методов из библиотеки
            var name = "Данил";
            var res = DataService.GetMessage(name);

            //Вызываем класс Assert и метод AreEqua1
            Assert.AreEqual("Привет..., Данил", res);
        }
    }
}
