using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace CPWebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DistrictsController : ControllerBase
    {
        private readonly YourDbContext _context;

        public DistritosController(YourDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Distrito>> GetDistritos()
        {
            return _context.Distritos.ToList();
        }

        [HttpGet("{id}")]
        public ActionResult<Distrito> GetDistrito(int id)
        {
            var distrito = _context.Distritos.Find(id);

            if (distrito == null)
                return NotFound();

            return distrito;
        }
    }
}
