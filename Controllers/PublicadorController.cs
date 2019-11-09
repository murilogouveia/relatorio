using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using relatorio.Data;
using relatorio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace relatorio.Controllers
{
    [ApiController]
    [Route("v1/publicadores")]
    public class PublicadorController : ControllerBase
    {

        // Index - Lista todos os publicadores
        [HttpGet]
        [Route("")]
        public async Task<ActionResult<List<Publicador>>> Get([FromServices] DataContext context)
        {
            var publicadores = await context.Publicadores
                .Include(x => x.Grupo).AsNoTracking().ToListAsync();
            return Ok(publicadores);
        }

        // Lista publicadores por id
        [HttpGet]
        [Route("{id:int}")]
        public async Task<ActionResult<Publicador>> FindById([FromServices] DataContext context, int id)
        {
            var publicador = await context.Publicadores.Where(x => x.Id == id).Include(x => x.Grupo).SingleOrDefaultAsync();
            return Ok(publicador);
        }

        [HttpGet]
        [Route("grupo/{id:int}")]
        public async Task<ActionResult<List<Publicador>>> ListByGroup([FromServices] DataContext context, int id)
        {
            var publicadores = await context.Publicadores.Include(x => x.Grupo)
                    .Where(x => x.Grupo.NumeroGrupo == id).ToListAsync();
            return Ok(publicadores);
        }

        [HttpPost]
        [Route("")]
        public async Task<ActionResult<Publicador>> Post([FromServices] DataContext context, 
            [FromBody] Publicador model)
        {
            if(ModelState.IsValid)
            {
                context.Publicadores.Add(model);
                await context.SaveChangesAsync();
                return Ok(model);
            }
            else
            {
                return BadRequest(ModelState);
            }
        }
    }
}
