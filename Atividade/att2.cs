using System;

namespace Atividade_DS
{
    public static class area_do_retangulo
    {
       public static void Executar()
        {

 System.Console.WriteLine("\n========================================================\n");

        Console.WriteLine("escreva o valor da base do Retangulo:"); // pede o valor da base ao usuario
        int bas = int.Parse(Console.ReadLine()); // adiciona o valor da base a uma variavel

        Console.WriteLine("Escreva a altura do Retangulo: "); // pede a altura ao usuario
        int alt = int.Parse(Console.ReadLine()); //a diciona o valor da altura a variavel

        int area = (bas * alt); // calcula a area do retangulo

        Console.Write($"A area do Retangulo é de: {area}"); // exibe a area do retangulo no console

        }
    }
}
