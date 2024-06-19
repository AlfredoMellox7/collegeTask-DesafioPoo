public class Autor
{
    public string Nome;
    public string Nacionalidade;

    public Autor(string nome, string nacionalidade)
    {
        Nome = nome;
        Nacionalidade = nacionalidade;
    }
    public void MostrarInfo()
    {
        Console.WriteLine($"Nome do autor : {Nome}, e sua nacionalidade é {Nacionalidade}.");
    }
}