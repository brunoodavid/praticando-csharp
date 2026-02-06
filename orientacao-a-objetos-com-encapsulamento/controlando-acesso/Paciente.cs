public class Paciente
{
    public string Nome { get; set; }
    public int idade { get; set; }

    public Paciente(string nome, int idade)
    {
        this.Nome = nome;
        this.idade = idade;
    }
}