// 1° exercício de programação orientada a objeto: calcular média.

using System;

namespace CalculoMediaAlunos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora de Média de Notas");
            
            // Solicita o número de notas
            Console.Write("Quantas notas você deseja calcular? ");
            int numeroDeNotas = int.Parse(Console.ReadLine());

            double somaDasNotas = 0;

            // Loop para coletar as notas
            for (int i = 1; i <= numeroDeNotas; i++)
            {
                Console.Write($"Digite a nota {i}: ");
                double nota = double.Parse(Console.ReadLine());
                somaDasNotas += nota;
            }

            // Calcula a média
            double media = somaDasNotas / numeroDeNotas;

            // Exibe a média
            Console.WriteLine($"A média das notas é: {media:F2}");

            // Verifica se o aluno passou
            if (media >= 6.0)
            {
                Console.WriteLine("O aluno foi aprovado!");
            }
            else
            {
                Console.WriteLine("O aluno foi reprovado.");
            }
        }
    }
}
