using System;

namespace Atividade_DS
{
    public static class Desconto_do_produto
    {
            public static void Executar()
            {

 System.Console.WriteLine("\n========================================================\n");

                Console.WriteLine("Digite o valor original do produto: "); // pede o valor ao usuario
                int val_origin = int.Parse(Console.ReadLine()); //adiciona o valor a variavel

                Console.WriteLine("Digite a porcentagem (%), do desconto: "); // pede o valor do desconto ao usuario
                int desconto = int.Parse(Console.ReadLine()); // adiciona o desconto a variavel

                int val_descon = (val_origin * desconto) / 100; // calcula o valor do desconto
                int val_final = val_origin - val_descon; // calcula o valor final do produto

                System.Console.WriteLine($"O valor final do produto é de: {val_final}"); // exibe a msg com o valor final do produto, após o desconto aplicado
            }
        }
    }
