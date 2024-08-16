using Atividade_H1_2.Classes;
using Microsoft.AspNetCore.Mvc;

namespace Atividade_H1_2.Controllers;

[ApiController]
[Route("frete")]
public class FreteController : ControllerBase
{
  
    [HttpPost]
    public IActionResult CalcularFreteTodo(CalculoFrete frete)
    {
        CalcularFrete _calcularFrete = new CalcularFrete();
        var resultado = _calcularFrete.CalculoFrete(frete);

        return Ok(resultado);
    }
}
