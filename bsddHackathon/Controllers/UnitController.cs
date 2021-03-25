using bsddHackathon.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace bsddHackathon.Controllers
{
    public class UnitController : Controller
    {
        private readonly IGraphQLService _service;

        public UnitController(IGraphQLService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            var units = await _service.GetUnits();

            return View(units);
        }
    }
}
