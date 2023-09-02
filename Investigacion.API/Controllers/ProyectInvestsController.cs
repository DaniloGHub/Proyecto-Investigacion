using Microsoft.AspNetCore.Mvc;
using Investigacion.API.Data;
using Microsoft.EntityFrameworkCore;
using Investigacion.Shared.Entities;

namespace Investigacion.API.Controllers
{
    [ApiController]
    [Route("api/proyectinvests")]
    public class ProyectInvestsController : ControllerBase
    {
        private readonly DataContext _context;

        public ProyectInvestsController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult> Get()
        {
            return Ok(await _context.ProyectInvents.ToListAsync());
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult> Get(int id)
        {
            var proyectinvests = await _context.ProyectInvents.FirstOrDefaultAsync(x=>x.Id == id); 
            if (proyectinvests == null)
            {
                return NotFound();
            }
            return Ok(proyectinvests);
        }

        [HttpPost]
        public async Task<ActionResult> Post(ProyectInvest proyectinvest)
        {
            _context.Add(proyectinvest);
            await _context.SaveChangesAsync();
            return Ok(proyectinvest);
        }
    }
}