using System;

namespace Exercício___escrever_dados_na_ordem_inversa
{
//     Faça um algoritmo para ler 15 números e armazenar em um vetor. Após a leitura total dos
// 15 números, o algoritmo deve escrever esses 15 números lidos na ordem inversa da qual foi
// declarado.
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite 15 números, após a digitação será mostrado na ordem inversa!");
            int[] numero = new int[15];
            for (var i = 0; i < 15; i++)
            {
                Console.WriteLine($"Digite o {i+1}º número:");
                numero[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Será mostrado na ordem inversa a digitada!");
            for (var i = 0; i < 15; i++)
            {
                Console.WriteLine($"{numero[(14-i)]}");
            }
        }
    }
}
