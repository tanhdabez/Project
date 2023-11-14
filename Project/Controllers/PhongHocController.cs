using Microsoft.AspNetCore.Mvc;
using Project.Models;
using Project.Services;

namespace Project.Controllers
{
    [Route("PhongHoc")]
    public class PhongHocController : Controller
    {
        private readonly DMPhongHocService _phongHocServices;
        public PhongHocController(DMPhongHocService phongHocService)
        {
            _phongHocServices = phongHocService;
        }

        [HttpPost("GetList")]
        public async Task<IActionResult> listDanhSach([FromBody] Page page)
        {
            var st = _phongHocServices.showlistPhongHoc(page);
            return Ok(st);
        }

        [HttpPost("Set")]
        public async Task<IActionResult> addPhongHoc([FromBody] PhongHoc ph)
        {

            string a = _phongHocServices.addPhongHoc(ph);
            return Ok(a);
        }
        [HttpPost("Delete")]
        public async Task<IActionResult> deleteMonHoc(string id)
        {
            string b = _phongHocServices.dltPhongHoc(id);
            return Ok(b);

        }
    }
}
