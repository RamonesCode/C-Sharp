using System;

namespace Project5
{
    class Program
    {
        static void Main(string[] args)
        {
            // EXERCITANDO CLASSES 
            // PROGRAMA PARA  LER OS DADOS DE DUAS PESSOAS,DEPOIS MOTRAR O NOME DA PESSOA MAIS VELHA

            // CRIANDO VARIAVEIS DO TIPO DA CLASSE
            Pessoa primeira, segunda;  
            string Mvelha;
            // AQUI PRECISA SER INSTANCIADA A VARIAVEL COM A CLASSE
            primeira = new Pessoa(); 
            segunda = new Pessoa();

            Console.WriteLine("Dados da primeira pessoa:");
            Console.Write("Nome: ");
            // AQUI A VARIAVEL CRIADA ESTÁ APONTANDO PARA QUAL ATRIBUTO DA CLASSE SEJA PREENCHIDO
            primeira.nome = Console.ReadLine();
            Console.Write("Idade: ");
            primeira.idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Dados da segunda pessoa:");
            Console.Write("Nome: ");
            segunda.nome = Console.ReadLine();
            Console.Write("Idade: ");
            segunda.idade = int.Parse(Console.ReadLine());
            // CONDICIONAL PARA VALIDAR QUAL DAS DUAS PESSOAS É A MAIS VELHA
            if (primeira.idade > segunda.idade)
            {
                Mvelha = primeira.nome;

            }
            else
            {
                Mvelha = segunda.nome;
            }
            Console.WriteLine("Pessoa mais velha: {0} ", Mvelha);
        }

    }
}
