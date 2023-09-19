// 2° exercício de programação orientada a objeto: Jogo de Adivinhação.

using System;

namespace JogoAdivinhacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem-vindo ao Jogo de Adivinhação!");
            
            // Gere um número aleatório entre 1 e 100
            Random random = new Random();
            int numeroAleatorio = random.Next(1, 101);

            int tentativas = 0;
            bool acertou = false;

            do
            {
                Console.Write("Tente adivinhar o número: ");
                int palpite = int.Parse(Console.ReadLine());
                tentativas++;

                if (palpite == numeroAleatorio)
                {
                    acertou = true;
                }
                else if (palpite < numeroAleatorio)
                {
                    Console.WriteLine("Tente um número maior.");
                }
                else
                {
                    Console.WriteLine("Tente um número menor.");
                }
            } while (!acertou);

            Console.WriteLine($"Parabéns! Você acertou o número {numeroAleatorio} em {tentativas} tentativas.");
        }
    }
}
