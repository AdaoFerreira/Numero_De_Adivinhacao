using System;

class Jogo
{
    private int numeroMinimo { get; set; }
    private int numeroMaxino { get; set; }
    private Random NumeroAleatorio = new Random();
    private int Palpite { get; set; }
    private int Tentativas { get; set; }
    private int numeroSecreto { get; set; }


    public void Mensagem()
    {
        Console.WriteLine("Bem-vindo ao jogo de adivinhação de números!");
        Console.WriteLine("Vamos definir o intervalo para adivinhação.");

        Console.Write("Digite o número mínimo do intervalo: ");
        numeroMinimo = int.Parse(Console.ReadLine());

        Console.Write("Digite o número máximo do intervalo: ");
        numeroMaxino = int.Parse(Console.ReadLine());

        // Gerando um número aleatório dentro do intervalo definido
        
        numeroSecreto = NumeroAleatorio.Next(numeroMinimo, numeroMaxino + 1);

        Console.WriteLine($"Um número entre {numeroMinimo} e {numeroMaxino} foi gerado. Agora tente adivinhar!");

        do
        {
            
            Console.Write("Digite o seu palpite: ");
            Palpite = int.Parse(Console.ReadLine());
            Tentativas++;

            if (Palpite == numeroSecreto)
            {
                Console.WriteLine($"Parabéns! Você acertou o número {numeroSecreto} em {Tentativas} tentativa(s)!");
            }
            else if (Palpite < numeroSecreto)
            {
                Console.WriteLine("Tente novamente. O número é maior.");
            }
            else
            {
                Console.WriteLine("Tente novamente. O número é menor.");
            }

        } while (Palpite != numeroSecreto);

        Console.WriteLine("Obrigado por jogar!");
    }



} 

