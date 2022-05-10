using Microsoft.AspNetCore.Mvc;

namespace CalculadoraApi.Web.Controllers;

[ApiController]
[Route("[controller]")]
public class CalculadoraController : ControllerBase
{
    [HttpGet("Somar")]
    public IActionResult Soma(double valor1, double valor2)
    {
        var calculadora = new Calculadora();
        if (calculadora.ValidarNumero(valor1) & calculadora.ValidarNumero(valor2))
        {
            return Ok(calculadora.Somar(valor1, valor2));
        }
        return BadRequest("Um ou mais parâmetros são inválidos!");
    }

    [HttpGet("Subtrair")]
    public IActionResult Subtracao(double valor1, double valor2)
    {
        var calculadora = new Calculadora();
        if (calculadora.ValidarNumero(valor1) & calculadora.ValidarNumero(valor2))
        {
            return Ok(new Calculadora().Substrair(valor1, valor2));
        }
        return BadRequest("Um ou mais parâmetros são inválidos!");
    }

    [HttpGet("Dividir")]
    public IActionResult Divisao(double valor1, double valor2)
    {
        var calculadora = new Calculadora();
        if (calculadora.ValidarNumero(valor1) & calculadora.ValidarNumero(valor2) & valor1 > 0 & valor2 > 0)
        {
            return Ok(calculadora.Dividir(valor1, valor2));
        }
        return BadRequest("Um ou mais parâmetros são inválidos!");
    }


    [HttpGet("Multiplicar")]
    public IActionResult Multiplicacao(double valor1, double valor2)
    {
        if (valor1 < 1000 & valor2 < 1000 & valor1 !=0 &valor2 !=0 & valor1 > 0 & valor2 > 0)
        {
            return Ok(new Calculadora().Multiplicar(valor1, valor2));
        }
        return BadRequest("Um ou mais parâmetros são inválidos!");
    }
}
