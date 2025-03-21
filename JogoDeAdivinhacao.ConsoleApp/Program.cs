using System.Diagnostics.Tracing;

namespace JogoDeAdivinhacao.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int[] numeroDigitados = new int[10];
                int contador = 0;

                Console.Clear();
                Console.WriteLine(" ---------------------------------------------");
                Console.WriteLine(" Jogo de adivinhação");
                Console.WriteLine(" ---------------------------------------------\n");

                Console.WriteLine(" Nível de dificuldade");
                Console.WriteLine(" ---------------------------------------------");
                Console.WriteLine(" 1 - Fácil (10 tentativas)");
                Console.WriteLine(" 2 - Normal (5 tentativas)");
                Console.WriteLine(" 3 - Difícil (3 tentativas)");
                Console.WriteLine(" ---------------------------------------------\n");

                Console.Write(" Escolha um nível de dificuldade: ");
                string escolhaDeDificuldade = Console.ReadLine();

                int totalDeTentativas = 0;

                if (escolhaDeDificuldade == "1")
                    totalDeTentativas = 10;

                else if (escolhaDeDificuldade == "2")
                    totalDeTentativas = 5;

                else if (escolhaDeDificuldade == "3")
                    totalDeTentativas = 3;

                Random geradorDeNumeros = new Random();
                int numeroSecreto = geradorDeNumeros.Next(1, 21);

                for (int tentativa = 1; tentativa <= totalDeTentativas; tentativa++)
                {
                    Console.Clear();
                    Console.WriteLine(" ---------------------------------------------");
                    Console.WriteLine($" Tentativa {tentativa} de {totalDeTentativas}");
                    Console.WriteLine(" ---------------------------------------------");

                    if (numeroDigitados[0] != 0)
                    {
                        Console.Write(" Número já digitados: ");
                        for (int numeroTentado = 0; numeroTentado < 10; numeroTentado++)
                        {
                            if (numeroDigitados[numeroTentado] != 0)
                                if (numeroTentado != 0)
                                {
                                    Console.Write($" {numeroDigitados[numeroTentado]},");
                                }
                                else
                                {
                                    Console.Write(numeroDigitados[0]);
                                }
                        }

                        Console.WriteLine("\n ---------------------------------------------\n");
                    }
                    
                    Console.Write(" Digite um número entre 1 á 20 para a adivinhação: ");
                    int numeroDigitado = Convert.ToInt32(Console.ReadLine());

                    if (numeroDigitado == numeroSecreto)
                    {
                        Console.Clear();
                        Console.WriteLine(" ---------------------------------------------");
                        Console.WriteLine(" Parabéns, você acertou!");
                        Console.WriteLine(" ---------------------------------------------\n");
                        break;
                    }
                    else if (numeroDigitado > numeroSecreto)
                    {
                        Console.Clear();
                        Console.WriteLine(" ---------------------------------------------");
                        Console.WriteLine(" O número digitado foi maior que o número secreto!");
                        Console.WriteLine(" ---------------------------------------------\n");
                        numeroDigitados[contador] = numeroDigitado;
                        contador += 1;
                    }
                    else if (numeroDigitado < numeroSecreto)
                    {
                        Console.Clear();
                        Console.WriteLine(" ---------------------------------------------");
                        Console.WriteLine(" O número digitado foi menor que o número secreto!");
                        Console.WriteLine(" ---------------------------------------------\n");
                        numeroDigitados[contador] = numeroDigitado;
                        contador += 1;
                    }

                    Console.Write(" Pressione ENTER para continuar...");
                    Console.ReadLine();
                }

                Console.Clear();
                Console.Write("\n Deseja continuar (S/N)? ");
                string opcaoContinuar = Console.ReadLine().ToUpper();

                if (opcaoContinuar == "N")
                    break;
            }
        }
    }
}
