using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using relatorio.Data;

namespace relatorio.Controllers
{
    [ApiController]
    [Route("v1/home")]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        [Route("")]
        public async Task<ActionResult<dynamic>> Get([FromServices] DataContext context)
        {
            var grupos = await context.Grupos.AsNoTracking().ToListAsync();
            var publicadores = await context.Publicadores.AsNoTracking().ToListAsync();

            return Ok(new {
                Grupos = new {
                    Total = grupos.Count
                },
                Publicadores = new {
                    Total = publicadores.Count,
                    Ativos = publicadores.Where(x => x.Ativo == true).Count()
                }
            });
        }
    }
}