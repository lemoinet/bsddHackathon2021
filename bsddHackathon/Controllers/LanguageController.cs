using bsddHackathon.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace bsddHackathon.Controllers
{
    public class LanguageController : Controller
    {
        private readonly IGraphQLService _service;

        public LanguageController(IGraphQLService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            var languages = await _service.GetLanguages();

            return View(languages);
        }
    }
}
