using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ejercicio_01;
using System;

namespace Ejercicio_01___Test_1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        { 
            int resultado = CalculadoraDeString.Add("2,2");

            Assert.AreEqual(4, resultado);
        }
    }
}
