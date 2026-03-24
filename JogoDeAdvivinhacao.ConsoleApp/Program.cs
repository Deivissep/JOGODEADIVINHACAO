using System.Security.Cryptography;

///int numeroAleatorio = RandomNumberGenerator.GetInt32(1, 21);

bool jogoDeveContinuar = true;

string[] numerosDigitados = new string[100];
int tentativas = 0;

while (jogoDeveContinuar == true)
{
    Console.Clear();
    Console.WriteLine("-----------------------------------");
    Console.WriteLine("Jogo de Adivinhação");
    Console.WriteLine("-----------------------------------");
    Console.WriteLine("Escolha o nível de dificuldade:");
    Console.WriteLine("1 - Fácil (10 tentativas)");
    Console.WriteLine("2 - Médio (5 tentativas)");
    Console.WriteLine("3 - Dificil (3 tentativas)");
    Console.WriteLine("-----------------------------------");

    Console.Write("Digite sua escolha: ");
    string dificuldadeEscolhida = Console.ReadLine();

    int numeroAleatorio;
    int tentativasMaximas;

    switch (dificuldadeEscolhida)
    {
        case "1":
            numeroAleatorio = RandomNumberGenerator.GetInt32(1, 21);
            tentativasMaximas = 10;
            break;

        case "2":
            numeroAleatorio = RandomNumberGenerator.GetInt32(1, 51);
            tentativasMaximas = 5;
            break;

        case "3":
            numeroAleatorio = RandomNumberGenerator.GetInt32(1, 101);
            tentativasMaximas = 3;
            break;

        default:
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Por Favor, selecione uma dificuldade válida.");
            Console.Write("Digite ENTER para continuar...");
            Console.ReadLine();
            continue;
    }

    for (int tentativaAtual = 1; tentativaAtual <= tentativasMaximas; tentativaAtual++)
    {
        Console.Clear();
        Console.WriteLine("-----------------------------------");
        Console.WriteLine("Jogo de Adivinhação");
        Console.WriteLine("-----------------------------------");
        Console.WriteLine($"Tentativa {tentativaAtual} de {tentativasMaximas}");
        Console.WriteLine("-----------------------------------");
        Console.Write("Digite um numero: ");
        int numeroDigitado = Convert.ToInt32(Console.ReadLine());


        if (numeroDigitado == numeroAleatorio)
        {
            Console.WriteLine("Parabéns, você acertou! O número era: " + numeroAleatorio);
            break;
        }

        else if (numeroDigitado > numeroAleatorio)
        {
            Console.WriteLine("O numero digitado foi maior que o número secreto!");
        }

        else
        {
            Console.WriteLine("O numero digitado foi menor que o número secreto!");
        }

        Console.WriteLine("-----------------------------------");
        Console.Write("Digite ENTER para continuar...");
        Console.ReadLine();
    }

    Console.WriteLine();
    Console.Write("Deseja Continuar: (S/N): ");
    string opcaoContinuar = Console.ReadLine()!.ToUpper();

    if (opcaoContinuar != "S")
    {
        jogoDeveContinuar = false;
    }
}