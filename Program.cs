using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite: \n 1- Conversão de temperatura; \n 2- Calcular área do retangulo; \n 3- Média de alunos; \n 4- Desconto de produtos; \n 5- Contagem egressiva.");
        int opcao = int.Parse(Console.ReadLine());

        switch (opcao)
        {
            case 1:
                Atividade_DS.conv_temperatura.Executar(); // Chama o método
                break;

            case 2:
                Atividade_DS.area_do_retangulo.Executar(); // Chama o método
                break;
            
            case 3:
                Atividade_DS.media_do_aluno.Executar(); // Chama o método
                break;
            
            case 4:
                Atividade_DS.Desconto_do_produto.Executar(); // Chama o método
                break;
            
            case 5:
                Atividade_DS.Contagem_regressiva.Executar(); // Chama o método
                break;
            
            default:
                Console.WriteLine("Opção inválida!");
                break;
        }
    }
}