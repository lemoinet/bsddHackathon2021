using bsddHackathon.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace bsddHackathon.Controllers
{
    public class ReferenceDocumentController : Controller
    {
        private readonly IGraphQLService _service;

        public ReferenceDocumentController(IGraphQLService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            var referenceDocument = await _service.GetReferenceDocuments();

            return View(referenceDocument);
        }
    }
}
