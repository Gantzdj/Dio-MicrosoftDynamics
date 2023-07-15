namespace MicrosoftDynamics_Dio.Models

public class Pessoa
{
    public Pessoa() { }
    public Pessoa(string nome)
    {
        Nome = nome;
    }

    public Pessoa(string nome, string sobrenome)
    {
        Nome = nome;
        Sobrenome = sobrenome;
    } 
    public Pessoa(string nome, string sobrenome) 
    {
            Nome = nome;
            Sobrenome = Sobrenome;
    }
    public string Nome { get; set;}
    public string Sobrenome { get;set;}
    public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();
}