using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adivinhas
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int aleatorio = rand.Next(10) + 1;
            int num, tentativa = 0;

            do
            {
                Console.Write("Digite um número: ");
                num = int.Parse(Console.ReadLine());

                if (num == aleatorio)
                {
                    Console.WriteLine("Você acertou em {0} tentativas!",tentativa);
                }else
                {
                    tentativa++;
                    if (aleatorio > num)
                    {
                        Console.WriteLine("Você errou! O número sorteado é maior que ao lido.Tente novamente!");
                    }else
                    {
                        Console.WriteLine("Você errou! O número sorteado é menor que ao lido.Tente novamente!");
                    }
                }

            } while (num != aleatorio);
        }
    }
}
/*Escreva um algoritmo que sorteia um número entre 1 e 10 (inclusos) e depois pede para o usuário tentar 
 * adivinhá-lo. Caso o número lido seja igual ao sorteado, mostre a mensagem 
 * “Você acertou em Tentativas tentativas!”. Caso contrário, mostre a mensagem “Você errou! 
 * O número é Dica. Tente novamente!” e permita uma nova chance, mostrando uma dica se o número sorteado é maior 
 * ou menor ao lido.*/
