using System.Reflection.Metadata.Ecma335;

namespace Atividade_H1_2.Classes;

public class CalcularFrete
{
    public Frete CalculoFrete(Produto produto, string UF)
    {
        int TaxaEstado = VerificaTaxaEstado(UF);

        double VolumeProduto = produto.Altura * produto.Largura * produto.Comprimento;

        double ValorFrete = VolumeProduto * 0.02 + TaxaEstado;

        return new Frete
        {
            UF = UF,
            ValorFrete = Math.Round(ValorFrete, 2),
        };

    }


    public int VerificaTaxaEstado(string UF )
    {
        if (UF == "SP")
        {
            return  50;
        }
        else if (UF == "RJ")
        {
            return  60;
        }
        else if (UF == "MG")
        {
            return 55;
        }
        else return 70;
    }
    
}

