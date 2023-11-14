using Microsoft.AspNetCore.Mvc;
using Project.Models;
using Project.Services;

namespace Project.Controllers
{
    [Route("LopHoc")]
    public class LopHocController : Controller
    {
        private readonly LopHocService _lopHocServices;
        public LopHocController(LopHocService lopHocService)
        {
            _lopHocServices = lopHocService;
        }

        [HttpPost("GetList")]
        public async Task<IActionResult> listLopHoc([FromBody] Page page)
        {
            var st = _lopHocServices.showlistLopHoc(page);
            return Ok(st);
        }

        [HttpPost("setlist")]
        public async Task<IActionResult> setLopHoc([FromBody] LopHoc lh)
        {
            dynamic a = _lopHocServices.setLopHoc(lh);
            return Ok(a);
        }
        //[HttpPost("Set")]
        //public async Task<IActionResult> addLopHoc([FromBody] LopHoc lh)
        //{

        //    string a = _lopHocServices.addLopHoc(lh);
        //    return Ok(a);
        //}
        [HttpPost("Delete")]
        public async Task<IActionResult> deleteMonHoc(string id)
        {
            string b = _lopHocServices.dltLopHoc(id);
            return Ok(b);

        }
    }
}
