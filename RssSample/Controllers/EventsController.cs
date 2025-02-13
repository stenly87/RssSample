using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RssSample.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class EventsController : ControllerBase
    {
        NewsService _newsService;

        public EventsController(NewsService newsService)
        {
            _newsService = newsService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Events>> Get()
        {
            return Ok(_newsService.GetCatNews());
        }
    }
}
