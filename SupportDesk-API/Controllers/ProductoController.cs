//using Microsoft.AspNetCore.Mvc;
//using Microsoft.EntityFrameworkCore;
//using SupportDesk_API.Data;
//using SupportDesk_API.Models;
//using Microsoft.EntityFrameworkCore.Design;
//using Microsoft.AspNetCore.Http.HttpResults;
//namespace SupportDesk_API.Controllers
//{
//    [ApiController]
//    [Route("api/[controller]")]
//    public class ProductoController : ControllerBase
//    {
//        private readonly SupportContext _context;

//        public ProductoController(SupportContext context)
//        {
//            _context = context;
//        }

//        [HttpGet]
//        public async Task<ActionResult<IEnumerable<Ejemplo>>> GetAll() => await _context.Ejemplos.ToListAsync();

//        [HttpGet("{Id}")]
//        public async Task<ActionResult<Ejemplo>> GetById(int Id)
//        {
//            var producto = await _context.Ejemplos.FindAsync(Id);
//            return producto is null ? NotFound() : producto;

//        }

//        [HttpPost]
//        public async Task<ActionResult<Ejemplo>> Create(Ejemplo producto)
//        {
//            _context.Ejemplos.Add(producto);
//            await _context.SaveChangesAsync();
//            return CreatedAtAction(nameof(GetById), new { id = producto.Id }, producto);
//        }

//        [HttpPut("{Id}")]
//        public async Task<IActionResult> Update(int Id, Ejemplo ejemplo)
//        {
//            if (Id != ejemplo.Id) return BadRequest();
//            _context.Entry(ejemplo).State = EntityState.Modified;
//            await _context.SaveChangesAsync();
//            return NoContent();
//        }

//        [HttpDelete("{Id}")]
//        public async Task<IActionResult> Detele(int id)
//        {
//            var productos = await _context.Ejemplos.FindAsync(id);
//            if (productos is null) return NotFound();
//            _context.Ejemplos.Remove(productos);
//            await _context.SaveChangesAsync();
//            return NoContent();
//        }
    
//    }
//}
