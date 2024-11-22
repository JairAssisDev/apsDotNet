using teste.Model;

public interface IDatabaseService
{
    Produto CreateProduto(Produto produto);
    string DeleteProduto(int id);
    List<Produto> GetAllProdutos();
    Produto? GetProdutoById(int id);
    Produto? UpdateProduto(Produto produto);
}