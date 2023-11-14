using Microsoft.AspNetCore.Mvc;
using Project.Models;
using Project.Services;

namespace Project.Controllers
{
    [Route("DungCu")]
    public class DungCuController : Controller
    {
        private readonly DMDungCuService _dungCuServices;
        public DungCuController(DMDungCuService dungCuServices)
        {
            _dungCuServices = dungCuServices;
        }

        [HttpPost("GetList")]
        public async Task<IActionResult> listDungCu([FromBody] Page page)
        {
            var st = _dungCuServices.showlistDungCu(page);
            return Ok(st);
        }

        [HttpPost("Set")]
        public async Task<IActionResult> addDungCu([FromBody] DungCu dc)
        {

            string a = _dungCuServices.addDungCu(dc);
            return Ok(a);
        }
        [HttpPost("Delete")]
        public async Task<IActionResult> deleteDungCu(string id)
        {
            string b = _dungCuServices.dltDungCu(id);
            return Ok(b);

        }
    }
}
