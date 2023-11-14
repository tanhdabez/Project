using Microsoft.AspNetCore.Mvc;
using Project.Models;
using Project.Services;

namespace Project.Controllers
{
    [Route("LopHoc")]
    public class HocPhiController : Controller
    {
        private readonly HocPhiService _hocPhiServices;
        public HocPhiController(HocPhiService hocPhiServices)
        {
            _hocPhiServices = hocPhiServices;

        }

        [HttpPost("post_hocphi")]
        public async Task<IActionResult> setHocPhi([FromBody] TimKiemHocPhi timkiem)
        {
            var st = _hocPhiServices.tinhHocPhi(timkiem);
            return Ok(st);
        }
    }
}
