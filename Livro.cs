public class Livro
{
    public string Titulo;
    public Autor Autor;
    public double Preco;

    public Livro(string titulo, Autor autor, double preco)
    {
        Titulo = titulo;
        Autor = autor;
        Preco = 19.90;
    }

    public void MostrarInfo()
    {
        Console.WriteLine($"O título do livro é {Titulo}, sendo seu autor {Autor.Nome}, e sua nacionalidade {Autor.Nacionalidade} e o preço do livro é de {Preco:C}.");
    }
    public void AplicarDesconto(double porcentagem)
    {
        Preco -= Preco * (porcentagem / 100);
    }

    public void AplicarDesconto(int valorFixo)
    {
        Preco -= valorFixo;
    }
}