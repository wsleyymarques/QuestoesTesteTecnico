using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

class Questao3
{
    static void Main()
    {
        //Optei por utilizar xml como fonte dos dados do faturamento mensal

        string caminhoArquivo = "faturamento.xml";
        var faturamento = LerFaturamentoDoArquivo(caminhoArquivo);

        
        var diasComFaturamento = faturamento.Where(registro => registro.Valor > 0).Select(registro => registro.Valor).ToList();

        if (diasComFaturamento.Count == 0)
        {
            Console.WriteLine("Nenhum dia com faturamento disponível para cálculo.");
            return;
        }

        double menorFaturamento = CalcularMenorValor(diasComFaturamento);
        double maiorFaturamento = CalcularMaiorValor(diasComFaturamento);
        double mediaMensal = CalcularMediaMensal(diasComFaturamento);
        int diasAcimaMedia = ContarDiasAcimaDaMedia(diasComFaturamento, mediaMensal);

        
        Console.WriteLine($"Menor valor de faturamento: {menorFaturamento:C}");
        Console.WriteLine($"Maior valor de faturamento: {maiorFaturamento:C}");
        Console.WriteLine($"Número de dias acima da média: {diasAcimaMedia}");

        Console.ReadKey();
    }

    static List<RegistroFaturamento> LerFaturamentoDoArquivo(string caminho)
    {
        XDocument xmlDoc = XDocument.Load(caminho);
        return xmlDoc.Descendants("dia")
                     .Select(dia => new RegistroFaturamento
                     {
                         Dia = dia.Attribute("data").Value,
                         Valor = double.Parse(dia.Attribute("valor").Value)
                     })
                     .ToList();
    }

    static double CalcularMenorValor(List<double> faturamento)
    {
        return faturamento.Min();
    }

    static double CalcularMaiorValor(List<double> faturamento)
    {
        return faturamento.Max();
    }

    static double CalcularMediaMensal(List<double> faturamento)
    {
        return faturamento.Average();
    }

    static int ContarDiasAcimaDaMedia(List<double> faturamento, double media)
    {
        return faturamento.Count(valor => valor > media);
    }
}

class RegistroFaturamento
{
    public string Dia { get; set; }
    public double Valor { get; set; }
}
