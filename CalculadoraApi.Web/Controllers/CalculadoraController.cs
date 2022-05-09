using Microsoft.AspNetCore.Mvc;

namespace CalculadoraApi.Web.Controllers;

[ApiController]
[Route("[controller]")]


public class CalculadoraController : ControllerBase
{

    [HttpGet("Somar")]
    public IActionResult Soma(double valor1, double valor2)
    {
        if (ValidacaoNumero(valor1) & ValidacaoNumero(valor2))
        {
            return Ok(valor1 + valor2);
        }
        return BadRequest("Um ou mais parâmetros são inválidos!");
    }

    [HttpGet("Subtrair")]
    public IActionResult Subtracao(double valor1, double valor2)
    {
        if (ValidacaoNumero(valor1) & ValidacaoNumero(valor2))
        {
            return Ok(valor1 - valor2);
        }
        return BadRequest("Um ou mais parâmetros são inválidos!");
    }

    [HttpGet("Dividir")]
    public IActionResult Divisao(double valor1, double valor2)
    {
        if (ValidacaoNumero(valor1) & ValidacaoNumero(valor2) & valor1 > 0 & valor2 > 0)
        {
            return Ok(valor1 / valor2);
        }
        return BadRequest("Um ou mais parâmetros são inválidos!");
    }


    [HttpGet("Multiplicar")]
    public IActionResult Multiplicacao(double valor1, double valor2)
    {
        if (valor1 < 1000 & valor2 < 1000 & valor1 !=0 &valor2 !=0 & valor1 > 0 & valor2 > 0)
        {
            return Ok(valor1 * valor2);
        }
        return BadRequest("Um ou mais parâmetros são inválidos!");
    }

    private bool ValidacaoNumero(double valor)
    {
        if (valor != 0 & valor < 1000)
            return true;
        return false;
    }


}
