using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao4
{
//    4) Dado o valor de faturamento mensal de uma distribuidora, detalhado
//   por estado:
//• SP – R$67.836,43
//• RJ – R$36.678,66
//• MG – R$29.229,88
//• ES – R$27.165,48
//• Outros – R$19.849,53

//Escreva um programa na linguagem que desejar onde calcule o
//percentual de representação que cada estado teve dentro do valor total mensal da distribuidora.
    internal class Program
    {
        static void Main(string[] args)
        {
           
            var faturamento = new Dictionary<string, double>
        {
            { "SP", 67836.43 },
            { "RJ", 36678.66 },
            { "MG", 29229.88 },
            { "ES", 27165.48 },
            { "Outros", 19849.53 }
        };

            
            double totalFaturamento = CalcularTotalFaturamento(faturamento);

            
            foreach (var estado in faturamento)
            {
                double percentual = CalcularPercentual(estado.Value, totalFaturamento);
                Console.WriteLine($"Estado: {estado.Key} - Faturamento: {estado.Value:C} - Percentual: {percentual:F2}%");
            }

            
            Console.ReadKey();
        }

        static double CalcularTotalFaturamento(Dictionary<string, double> faturamento)
        {
            double total = 0;
            foreach (var valor in faturamento.Values)
            {
                total += valor;
            }
            return total;
        }

        static double CalcularPercentual(double valor, double total)
        {
            return (valor / total) * 100;
        }
    
    }
}
