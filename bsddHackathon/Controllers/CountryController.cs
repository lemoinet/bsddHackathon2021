using bsddHackathon.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace bsddHackathon.Controllers
{
    public class CountryController : Controller
    {
        private readonly IGraphQLService _service;

        public CountryController(IGraphQLService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            var countries = await _service.GetCountries();

            return View(countries);
        }
    }
}
