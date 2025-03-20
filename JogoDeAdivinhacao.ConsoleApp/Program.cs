namespace JogoDeAdivinhacao.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" ---------------------------------------------");
            Console.WriteLine(" Jogo de adivinhação");
            Console.WriteLine(" ---------------------------------------------\n");

            Random geradorDeNumeros = new Random();

            int numeroSecreto = geradorDeNumeros.Next(1, 21);

            Console.Write("Digite um número entre 1 á 20 para a adivinhação: ");
            int numeroDigitado = Convert.ToInt32(Console.ReadLine());
            
            if (numeroDigitado == numeroSecreto)
            {
                Console.WriteLine(" ---------------------------------------------");
                Console.WriteLine(" Parabéns, você acertou!");
                Console.WriteLine(" ---------------------------------------------\n");
            }
            else if (numeroDigitado > numeroSecreto)
            {
                Console.WriteLine(" ---------------------------------------------");
                Console.WriteLine(" O número digitado foi maior que o número secreto!");
                Console.WriteLine(" ---------------------------------------------\n");
            }
            else if (numeroDigitado < numeroSecreto)
            {
                Console.WriteLine(" ---------------------------------------------");
                Console.WriteLine(" O número digitado foi menor que o número secreto!");
                Console.WriteLine(" ---------------------------------------------\n");
            }


                Console.ReadLine();
        }
    }
}
