using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salario.Teste
{
    class Funcionario
    {
        public decimal CalculaSariolLiquido(decimal salarioAtual, string cargo)
        {
            switch (cargo)
            {
                case "dev":
                    if (salarioAtual <= 3000)
                        return (salarioAtual*(decimal) 0.90);

                    return salarioAtual*(decimal) 0.80;
                    break;

                case "dba": 
                case "teste":
                    if (salarioAtual > 2500)
                        return salarioAtual*(decimal) 0.75;

                    return salarioAtual*(decimal) 0.85;
                    break;

            }

            return 0;
        }
    }
}
