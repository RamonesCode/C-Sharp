using System;
using System.Globalization;

namespace MembrosEstaticos
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("CONVERTENDO O DÓLAR");
            Console.WriteLine();
            Console.Write("Qual é a cotação do dólar? ");
            double valorDolar = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            
            Console.Write("Quantos Dólares você vai comprar? ");
            double valorDesejado = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            double conversao = ConversorDeMoeda.ValorConvertido(valorDolar, valorDesejado);

            Console.WriteLine("Valor a ser pago em reais = " + conversao.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
