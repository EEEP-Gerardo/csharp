using System;
using System.Collections.Generic;

namespace SimuladorBanco
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem-vindo ao Simulador de Banco!");
            
            List<ContaBancaria> contas = new List<ContaBancaria>();

            while (true)
            {
                Console.WriteLine("\nOpções:");
                Console.WriteLine("1 - Criar conta");
                Console.WriteLine("2 - Fazer depósito");
                Console.WriteLine("3 - Fazer saque");
                Console.WriteLine("4 - Sair");
                Console.Write("Escolha uma opção: ");

                int opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.Write("Digite o nome do titular da conta: ");
                        string nomeTitular = Console.ReadLine();
                        Console.Write("Digite o saldo inicial: ");
                        double saldoInicial = double.Parse(Console.ReadLine());

                        ContaBancaria novaConta = new ContaBancaria(nomeTitular, saldoInicial);
                        contas.Add(novaConta);

                        Console.WriteLine($"Conta criada com sucesso! Número da conta: {novaConta.NumeroConta}");
                        break;

                    case 2:
                        Console.Write("Digite o número da conta: ");
                        int numeroContaDeposito = int.Parse(Console.ReadLine());
                        Console.Write("Digite o valor do depósito: ");
                        double valorDeposito = double.Parse(Console.ReadLine());

                        ContaBancaria contaDeposito = contas.Find(conta => conta.NumeroConta == numeroContaDeposito);

                        if (contaDeposito != null)
                        {
                            contaDeposito.Depositar(valorDeposito);
                            Console.WriteLine("Depósito realizado com sucesso!");
                        }
                        else
                        {
                            Console.WriteLine("Conta não encontrada.");
                        }
                        break;

                    case 3:
                        Console.Write("Digite o número da conta: ");
                        int numeroContaSaque = int.Parse(Console.ReadLine());
                        Console.Write("Digite o valor do saque: ");
                        double valorSaque = double.Parse(Console.ReadLine());

                        ContaBancaria contaSaque = contas.Find(conta => conta.NumeroConta == numeroContaSaque);

                        if (contaSaque != null)
                        {
                            if (contaSaque.Sacar(valorSaque))
                            {
                                Console.WriteLine("Saque realizado com sucesso!");
                            }
                            else
                            {
                                Console.WriteLine("Saldo insuficiente.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Conta não encontrada.");
                        }
                        break;

                    case 4:
                        Console.WriteLine("Obrigado por utilizar o Simulador de Banco!");
                        return;

                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
            }
        }
    }

    class ContaBancaria
    {
        private static int proximoNumeroConta = 1;

        public int NumeroConta { get; }
        public string Titular { get; }
        public double Saldo { get; private set; }

        public ContaBancaria(string titular, double saldoInicial)
        {
            NumeroConta = proximoNumeroConta++;
            Titular = titular;
            Saldo = saldoInicial;
        }

        public void Depositar(double valor)
        {
            Saldo += valor;
        }

        public bool Sacar(double valor)
        {
            if (valor <= Saldo)
            {
                Saldo -= valor;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
