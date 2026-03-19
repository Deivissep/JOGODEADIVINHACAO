/*
v1
Iremos fazer um jogo onde o usuário terá chances de acertar um número aleatório decidido pelo sistema.
Input (Entrada de Dados)O usuário digita número inteiro
Processamento
O sistema compara o número digitado com um número inteiro aleatório
Output (Saída de Dados)
O sistema informará o usuário se o mesmo acertou ou não, podendo incluir dicas sobre a proximidade do "chute"
*/



// 2 Nosso jogo deve gerar numeros secretos aleatórios
using System.Security.Cryptography;

Console.WriteLine("-----------------------------------");
Console.WriteLine("Jogo de Adivinhação");
Console.WriteLine("-----------------------------------");

Console.WriteLine();
Console.Write("Digite um numero: ");
string strNumeroDigitado = Console.ReadLine();

int numeroAleatorio = RandomNumberGenerator.GetInt32(1, 21);

Console.WriteLine("O número digitado foi: " + numeroAleatorio);

Console.ReadLine();