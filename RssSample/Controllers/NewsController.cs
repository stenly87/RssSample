using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RssSample.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class NewsController : ControllerBase
    {
        NewsService _newsService;

        public NewsController(NewsService newsService)
        {
            _newsService = newsService;
        }

        [HttpPost]
        public ActionResult<IEnumerable<CatNews>> Get()
        {
            return Ok(_newsService.GetCatNews());
        }
    }
}
