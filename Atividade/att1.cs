using System;

namespace Atividade_DS
{
    public static class conv_temperatura
    {
        public static void Executar()
        {

 System.Console.WriteLine("\n========================================================\n");

            Console.WriteLine("Escolha uma opção: \n1 - Converter °C para °F \n2 - Converter °F para °C \n"); // pedindo valor ao usuario
            int opcao = int.Parse(Console.ReadLine()); // aicionando o valor do usuario a variavel e o trnsformando em numero

            // no switch case, declaramos fora dos casos
            double c, f; // declaração de variavel

            switch (opcao)
            {
                case 1: // se usuario digitar 1
                    Console.WriteLine("Digite a temperatura em °C"); // pedindo valor ao usuario
                    c = double.Parse(Console.ReadLine()); // aicionando valor a variavel + ransformando string em numero
                    f = (c * 9 / 5) + 32; // calculando o resultado em °F
                    Console.WriteLine($"{c}°C é igual a {f}°F"); //exibindo o resultado no console
                    break; // quebra, para sistema parar de exibir

                case 2: // se usuario digitar 2
                    Console.WriteLine("Digite a temperatura em °F"); // pedindo valor ao usuario
                    f = double.Parse(Console.ReadLine()); // aicionando valor a variavel + ransformando string em numero
                    c = (f - 32) * 5 / 9;  // calculando o resultado em °C
                    Console.WriteLine($"{f}°F é igual a {c}°C"); // exibindo resultado no console
                    break;

                default: // caso outro valor seja inserido pelo usuario diferente de 1 ou 2, como letras, ou 3,4,5,etc
                    Console.WriteLine("\nOpção inválida");
                    break;
            }
        }
    }
}
