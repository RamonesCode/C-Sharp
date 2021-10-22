using System;
using System.Globalization;

namespace LerDadosConta
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria conta;

            Console.WriteLine("Leitura de dados bancários");
            Console.WriteLine();
            Console.Write("Entre com o número da conta bancária: ");
            int numero = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Entre com o nome do titular da conta: ");
            string titular = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n) ? ");
            char resp = char.Parse(Console.ReadLine());
            if (resp == 's' || resp == 'S')
            {
                Console.Write("Entre com o valor do depósito inicial: ");
                double depositoInicail = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new ContaBancaria(numero, titular, depositoInicail);
            }
            else
            {
                conta = new ContaBancaria(numero, titular);
                Console.Write("Quer depositar agora (s/n) ? ");
                char dp = char.Parse(Console.ReadLine());

                if (dp == 's' || dp == 'S')
                {
                    Console.WriteLine();
                    Console.Write("Entre com um valor para depósito: ");
                    double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    conta.Deposito(quantia);

                }

            }

            Console.Write("Quer realizar um saque (s/n) ? ");
            char sq = char.Parse(Console.ReadLine());
            if (sq == 's' || sq == 'S')
            {
                Console.WriteLine();
                Console.Write("Entre com um valor para saque: ");
                double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta.Saque(saque);
              
            }
          
                Console.WriteLine();
                Console.WriteLine("Dados atualizados: ");
                Console.WriteLine(conta);
           

        }
    }
}
