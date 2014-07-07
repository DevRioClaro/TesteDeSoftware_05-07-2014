using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculadora
{
    [TestClass]
    public class Calculos_Teste
    {
        [TestMethod]
        public void Somar_PrimeiroValor_Positivo_SegundoValor_Positivo()
        {
            //Preparar
            Calculos obj = new Calculos();

            //Executar (exercitar)
            decimal resultado = obj.EfetuarCalculo(10, 2, '+');

            //Verificar
            Assert.AreEqual(12, resultado);
        }

        [TestMethod]
        public void Somar_PrimeiroValor_Negativo_SegundoValor_Negativo()
        {
            //Preparar
            Calculos obj = new Calculos();

            //Executar (exercitar)
            decimal resultado = obj.EfetuarCalculo(-3, -5, '+');

            //Verificar
            Assert.AreEqual(-8, resultado);
        }

        [TestMethod]
        public void Somar_PrimeiroValor_Positivo_SegundoValor_Negativo()
        {
            //Preparar
            Calculos obj = new Calculos();

            //Executar (exercitar)
            decimal resultado = obj.EfetuarCalculo(10, -3, '+');

            //Verificar
            Assert.AreEqual(7, resultado);
        }

        [TestMethod]
        public void Somar_PrimeiroValor_Negativo_SegundoValor_Positivo()
        {
            //Preparar
            Calculos obj = new Calculos();

            //Executar (exercitar)
            decimal resultado = obj.EfetuarCalculo(-5, 18, '+');

            //Verificar
            Assert.AreEqual(13, resultado);
        }

        [TestMethod]
        public void Somar_PrimeiroValor_Zero_SegundoValor_NaoZero()
        {
            //Preparar
            Calculos obj = new Calculos();

            //Executar (exercitar)
            decimal resultado = obj.EfetuarCalculo(0, 9, '+');

            //Verificar
            Assert.AreEqual(9, resultado);
        }

        [TestMethod]
        public void Somar_PrimeiroValor_NaoZero_SegundoValor_Zero()
        {
            //Preparar
            Calculos obj = new Calculos();

            //Executar (exercitar)
            decimal resultado = obj.EfetuarCalculo(9, 0, '+');

            //Verificar
            Assert.AreEqual(9, resultado);
        }

        [TestMethod]
        public void Subtrair_PrimeiroValor_Positivo_SegundoValor_Positivo()
        {
            //Preparar
            Calculos obj = new Calculos();

            //Executar (exercitar)
            decimal resultado = obj.EfetuarCalculo(10, 2, '-');

            //Verificar
            Assert.AreEqual(8, resultado);
        }

        [TestMethod]
        public void Subtrair_PrimeiroValor_Negativo_SegundoValor_Negativo()
        {
            //Preparar
            Calculos obj = new Calculos();

            //Executar (exercitar)
            decimal resultado = obj.EfetuarCalculo(-3, -5, '-');

            //Verificar
            Assert.AreEqual(2, resultado);
        }

        [TestMethod]
        public void Subtrair_PrimeiroValor_Positivo_SegundoValor_Negativo()
        {
            //Preparar
            Calculos obj = new Calculos();

            //Executar (exercitar)
            decimal resultado = obj.EfetuarCalculo(10, -3, '-');

            //Verificar
            Assert.AreEqual(13, resultado);
        }

        [TestMethod]
        public void Subtrair_PrimeiroValor_Negativo_SegundoValor_Positivo()
        {
            //Preparar
            Calculos obj = new Calculos();

            //Executar (exercitar)
            decimal resultado = obj.EfetuarCalculo(-5, 18, '-');

            //Verificar
            Assert.AreEqual(-23, resultado);
        }

        [TestMethod]
        public void Subtrair_PrimeiroValor_Zero_SegundoValor_NaoZero()
        {
            //Preparar
            Calculos obj = new Calculos();

            //Executar (exercitar)
            decimal resultado = obj.EfetuarCalculo(0, 9, '-');

            //Verificar
            Assert.AreEqual(-9, resultado);
        }

        [TestMethod]
        public void Subtrair_PrimeiroValor_NaoZero_SegundoValor_Zero()
        {
            //Preparar
            Calculos obj = new Calculos();

            //Executar (exercitar)
            decimal resultado = obj.EfetuarCalculo(9, 0, '-');

            //Verificar
            Assert.AreEqual(9, resultado);
        }

        [TestMethod]
        public void Multiplicar_PrimeiroValor_Positivo_SegundoValor_Positivo()
        {
            //Preparar
            Calculos obj = new Calculos();

            //Executar (exercitar)
            decimal resultado = obj.EfetuarCalculo(10, 2, '*');

            //Verificar
            Assert.AreEqual(20, resultado);
        }

        [TestMethod]
        public void Multiplicar_PrimeiroValor_Negativo_SegundoValor_Negativo()
        {
            //Preparar
            Calculos obj = new Calculos();

            //Executar (exercitar)
            decimal resultado = obj.EfetuarCalculo(-3, -5, '*');

            //Verificar
            Assert.AreEqual(15, resultado);
        }

        [TestMethod]
        public void Multiplicar_PrimeiroValor_Positivo_SegundoValor_Negativo()
        {
            //Preparar
            Calculos obj = new Calculos();

            //Executar (exercitar)
            decimal resultado = obj.EfetuarCalculo(10, -3, '*');

            //Verificar
            Assert.AreEqual(-30, resultado);
        }

        [TestMethod]
        public void Multiplicar_PrimeiroValor_Negativo_SegundoValor_Positivo()
        {
            //Preparar
            Calculos obj = new Calculos();

            //Executar (exercitar)
            decimal resultado = obj.EfetuarCalculo(-5, 18, '*');

            //Verificar
            Assert.AreEqual(-90, resultado);
        }

        [TestMethod]
        public void Multiplicar_PrimeiroValor_Zero_SegundoValor_NaoZero()
        {
            //Preparar
            Calculos obj = new Calculos();

            //Executar (exercitar)
            decimal resultado = obj.EfetuarCalculo(0, 9, '*');

            //Verificar
            Assert.AreEqual(0, resultado);
        }

        [TestMethod]
        public void Multiplicar_PrimeiroValor_NaoZero_SegundoValor_Zero()
        {
            //Preparar
            Calculos obj = new Calculos();

            //Executar (exercitar)
            decimal resultado = obj.EfetuarCalculo(9, 0, '*');

            //Verificar
            Assert.AreEqual(0, resultado);
        }

        [TestMethod]
        public void Dividir_PrimeiroValor_Positivo_SegundoValor_Positivo()
        {
            //Preparar
            Calculos obj = new Calculos();

            //Executar (exercitar)
            decimal resultado = obj.EfetuarCalculo(10, 2, '/');

            //Verificar
            Assert.AreEqual(5, resultado);
        }

        [TestMethod]
        public void Dividir_PrimeiroValor_Negativo_SegundoValor_Negativo()
        {
            //Preparar
            Calculos obj = new Calculos();

            //Executar (exercitar)
            decimal resultado = obj.EfetuarCalculo(-3, -5, '/');

            //Verificar
            Assert.AreEqual(0.6m, resultado);
        }

        [TestMethod]
        public void Dividir_PrimeiroValor_Positivo_SegundoValor_Negativo()
        {
            //Preparar
            Calculos obj = new Calculos();

            //Executar (exercitar)
            decimal resultado = obj.EfetuarCalculo(10, -5, '/');

            //Verificar
            Assert.AreEqual(-2, resultado);
        }

        [TestMethod]
        public void Dividir_PrimeiroValor_Negativo_SegundoValor_Positivo()
        {
            //Preparar
            Calculos obj = new Calculos();

            //Executar (exercitar)
            decimal resultado = obj.EfetuarCalculo(-5, 20, '/');

            //Verificar
            Assert.AreEqual(-0.25m, resultado);
        }

        [TestMethod]
        public void Dividir_PrimeiroValor_Zero_SegundoValor_NaoZero()
        {
            //Preparar
            Calculos obj = new Calculos();

            //Executar (exercitar)
            decimal resultado = obj.EfetuarCalculo(0, 9, '/');

            //Verificar
            Assert.AreEqual(0, resultado);
        }

        [TestMethod]
        public void Dividir_PrimeiroValor_NaoZero_SegundoValor_Zero()
        {
            //Preparar
            Calculos obj = new Calculos();

            //Executar (exercitar)
            decimal resultado = obj.EfetuarCalculo(9, 0, '/');

            //Verificar
            Assert.AreEqual(0, resultado);
        }
    }
}
