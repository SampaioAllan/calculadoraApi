namespace CalculadoraApi.Web
{
    public class Calculadora
    {
        public double Somar(double num1, double num2){
            return num1 + num2;
        }
         public double Substrair(double num1, double num2){
            return num1 - num2;
        }
         public double Dividir(double num1, double num2){
            return num1 / num2;
        }
         public double Multiplicar(double num1, double num2){
            return num1 * num2;
        }
        public bool ValidarNumero(double valor)
        {
            if (valor != 0 & valor < 1000)
                return true;
            return false;
        }
    }
}