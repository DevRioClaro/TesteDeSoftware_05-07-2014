using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Salario.Teste
{
    [TestClass]
    public class Funcionario_Teste
    {
        [TestMethod]
        public void Quando_Salario_3000_Cargo_Desenvolvedor()
        {
            //Prepara
            Funcionario func = new Funcionario();

            //Executar
            decimal salarioLiquido = func.CalculaSariolLiquido(3000, "dev");

            //Verificar
            Assert.AreEqual(2700, salarioLiquido);
        }

        [TestMethod]
        public void Quando_Salario_3500_Cargo_Desenvolvedor()
        {
            //Prepara
            Funcionario func = new Funcionario();

            //Executar
            decimal salarioLiquido = func.CalculaSariolLiquido(3500, "dev");

            //Verificar
            Assert.AreEqual(2800, salarioLiquido);
        }

        [TestMethod]
        public void Quando_Salario_4000_Cargo_DBA()
        {
            //Prepara
            Funcionario func = new Funcionario();

            //Executar
            decimal salarioLiquido = func.CalculaSariolLiquido(4000, "dba");

            //Verificar
            Assert.AreEqual(3000, salarioLiquido);
        }

        [TestMethod]
        public void Quando_Salario_2000_Cargo_DBA()
        {
            //Prepara
            Funcionario func = new Funcionario();

            //Executar
            decimal salarioLiquido = func.CalculaSariolLiquido(2000, "dba");

            //Verificar
            Assert.AreEqual(1700, salarioLiquido);
        }

        [TestMethod]
        public void Quando_Salario_2000_Cargo_Testador()
        {
            //Prepara
            Funcionario func = new Funcionario();

            //Executar
            decimal salarioLiquido = func.CalculaSariolLiquido(2000, "teste");

            //Verificar
            Assert.AreEqual(1700, salarioLiquido);
        }
    }
}
