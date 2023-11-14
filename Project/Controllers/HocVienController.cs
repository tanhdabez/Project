using Microsoft.AspNetCore.Mvc;
using Project.Models;
using Project.Services;

namespace Project.Controllers
{
    [Route("HocVien")]
    public class HocVienController : Controller
    {
        private readonly QuanLyHocVienService _hocVienServices;
        public HocVienController(QuanLyHocVienService hocVienServices)
        {
            _hocVienServices = hocVienServices;
        }

        [HttpPost("info HocVien")]
        public async Task<IActionResult> infoHocVien(string id)
        {
            var st = _hocVienServices.findIdHocVien(id);
            return Ok(st);
        }
        [HttpPost("GetList")]
        public async Task<IActionResult> listHocVien([FromBody] Page page)
        {
            var st = _hocVienServices.showlistHocVien(page);
            return Ok(st);
        }

        [HttpPost("Set")]
        public async Task<IActionResult> addHvien([FromBody] HocVien hv)
        {

            string a = _hocVienServices.addHocVien(hv);
            return Ok(a);
        }
        [HttpPost("Delete")]
        public async Task<IActionResult> dltHocVien(string id)
        {
            string b = _hocVienServices.deleteHocVien(id);
            return Ok(b);

        }
    }
}
