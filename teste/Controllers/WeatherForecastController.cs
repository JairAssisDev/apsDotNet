using Microsoft.AspNetCore.Mvc;
using teste.Model;

namespace teste.Controllers
{
    [ApiController]
    [Route("jair")]
    public class WeatherForecastController : ControllerBase
    {
        AppDbContext _db;
        public WeatherForecastController(AppDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        public List<Produto> Get()
        {
            return this._db.Produtos.ToList();

        }

        [HttpGet("{id}")]
        public Produto? Get(int id)
        {
            return this._db.Produtos.FirstOrDefault(x => x.Id == id);
        }

        [HttpPost]
        public Produto Post(Produto produto)
        {
            _db.Produtos.Add(produto);
            _db.SaveChanges();

            return produto;
        }


        [HttpGet("{x}/{y}")] 
        public int Teste(int x, int y)
        {
            return x+y;
        }

    }
}
