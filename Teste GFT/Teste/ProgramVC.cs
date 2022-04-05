using System;

namespace Teste_GFT
{ 
    /*
        Faça um programa que verifique (usando if e else) se uma letra digitada é 
        vogal ou consoante. Cuidados com as letras maiúsculas.
    */
   class ProgramVC
    {
        static void Main(string[] args)
        {
            string x ;

            System.Console.WriteLine("Compararando de Se é Vogal ou Consoante ");
            System.Console.WriteLine("----------------------");

            // pedidindo ao usuario colocar um letra
            System.Console.WriteLine("Insirar Uma letra");
            x = Convert.ToString(System.Console.ReadLine());

            // indicando se não for nenhuma das vogais sera consoantes
            if ((x == "a")||(x == "e")||(x == "i")||(x == "o")||(x == "u"))
            {
            System.Console.WriteLine($"A letra apresentada é vogal : {x}");
            }
            else
            {
                System.Console.WriteLine($"A letra apresentada é Consoante : {x}");
            }
        }
    }
}