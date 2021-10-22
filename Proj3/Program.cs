using System;
using System.Globalization;

namespace Proj3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" EXERCÍCIO DE FIXAÇÃO AULA 23");
            Console.WriteLine(" Entre com seu nome completo: ");
            string nomeCpl = Console.ReadLine();
            Console.WriteLine(" Quantos quartos tem na sua casa? " );
            int quarto = int.Parse(Console.ReadLine());
            Console.WriteLine(" Entre com o preço de um produto: ");
            double precoPro = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine(" Entre com seu último nome, idade e altura (mesma linha): ");
            string[] frase = Console.ReadLine().Split(" ");
            string ultNome = frase[0];
            int idade = int.Parse(frase[1]);
            double altura = double.Parse(frase[2]);//, CultureInfo.InvariantCulture);
            Console.WriteLine("Resultado");
            Console.WriteLine(nomeCpl);
            Console.WriteLine(quarto);
            Console.WriteLine(precoPro.ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine(ultNome);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
