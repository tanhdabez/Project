using Microsoft.AspNetCore.Mvc;
using Project.Models;
using Project.Services;

namespace Project.Controllers
{
    [Route("TrinhDo")]
    public class TrinhDoController : Controller
    {
        private readonly DMTrinhDoService _trinhDoServices;
        public TrinhDoController(DMTrinhDoService trinhDoServices)
        {
            _trinhDoServices = trinhDoServices;
        }

        [HttpPost("GetList")]
        public async Task<IActionResult> listDanhSach([FromBody] Page page)
        {
            var st = _trinhDoServices.showlistTrinhDo(page);
            return Ok(st);
        }

        [HttpPost("Set")]
        public async Task<IActionResult> addMonHoc([FromBody] TrinhDo td)
        {

            string a = _trinhDoServices.addTrinhDo(td);
            return Ok(a);
        }
        [HttpPost("Delete")]
        public async Task<IActionResult> deleteMonHoc(string id)
        {
            string b = _trinhDoServices.dltTrinhDo(id);
            return Ok(b);

        }
    }
}
