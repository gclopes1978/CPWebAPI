using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;



namespace CPWebAPI.Controllers;
{
    [ApiController]
    [Route("api/[controller]")]
    public class Cities : ControllerBase
    {
        private readonly YourDbContext _context;

        public Cities(YourDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Concelho>> GetConcelhos(int distritoId, int? concelhoId = null)
        {
            if (concelhoId.HasValue)
            {
                var concelho = _context.Concelhos.FirstOrDefault(c => c.DistritoId == distritoId && c.ConcelhoId == concelhoId);

                if (concelho == null)
                    return NotFound();

                return concelho;
            }
            else
            {
                var concelhos = _context.Concelhos.Where(c => c.DistritoId == distritoId).ToList();

                if (concelhos.Count == 0)
                    return NotFound();

                return concelhos;
            }
        }
    }
}
