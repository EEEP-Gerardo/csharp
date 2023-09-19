// 3° exercício de programação orientada a objeto: Lista de Tarefas 

using System;
using System.Collections.Generic;

namespace GerenciadorDeTarefas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> tarefas = new List<string>();

            while (true)
            {
                Console.WriteLine("Gerenciador de Tarefas");
                Console.WriteLine("1. Adicionar Tarefa");
                Console.WriteLine("2. Listar Tarefas");
                Console.WriteLine("3. Marcar Tarefa como Concluída");
                Console.WriteLine("4. Sair");
                Console.Write("Escolha uma opção: ");

                int opcao;
                if (int.TryParse(Console.ReadLine(), out opcao))
                {
                    switch (opcao)
                    {
                        case 1:
                            Console.Write("Digite a descrição da tarefa: ");
                            string descricao = Console.ReadLine();
                            tarefas.Add(descricao);
                            Console.WriteLine("Tarefa adicionada com sucesso!");
                            break;

                        case 2:
                            Console.WriteLine("Lista de Tarefas:");
                            for (int i = 0; i < tarefas.Count; i++)
                            {
                                Console.WriteLine($"{i + 1}. {tarefas[i]}");
                            }
                            break;

                        case 3:
                            Console.Write("Digite o número da tarefa concluída: ");
                            if (int.TryParse(Console.ReadLine(), out int numeroTarefa) &&
                                numeroTarefa >= 1 && numeroTarefa <= tarefas.Count)
                            {
                                tarefas.RemoveAt(numeroTarefa - 1);
                                Console.WriteLine("Tarefa marcada como concluída!");
                            }
                            else
                            {
                                Console.WriteLine("Número de tarefa inválido.");
                            }
                            break;

                        case 4:
                            Console.WriteLine("Saindo do programa.");
                            return;

                        default:
                            Console.WriteLine("Opção inválida. Tente novamente.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Opção inválida. Tente novamente.");
                }

                Console.WriteLine(); // Linha em branco para melhorar a legibilidade
            }
        }
    }
}
