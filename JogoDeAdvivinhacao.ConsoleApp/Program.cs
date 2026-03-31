using System.Runtime.Serialization.Formatters;
using System.Security.Cryptography;

///






















bool jogoDeveContinuar = true;

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
            Console.Write("Pressione ENTER para continuar...");
            Console.ReadLine();
            continue;
    }

    int[] numerosDigitados = new int[tentativasMaximas];
    int contadorNumerosDigitados = 0;

    for (int tentativaAtual = 1; tentativaAtual <= tentativasMaximas; tentativaAtual++)
    {
        Console.Clear();
        Console.WriteLine("-----------------------------------");
        Console.WriteLine("Jogo de Adivinhação");
        Console.WriteLine("-----------------------------------");
        Console.WriteLine($"Tentativa {tentativaAtual} de {tentativasMaximas}");
        Console.WriteLine("------------------------------------");

        Console.Write("Digite um número: ");
        int numeroDigitado = Convert.ToInt32(Console.ReadLine());

        bool numeroEstaRepetido = false;

        for (int indiceAtual = 0; indiceAtual < numerosDigitados.Length; indiceAtual++)
        {
            if (numerosDigitados[indiceAtual] == numeroDigitado)
            {
                numeroEstaRepetido = true;
                break;
            }
        }

        if (numeroEstaRepetido == true)
        {
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Voce já digitou este numero, tente novamente.");
            Console.WriteLine("-----------------------------------------");

            Console.Write("Pressione ENTER para continuar....");
            Console.ReadLine();

            tentativaAtual--;
            continue;
        }

        numerosDigitados[contadorNumerosDigitados] = numeroDigitado;
        contadorNumerosDigitados++;

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
        Console.Write("Pressione ENTER para continuar...");
        Console.ReadLine();
    }

    Console.Write("Deseja Continuar: (S/N): ");
    string opcaoContinuar = Console.ReadLine()!.ToUpper();

    if (opcaoContinuar != "S")
    {
        jogoDeveContinuar = false;
    }
}
