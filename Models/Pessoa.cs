namespace DesafioProjetoHospedagem.Models;

public class Pessoa
{
    public Pessoa() { }

    public Pessoa(string Samara)
    {
        Nome = Samara;
    }

    public Pessoa(string Samara, string Silva)
    {
        Nome = Samara;
        Sobrenome = Silva;
    }

    public string Nome { get; set; }
    public string Sobrenome { get; set; }
    public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();
}