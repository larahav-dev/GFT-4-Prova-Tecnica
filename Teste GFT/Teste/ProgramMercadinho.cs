using System;

namespace Teste_GFT
{
    /*
    Os caixas do mercadinho do Ubiratan tem uma grande responsabilidade em suas mãos. A maior parte do tempo de seu expediente de trabalho é gasto recebendo valores de clientes e, em alguns casos, fornecendo troco.
        Seu desafio é fazer um programa que leia o valor total a ser pago e o valor efetivamente pago, informando o menor número de cédulas e moedas que devem ser fornecidas como troco.
        Deve-se considerar que há:
            • cédulas de R$100,00, R$50,00, R$10,00, R$5,00 e R$1,00;
            • moedas de R$0,50, R$0,10, R$0,05 e R$0,01.
    */

    class Program
    {
        static void Main(string[] args)
        {
            int[] Notas = {100, 50, 20, 10, 5, 2, 1};
            int[] Moedas = { 50, 10, 5, 1};
            Double ValorRecebido;
            Double ValorASerPago;
            Double Troco;

            // pedindo ao usuario que insira o valor a ser pago
            System.Console.WriteLine("Por favor digite o valor a ser pago: ");
            ValorASerPago = Convert.ToDouble(Console.ReadLine());

            // pedindo ao usuario que insira o valor a que precisa receber
            System.Console.WriteLine("Agora digite o valor recebido: ");
            ValorRecebido = Convert.ToDouble(Console.ReadLine());

            // calculo para Indicar o Troco
            Troco = ValorRecebido - ValorASerPago;
            int TrocoNotas = (int)Troco;

            // aqui
            if (Troco >= 0)
            {
                System.Console.WriteLine();
                System.Console.WriteLine("TROCO: ");
                
                //A Notas que tem quer ser entregue
                for (int i = 0; i < Notas.Length; i++)
                {
                    System.Console.WriteLine($"{TrocoNotas/Notas[i]} nota(s) de R$ {Notas[i]}");
                    TrocoNotas = TrocoNotas % Notas[i];
                    Troco = Troco % Notas[i];
                }

                Troco = Troco * 100;

                //A moedas que tem quer ser entregue
                for (int i = 0; i < Moedas.Length; i++)
                {
                    System.Console.WriteLine($"{Troco/Moedas[i]} moedas(s) de R$ {Moedas[i]}");
                    Troco = Troco % Moedas[i];
                }

            }
            // o Quanto falta de troco
            else
            {
                System.Console.WriteLine($"Ainda faltam R$ {Troco*-1} para realizar a compra.");
            }
        }
    }
}