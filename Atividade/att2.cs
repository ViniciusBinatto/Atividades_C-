using System;

namespace Atividade_DS
{
    public static class area_do_triangulo
    {
       public static void Executar()
        {

 System.Console.WriteLine("\n========================================================\n");

        Console.WriteLine("escreva o valor da base do triângulo:"); // pede o valor da base ao usuario
        int bas = int.Parse(Console.ReadLine()); // adiciona o valor da base a uma variavel

        Console.WriteLine("Escreva a altura do triângulo: "); // pede a altura ao usuario
        int alt = int.Parse(Console.ReadLine()); //a diciona o valor da altura a variavel

        int area = (bas * alt) /2; // calcula a area do triângulo

        Console.Write($"A area do triângulo é de: {area}"); // exibe a area do triangulo no console

        }
    }
}
