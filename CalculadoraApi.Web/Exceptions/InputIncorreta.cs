namespace CalculadoraApi.Web.Exceptions
{
    public class InputIncorreta : Exception
    {
        public InputIncorreta()
        {

        }
        public InputIncorreta(string msg) : base (msg)
        {
            
        }
        
    }
}