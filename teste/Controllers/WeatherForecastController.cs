using Microsoft.AspNetCore.Mvc;

namespace teste.Controllers
{
    [ApiController]
    [Route("jair")]
    public class WeatherForecastController : ControllerBase
    {
   

        [HttpGet("{x}/{y}")] 
        public int Teste(int x, int y)
        {
            return x+y;
        }

    }
}
