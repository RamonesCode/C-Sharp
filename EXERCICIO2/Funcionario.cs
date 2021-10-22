using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace EXERCICIO2
{
    class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public override string ToString()
        {
            return Nome
                + ", Salário de R$ "
                + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }

        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }

        public void AumentarSalario(double porcentagem)
        {
            SalarioBruto = SalarioBruto + (SalarioBruto * porcentagem / 100.0);
        }


    }
}
