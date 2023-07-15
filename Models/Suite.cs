namespace MicrosoftDynamics_Dio.Models
{
    public class Suite
    {
        public Suite() {}

        public Suite(string tipoSuite, int capacidade, decimal ValorDiaria)
        {
            TipoSuite = tipoSuite;
            Capacidade = capacidade;
            ValorDiaria = valorDiaria;
        }
        public string TipoSuite { get; set;}    
        public int Capacidade { get;set;}
        public decimal ValorDiaria { get;set; }

    }
}