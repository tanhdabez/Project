using Microsoft.AspNetCore.Mvc;
using Project.Models;
using Project.Services;

namespace Project.Controllers
{
    [Route("MonHoc")]
    public class MonHocController : Controller
    {
        private readonly DMMonHocService _monHocServices;
        public MonHocController(DMMonHocService monHocServices)
        {
            _monHocServices = monHocServices;
        }

        [HttpPost("GetList")]
        public async Task<IActionResult> listDanhSach([FromBody] Page page)
        {
            var st = _monHocServices.showListMonHoc(page);
            return Ok(st);
        }

        [HttpPost("Set")]
        public async Task<IActionResult> addMonHoc([FromBody] MonHoc mh)
        {

            string a = _monHocServices.addMonHoc(mh);
            return Ok(a);
        }
        [HttpPost("Delete")]
        public async Task<IActionResult> deleteMonHoc(string id)
        {
            string b = _monHocServices.deleteMonHoc(id);
            return Ok(b);

        }
    }
}
