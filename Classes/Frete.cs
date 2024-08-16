using System.Diagnostics.Eventing.Reader;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

namespace Atividade_H1_2.Classes;

public class Frete
{
    public string NomeProduto { get; set; }
    public float PesoProduto { get; set; }
    public float AlturaProduto { get; set; }
    public float LarguraProduto { get; set; }
    public float ComprimentoProduto { get; set; }
    public string UF { get; set; }
    public double ValorFrete { get; set; }
}

 