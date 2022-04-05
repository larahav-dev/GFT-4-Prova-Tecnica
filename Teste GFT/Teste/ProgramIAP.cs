using System;

namespace Teste_GFT
{ 
    /*
    Faça um programa que receba a idade, altura e o peso de 10 pessoas, 
    Calcule e mostre:
        • A quantidade de pessoas com idade superior a 50 anos; X
        • A média das Alturas das pessoas com idade entre 10 e 20 anos X
        • A porcentagem das pessoas com peso inferior a 40 quilos entre todas as pessoas analisadas
    */
    class ProgramP
    {
        static void Main(string[] args)
        {
            double[] Idade = new double [10];
            double Media = 0;
            double Quantidade = 0;
            double percentual = 0 ;
            double[] Peso = new double [10];
            double[] Altura = new double [10];

             // laço de repetição para pedir as variaveis das 10 pessoas
             for (int i = 0; i < Idade.Length; i++)
            {
                //Pedindo ao usuario a idade, altura e peso. 
                System.Console.WriteLine($"Insira as idades da {i+1}º pessoa:  ");
                Idade[i] = Convert.ToDouble(System.Console.ReadLine());

                 System.Console.WriteLine($"Insira as Peso da {i+1}º pessoa:  ");
                Peso[i] = Convert.ToDouble(System.Console.ReadLine());

                 System.Console.WriteLine($"Insira as Altura da {i+1}º pessoa:  ");
                Altura[i] = Convert.ToDouble(System.Console.ReadLine());

                // media da altura, no caso adicionando a variavél media a altura dos pesoas da variavel altura
                Media = Media + Altura[i];

                // mostrando quantas pessoas tem 50 anos
             if (Idade[i]>= 50)
            {
                 Quantidade = Quantidade + 1;
            }

            // porcentual de peso das pessoas com 40kg ou menos - não está pronto          
            if(Peso[i] <= 40)
            {
                //Peso / (Altura * Altura); não faz assim mas por agora é para eu pensar em como.

                // mostrando os individos com com o pesso entre zero e 40 kg e sua porcentagem
                System.Console.WriteLine($"Porcentual de peso, do {i+1}º Individo(s)  {percentual}% para o {Peso}Kg");

            }

            // separando as pessoas entre 10 a 20 ano para media de altura, o calculo para o mesmo
            if((Idade[i]> 10) && (Idade[i] < 20))
            {
                 Media = Media / Idade.Length;      
            }
            
            }
            // mostrando a altura media 
            System.Console.WriteLine($"Media da altura da pessoas entre 10 a 20 anos é {Media}");

            // mostrando a a pessoas maiores de 50 anos
            System.Console.WriteLine($"Existem {Quantidade} que são maiores de idade, ou apartir dos 50 anos");

        }
    }

    }
    