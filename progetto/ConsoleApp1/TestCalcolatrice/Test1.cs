﻿using ClassLibrary1;

namespace TestCalcolatrice
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //crea test per metodo Somma della classe Calcolatrice
            Calcolatrice calcolatrice = new Calcolatrice();
            double risultato = calcolatrice.Somma(2, 3);
            Assert.AreEqual(5, risultato, "La somma di 2 e 3 dovrebbe essere 5");
        }
        [TestMethod]
        public void TestSommaConZero()
        {
            Calcolatrice calcolatrice = new Calcolatrice();
            double risultato = calcolatrice.Somma(0, 3);
            Assert.AreEqual(3, risultato, "La somma di 0 e 3 dovrebbe essere 5");
        }
    }
}
