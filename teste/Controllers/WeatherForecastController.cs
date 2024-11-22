using Microsoft.AspNetCore.Mvc;
using teste.Model;

namespace teste.Controllers
{
    [ApiController]
    [Route("jair")]
    public class WeatherForecastController : ControllerBase
    {
        IDatabaseService _dbService;

        public WeatherForecastController(IDatabaseService dbService)
        {

            _dbService = dbService;
        }

        [HttpGet]
        public List<Produto> Get()
        {
            return this._dbService.GetAllProdutos();
        }

        [HttpGet("{id}")]
        public Produto? Get(int id)
        {
            return this._dbService.GetProdutoById(id);
        }

        [HttpPost]
        public Produto Post(Produto produto)
        {
            return this._dbService.CreateProduto(produto);
        }


        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return this._dbService.DeleteProduto(id);
        }

        [HttpPut()]
        public Produto? AtualizarProduto(Produto produto)
        {
            return _dbService.UpdateProduto(produto);
        }
    }
}
