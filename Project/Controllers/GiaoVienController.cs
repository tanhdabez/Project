using Microsoft.AspNetCore.Mvc;
using Project.Models;
using Project.Services;

namespace Project.Controllers
{
    [Route("GiaoVien")]
    public class GiaoVienController : Controller
    {
        private readonly QuanLyGiaoVienService _giaoVienService;
        public GiaoVienController(QuanLyGiaoVienService giaoVienService)
        {
            _giaoVienService = giaoVienService;
        }

        [HttpPost("GetList")]
        public async Task<IActionResult> listGIaoVien([FromBody] Page page)
        {
            var st = _giaoVienService.showlistGiaoVien(page);
            return Ok(st);
        }

        [HttpPost("Set")]
        public async Task<IActionResult> addGiaoVien([FromBody] GiaoVien gv)
        {
            string a = _giaoVienService.addGVien(gv);
            return Ok(a);
        }
        [HttpPost("Delete")]
        public async Task<IActionResult> deleteGiaoVien(string id)
        {
            string b = _giaoVienService.dltGiaoVien(id);
            return Ok(b);

        }
    }
}
