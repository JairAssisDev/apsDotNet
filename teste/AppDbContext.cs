namespace teste;

using Microsoft.EntityFrameworkCore;
using teste.Model;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<Produto> Produtos { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Produto>().HasKey(p => p.Id);
        modelBuilder.Entity<Produto>().Property(p => p.Nome).IsRequired().HasMaxLength(100);
        modelBuilder.Entity<Produto>().Property(p => p.Preco).HasPrecision(10, 2);
    }
}
