using System;
using System.Globalization;

namespace LerDadosConta
{
    class ContaBancaria  
    {
        // CLASSE ABAIXO ESTÃO EM UM  SEQUÊNCIA QUE É UM PADRÃO SUGERIDO PARA IMPLEMTAÇÕES DE CLASSE :

        // ATRIBUTOS PRIVADOS
        // PROPRIEDADES AUTO IMPLEMENTADAS
        // CONSTRUTORES
        // PROPRIEDADES CUSTOMIZADAS
        // OUTROS MÉTODOS DA CLASSE


        // ATRIBUTOS PRIVADOS + PROPRIES AUTO IMPLEMENTADAS
        public int Numero { get; private set; }
        public string Titular { get; set; } // Essa declaração permite alteração total  ( PROPRIE ) 
        public double Saldo { get; private set; } // Essa declaração de atributo priva a alteração de valores pelo usuario/progamador

        // CONSTRUTOR 
        public ContaBancaria(int numero, string titular) // Esse construtor recebe apenas dois parametros
        {
            Numero = numero;
            Titular = titular;

        }

        //CONSTRUTOR ** SOBRECARGA **
        //--- Esse construtor recebe apenas um parametro (depositoInicial) MAS faz o uso do THIS para aproveitar parametros já existentes.
        public ContaBancaria(int numero, string titular, double depositoInicial) : this(numero, titular)
        {
            //Saldo = Saldo + depositoInicial; ===> Essa é uma possivel declaração, porém o fato abaixo deixo o projeto mais consistente.

            Deposito(depositoInicial); // Colocando o método dentro do construtor o projeto fica melhor para manutenção,  
        }                             //  caso um dia haja uma atualização no método deposito o construtor será atualizado tbm.


        // PROPRIES CUSTOMIZADAS 
        // ==exemplo==

        // public void SetTitular(string titular)
        // {
        //     if (titular != null && titular.Length > 1)
        //    {
        //        Titular = titular;
        //    }

        public double Deposito(double quantia)
        {
            return Saldo += quantia;
        }

        public double Saque(double saque)
        {
            return Saldo -= saque + 5.00;
        }

        public override string ToString()
        {
            return "Conta "
                + Numero
                + ", Titular: "
                + Titular
                + ", Saldo: R$ "
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }


    }
}
