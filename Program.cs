public class Principal{
    public static void Main(String[] args){
        Autor autor = new Autor("Chuck Palahniuk", "Colombia");
        Livro livro = new Livro("Clube da Luta", autor, 19.90);
        livro.MostrarInfo();
        livro.AplicarDesconto(10);
        livro.MostrarInfo();
        livro.AplicarDesconto(5.0);
        livro.MostrarInfo();
    }
}