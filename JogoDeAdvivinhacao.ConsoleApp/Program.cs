using System.Security.Cryptography;

int numeroAleatorio = RandomNumberGenerator.GetInt32(1, 21);

bool jogoDeveContinuar = true;

while (jogoDeveContinuar == true)
{
    Console.Clear();
    Console.WriteLine("-----------------------------------");
    Console.WriteLine("Jogo de Adivinhação");
    Console.WriteLine("-----------------------------------");

    Console.WriteLine();
    Console.Write("Digite um numero: ");
    int numeroDigitado = Convert.ToInt32(Console.ReadLine());

    if (numeroDigitado == numeroAleatorio)
    {
        Console.WriteLine("Parabéns, você acertou! O número era: " + numeroAleatorio);
    }

    else if (numeroDigitado > numeroAleatorio)
    {
        Console.WriteLine("O numero digitado foi maior que o número secreto!");
    }

    else
    {
        Console.WriteLine("O numero digitado foi menor que o número secreto!");
    }

    Console.WriteLine();
    Console.Write("Deseja Continuar: (S/N): ");
    string opcaoContinuar = Console.ReadLine().ToUpper();

    if (opcaoContinuar != "S")
    {
        jogoDeveContinuar = false;
    }
}