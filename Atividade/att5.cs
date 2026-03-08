using System;

namespace Atividade_DS
{
    public static class Contagem_regressiva
    {
        public static void Executar()
        {
            System.Console.WriteLine("\n========================================================\n");


            Console.WriteLine("Digite o valor da contagem regressiva: \n"); // pede o valor ao usuario
            int val_cont = int.Parse(Console.ReadLine()); // adiciona o valor a uma variavel

            Console.WriteLine("Contagem regressiva: \n");

            for (int i = val_cont; i >= 0; i--) // estrutura de repetição
            {
                Console.WriteLine(i);
            }
        }
    }
}