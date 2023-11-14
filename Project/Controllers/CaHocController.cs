using Microsoft.AspNetCore.Mvc;
using Project.Models;
using Project.Services;

namespace Project.Controllers
{
    [Route("CaHoc")]
    public class CaHocController : Controller
    {
        private readonly CaHocService _caHocServices;
        public CaHocController(CaHocService caHocService)
        {
            _caHocServices = caHocService;
        }
        [HttpPost("Set")]
        public async Task<IActionResult> addCaHoc([FromBody] CaHoc ch)
        {

            string a = _caHocServices.addCaHoc(ch);
            return Ok(a);
        }

    }
}
