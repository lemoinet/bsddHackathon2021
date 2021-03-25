using bsddHackathon.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace bsddHackathon.Controllers
{
    public class DomainController : Controller
    {
        private readonly IGraphQLService _service;

        public DomainController(IGraphQLService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            var domains = await _service.GetDomains();

            return View(domains);
        }

        public async Task<IActionResult> Details([FromQuery] string namespaceUri)
        {
            var response = await _service.GetDomain(namespaceUri);
            if (null == response.Data.Domain)
            {
                return NotFound();
            }

            return View(response.Data.Domain);
        }

        [HttpPost]
        public async Task<IActionResult> Details([FromQuery] string namespaceUri, string searchText)
        {
            var response = await _service.GetDomain(namespaceUri, searchText ?? string.Empty);
            if (null == response.Data.Domain)
            {
                return NotFound();
            }

            return View(response.Data.Domain);
        }
    }
}
