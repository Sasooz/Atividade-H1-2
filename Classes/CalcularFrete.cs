using System.Reflection.Metadata.Ecma335;

namespace Atividade_H1_2.Classes;

public class CalcularFrete: Frete
{
    public string GetNomeProduto()
    {
        return NomeProduto;
    }

    public double CalculoFrete(Frete frete, string nomeProduto)
    {
        int TaxaEstado;
        if (frete.UF == "SP")
        {
            TaxaEstado = 50;
        }
        else if (frete.UF == "RJ")
        {
            TaxaEstado = 60;
        }
        else if (frete.UF == "MG")
        {
            TaxaEstado = 55;
        }
        else TaxaEstado = 70;

        var VolumeProduto = frete.AlturaProduto * frete.LarguraProduto * frete.ComprimentoProduto;
        frete.ValorFrete = VolumeProduto * 0.02 + TaxaEstado;


       return frete.ValorFrete;

    }
    
}

