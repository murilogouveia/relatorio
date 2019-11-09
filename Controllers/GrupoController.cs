using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using relatorio.Data;
using relatorio.Models;

namespace relatorio.Controllers
{
    [ApiController]
    [Route("v1/grupos")]
    public class GrupoController : ControllerBase
    {
        [HttpGet]
        [Route("")]
        public async Task<ActionResult<List<Grupo>>> Get([FromServices] DataContext context)
        {
            var grupos = await context.Grupos.ToListAsync();
            return Ok(grupos);
        }

        [HttpGet]
        [Route("{id:int}")]
        public async Task<ActionResult<Grupo>> FindByNumber([FromServices] DataContext context, int id)
        {
            var grupo = await context.Grupos.Where(x => x.NumeroGrupo == id)
                    .AsNoTracking().SingleOrDefaultAsync();
            return Ok(grupo);
        }

        [HttpPost]
        [Route("")]
        public async Task<ActionResult<Grupo>> Post([FromServices] DataContext context, [FromBody] Grupo model)
        {
            if(ModelState.IsValid)
            {
                context.Grupos.Add(model);
                await context.SaveChangesAsync();
                return Ok(model);
            }
            else 
            {
                return NotFound(new {
                    Mensagem = "Não foi possivel executar",
                    Erro = true
                });
                //return BadRequest(ModelState);
            }
        }

        [HttpPut]
        [Route("")]
        public async Task<ActionResult<Grupo>> Update([FromServices] DataContext context, 
            [FromBody] Grupo model)
        {
            context.Entry<Grupo>(model).State = EntityState.Modified;
            await context.SaveChangesAsync();
            return Ok(model);
        }

        [HttpDelete]
        [Route("")]
        public async Task<ActionResult<Grupo>> Delete([FromServices] DataContext context, 
            [FromBody] Grupo model)
        {
            context.Grupos.Remove(model);
            await context.SaveChangesAsync();
            return Ok();
        }
    }
}