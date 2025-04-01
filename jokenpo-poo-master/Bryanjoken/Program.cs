
using System;

namespace Bryan
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcao;
            string status = "S";
            int jogadapc;
            int vitorias = 0;
            int empates = 0;
            int derrotas = 0;

            Console.WriteLine("Bem vindo ao jokempo!");
            Console.WriteLine("Escolha uma opção para jogar:");
            Console.WriteLine("MODO CLASSICO (1)");
            Console.WriteLine("MODO VERSUS (2)");
            opcao = Console.ReadLine();
            Console.Clear();

            if (opcao == "1")
            {
                // Modo Clássico
                Console.WriteLine("Digite seu nome:");
                string nome = Console.ReadLine();
                Console.WriteLine("Bem-vindo(a) " + nome);
                Console.ReadKey();
                Console.Clear();

                do
                {
                    Console.Clear();
                    Console.WriteLine("Jogador " + nome + " - Vitórias: " + vitorias + " | Empates: "
                        + empates + " | Derrotas: " + derrotas);
                    Console.WriteLine("Tecle 1- Papel, 2- Tesoura e 3- Pedra");
                    string jogada = Console.ReadLine();

                    Random aleatorio = new Random();
                    jogadapc = aleatorio.Next(1, 4);

                    Console.WriteLine("Computador jogou: " + ObterNomeJogada(jogadapc));

                    // Lógica de vitórias
                    if (jogada == jogadapc.ToString())
                    {
                        Console.WriteLine("Empate!");
                        empates++;
                    }
                    else if ((jogada == "1" && jogadapc == 3) ||
                             (jogada == "2" && jogadapc == 1) ||
                             (jogada == "3" && jogadapc == 2))
                    {
                        Console.WriteLine("Você venceu!");
                        vitorias++;
                    }
                    else
                    {
                        Console.WriteLine("Você perdeu!");
                        derrotas++;
                    }

                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("Deseja continuar? (s/n)");
                    status = Console.ReadLine().ToLower();

                } while (status == "s");
            }
            else if (opcao == "2")
            {
                // Modo Versus
                Console.WriteLine("Digite o nome do Jogador 1:");
                string jogador1 = Console.ReadLine();
                Console.WriteLine("Digite o nome do Jogador 2:");
                string jogador2 = Console.ReadLine();
                Console.Clear();

                int vitoriasJ1 = 0;
                int vitoriasJ2 = 0;
                int empatesVS = 0;

                do
                {
                    Console.Clear();
                    Console.WriteLine($"{jogador1}: {vitoriasJ1} vitórias | {jogador2}: {vitoriasJ2} vitórias | Empates: {empatesVS}");

                    // Jogador 1
                    Console.WriteLine($"{jogador1}, escolha: 1- Papel, 2- Tesoura, 3- Pedra");
                    string jogada1 = Console.ReadLine();
                    Console.Clear();

                    // Jogador 2
                    Console.WriteLine($"{jogador2}, escolha: 1- Papel, 2- Tesoura, 3- Pedra");
                    string jogada2 = Console.ReadLine();
                    Console.Clear();

                    Console.WriteLine($"{jogador1} jogou: {ObterNomeJogada(int.Parse(jogada1))}");
                    Console.WriteLine($"{jogador2} jogou: {ObterNomeJogada(int.Parse(jogada2))}");

                    // Lógica de vitórias
                    if (jogada1 == jogada2)
                    {
                        Console.WriteLine("Empate!");
                        empatesVS++;
                    }
                    else if ((jogada1 == "1" && jogada2 == "3") ||
                             (jogada1 == "2" && jogada2 == "1") ||
                             (jogada1 == "3" && jogada2 == "2"))
                    {
                        Console.WriteLine($"{jogador1} venceu!");
                        vitoriasJ1++;
                    }
                    else
                    {
                        Console.WriteLine($"{jogador2} venceu!");
                        vitoriasJ2++;
                    }

                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("Deseja continuar? (s/n)");
                    status = Console.ReadLine().ToLower();

                } while (status == "s");
            }
            else
            {
                Console.WriteLine("Opção inválida!");
                Console.ReadKey();
            }
        }

        static string ObterNomeJogada(int jogada)
        {
            switch (jogada)
            {
                case 1: return "Papel";
                case 2: return "Tesoura";
                case 3: return "Pedra";
                default: return "Inválida";
            }
        }
    }
}