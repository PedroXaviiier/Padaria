
/* A padaria Hotpão vende uma certa quantidade de pães franceses e uma
quantidade de broas a cada dia. Cada pãozinho custa R$ 0,12 e a broa custa R$
1,50. Ao final do dia, o dono quer saber quanto arrecadou com a venda dos pães
e broas (juntos), e quanto deve guardar numa conta depoupança (10% do total
arrecadado). Você foi contratado para fazer os cálculos para o dono. Com base
nestes fatos, faça um algoritmo para ler as quantidades de pães e de broas, e
depois calcular os dados solicitados. 
*/

using System;

namespace Padaria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a quantidade broas vendidas");
            double broas = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a quantidade pão d' agua vendidas");
            double pao = Convert.ToDouble(Console.ReadLine());

            double vendas_pao = pao * 0.12;
            double vendas_broa = broas * 1.50;
            double total = vendas_broa + vendas_pao;
            double poupança = total * 0.10;
            Console.WriteLine($"o valor total de vendas foi:{total} ");
            Console.WriteLine($"o valor para poupança é:{poupança} ");


        }
    }
}
