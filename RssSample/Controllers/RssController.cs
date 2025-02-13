using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;
using System.Xml.Linq;

namespace RssSample.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class RssController : ControllerBase
    {
        NewsService _newsService;

        public RssController(NewsService newsService)
        {
            _newsService = newsService;
        }

        [HttpGet]
        public IActionResult GetRssFeed()
        {
            var newsItems = _newsService.GetRssNews();

            var rss = new XElement("rss",
                new XAttribute("version", "2.0"),
                new XElement("channel",
                    new XElement("title", "Новости о котах"),
                    new XElement("link", "https://fake-cat-news.com"),
                    new XElement("description", "Самые свежие и невероятные новости о котах со всего мира!"),
                    new XElement("language", "ru"),
                    new XElement("pubDate", DateTime.Now.ToString("f")),
                        from item in newsItems
                        select new XElement("item",
                            new XElement("title", item.Title),
                            new XElement("description", item.Description),
                            new XElement("link", item.Link),
                            new XElement("author", item.Author),
                            new XElement("pubDate", item.PubDate.ToString("f")),
                            new XElement("enclosure",
                            new XAttribute("url", $"{Request.Scheme}://{Request.Host}{item.ImageUrl}"),
                            new XAttribute("type", "image/jpeg")),
                            new XElement("category", "Котоновости")
                    )
                )
            );

            var xml = new XDocument(rss);

            return Content(xml.ToString(), "application/rss+xml");
        }
    }
}
