using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using ShowroomApi.Data;

namespace ShowroomApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private readonly ShowroomContext db;

        public CompanyController(ShowroomContext _db)
        {
            db = _db;
        }

        [HttpGet]

        public IActionResult GetManufactures()
        {
            return Ok(db.Manufacturers.ToList());
        }
    }
}