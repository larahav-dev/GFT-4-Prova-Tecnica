using System;

namespace Teste_GFT
{
    /*
    Faça um programa que receba duas letras, e diga quantas letras há entre elas. As letras passadasdevem estar em ordem alfabética. Se não estiverem o programa deve avisar o usuário. Exemplo: 'a', 'b' = 0 | 'a', 'c' = 1 | 'a', 'z' = 24 | 'w', 'e' = Não está na ordem alfabética

    */
    class Alfabet
    {
        static void Main(string[] args)
        {
            // variavél 
            string[] ABC = {"a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"};

            //pedindo a primeira letra
            System.Console.WriteLine("Digite a primeira letra: ");
            string L1 = Console.ReadLine();

            // pedindo a segunda letra
            System.Console.WriteLine("Digite a segunda letra: ");
            string L2 = Console.ReadLine();

            int Pl1 = 0, Pl2 = 0, Diferenca;

            //laço de repetição
            for (int i = 0; i < ABC.Length; i++)
            {
                if (ABC[i].Contains(L1))
                {
                    Pl1 = i;          
                }
            }

            for (int i = 0; i < ABC.Length; i++)
            {
                if (ABC[i].Contains(L2))
                {
                    Pl2 = i;          
                }
            }

            Diferenca = (Pl2 - Pl1) -1;
            
            if (Diferenca >= 0)
            {
                System.Console.WriteLine($"{L1} esta {Diferenca} posições de {L2}");    
            }

            else
            {
                System.Console.WriteLine($"Não esta em ordem alfabética");
            } 
        }
    }
}