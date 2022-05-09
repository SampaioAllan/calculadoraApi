using Microsoft.AspNetCore.Mvc;

namespace CalculadoraApi.Web.Controllers;

[ApiController]
[Route("[controller]")]


public class CalculadoraController : ControllerBase
{

    [HttpGet("CalculadoraAPI")]
    public double Soma(double valor1, double valor2)
    {
        return valor1 + valor2;
    }


}
