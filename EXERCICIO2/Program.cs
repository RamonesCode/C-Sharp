using System;
using System.Globalization;

namespace EXERCICIO2
{
    class Program
    {
        static void Main(string[] args)
        {

            Funcionario func = new Funcionario();
            
            
            Console.WriteLine(" Programa para ler dados de um Funcionário.");
            Console.WriteLine();
            Console.Write(" Nome do Funcionário : ");
            func.Nome = Console.ReadLine();
            Console.Write(" Salário bruto : ");
            func.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write(" Imposto : ");
            func.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine(" Funcionário : " + func);
            Console.WriteLine();

            Console.Write(" Deseja aumentar o salário em qual porcentagem ? ");
            double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            func.AumentarSalario(porcentagem);


            Console.WriteLine();
            Console.WriteLine(" Dados atualizados : " + func);



        }
    }
}
