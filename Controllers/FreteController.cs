using Atividade_H1_2.Classes;
using Microsoft.AspNetCore.Mvc;

namespace Atividade_H1_2.Controllers;

[ApiController]
[Route("frete")]
public class FreteController : ControllerBase
{
  
    [HttpPost]
    public IActionResult CalcularFreteTodo(Frete frete)
    {
        CalcularFrete _calcularFrete = new CalcularFrete();
        var resultado = _calcularFrete.CalculoFrete(frete, _calcularFrete.GetNomeProduto());

        var Frete = new Frete
        {
            NomeProduto = frete.NomeProduto,
            PesoProduto = frete.PesoProduto,
            UF = frete.UF,
            AlturaProduto = frete.AlturaProduto,
            LarguraProduto = frete.LarguraProduto,
            ComprimentoProduto = frete.ComprimentoProduto,
            ValorFrete = frete.ValorFrete,
            
        };


        return Ok(Frete);
    }
}
