using System;

namespace Atividade_DS
{
    public static class media_do_aluno
    {
        public static void Executar()
        {

 System.Console.WriteLine("\n========================================================\n");

            Console.WriteLine("Digite a 1° nota: "); //pedindo nota ao usuario
            int nt1 = int.Parse(Console.ReadLine()); //adiciona o valor da nota a variavel

            Console.WriteLine("Digite a 2° nota: "); //pedindo nota ao usuario
            int nt2 = int.Parse(Console.ReadLine()); //adiciona o valor da nota a variavel

            Console.WriteLine("Digite a 3° nota: "); //pedindo nota ao usuario
            int nt3 = int.Parse(Console.ReadLine()); //adiciona o valor da nota a variavel

            double media = (nt1 + nt2 + nt3) / 3.0; // calculando media

            if(media >= 5) // se resultado maior ou igual a 5
            {
                Console.Write($"Sua média é: {media}, você foi aprovado!!"); // é exibito que o aluno passo foi aprovado + a sua media
            }
            else if(media < 5) // se resutado menor que 5
            {
                Console.Write($"Sua média é: {media}, você reprovou :( "); // é exibido a nota do usuario e que ele reprovou
            }
            else
            {
                Console.Write("Insira um valor válido"); // caso o usuario insira algum valor invalido
            }
        }
    }
}