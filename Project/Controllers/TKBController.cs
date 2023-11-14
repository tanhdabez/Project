using Microsoft.AspNetCore.Mvc;
using Project.Models;
using Project.Services;

namespace Project.Controllers
{
    [Route("TKB")]
    public class TKBController : Controller
    {
        private readonly TKBService _tKBServices;
        public TKBController(TKBService tKBService)
        {
            _tKBServices = tKBService;
        }

        [HttpPost("Get")]
        public async Task<IActionResult> timTKB([FromBody] TimKiemThoiKhoaBieu ph)
        {
            dynamic a = _tKBServices.findTKBbyDay(ph);
            return Ok(a);
        }
        [HttpPost("find")]
        public async Task<IActionResult> findtkb([FromBody] TimKiemThoiKhoaBieu tktkb)
        {
            dynamic a = _tKBServices.findtkb(tktkb);
            return Ok(a);
        }

        [HttpPost("Set")]
        public async Task<IActionResult> addTKB([FromBody] TKB tkb)
        {
            dynamic tgb = _tKBServices.addTKB(tkb);
            return Ok(tgb);
        }
        [HttpPost("Delete")]
        public async Task<IActionResult> deleteTKB(string id)
        {
            dynamic b = _tKBServices.dltTKB(id);
            return Ok(b);

        }
    }
}
