using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using teste;
using teste.Model;

public class DatabaseService : IDatabaseService
{
    AppDbContext _db;

    public DatabaseService(AppDbContext db)
    {
        _db = db;
    }

    public List<Produto> GetAllProdutos()
    {
        return this._db.Produtos.ToList();
    }

    public Produto? GetProdutoById(int id)
    {
        return this._db.Produtos.FirstOrDefault(x => x.Id == id);

    }

    public Produto CreateProduto(Produto produto)
    {
        _db.Produtos.Add(produto);
        _db.SaveChanges();

        return produto;
    }

    public string DeleteProduto(int id)
    {

        Produto? produto = _db.Produtos.FirstOrDefault(x => x.Id == id);
        if (produto != null)
        {
            this._db.Produtos.Remove(produto);
            this._db.SaveChanges();
            return "Produto excluido com sucesso";
        }
        return "Produto não encontrado";

    }

    public Produto? UpdateProduto( Produto produto)
    {
     Produto? produtoEncontrado = this._db.Produtos.FirstOrDefault(x => x.Id == produto.Id);

        if (produtoEncontrado != null)
        {
            produtoEncontrado.Nome = produto.Nome;
            produtoEncontrado.Preco = produto.Preco;
            produtoEncontrado.Estoque = produto.Estoque;

            this._db.SaveChanges();

            return this.GetProdutoById(produto.Id); 

        }

        return null;
    
    }

}