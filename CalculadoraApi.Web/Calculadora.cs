using CalculadoraApi.Web.Exceptions;

namespace CalculadoraApi.Web
{
    public class Calculadora
    {
        public double Somar(double num1, double num2){
            if(ValidarNumero(num1) && ValidarNumero(num2))
            {
                return num1 + num2;
            }
            throw new InputIncorreta("Numero(s) inválidos(s), por favor digite novamente...");
        }
         public double Subtrair(double num1, double num2)
         {
            if(ValidarNumero(num1) && ValidarNumero(num2))
            {
                return num1 - num2;
            }
            throw new InputIncorreta("Numero(s) inválidos(s), por favor digite novamente...");
        }
         public double Dividir(double num1, double num2){
            if(ValidarNumero(num1) && ValidarNumero(num2) && ValidarNumeroNegativo(num1) && ValidarNumeroNegativo(num2))
            {
                return num1 / num2;
            }
            throw new InputIncorreta("Numero(s) inválidos(s), por favor digite novamente...");
        }
         public double Multiplicar(double num1, double num2)
        {
            if(ValidarNumero(num1) && ValidarNumero(num2) && ValidarNumeroNegativo(num1) && ValidarNumeroNegativo(num2))
            {
                return num1 * num2;
            }
            throw new InputIncorreta("Numero(s) inválidos(s), por favor digite novamente...");
        }
        public bool ValidarNumero(double valor)
        {
            if (valor != 0 & valor < 1000)
                return true;
            return false;
        }
        
         public bool ValidarNumeroNegativo(double valor)
        {
            if (valor > 0)
                return true;
            return false;
        }
    }
}