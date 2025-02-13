using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RssSample.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ImagesController : ControllerBase
    {
        [HttpGet("{imageName}")]
        public IActionResult GetImage(string imageName)
        {
            var imagePath = Path.Combine(Environment.CurrentDirectory, "wwwroot", "images", imageName);

            if (!System.IO.File.Exists(imagePath))
            {
                return NotFound();
            }

            var imageFileStream = System.IO.File.OpenRead(imagePath);
            return File(imageFileStream, "image/jpeg");
        }
    }
}
