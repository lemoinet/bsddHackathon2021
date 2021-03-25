using bsddHackathon.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace bsddHackathon.Controllers
{
    public class ClassificationController : Controller
    {
        private readonly IGraphQLService _service;

        public ClassificationController(IGraphQLService service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(string searchText)
        {
            if (string.IsNullOrWhiteSpace(searchText))
            {
                return View();
            }

            var classifications = await _service.SearchClassifications(searchText);

            return View(classifications);
        }

        public async Task<IActionResult> Details([FromQuery] string namespaceUri)
        {
            var response = await _service.GetClassification(namespaceUri);
            if (null == response.Data.Domain)
            {
                return NotFound();
            }

            return View(response);
        }
    }
}
