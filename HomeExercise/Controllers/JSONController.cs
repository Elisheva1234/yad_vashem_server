using BuisnessLogic.DTO;
using BuisnessLogic.Services;
using DataAccess.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HomeExercise.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JSONController : ControllerBase
    {
        IJSONService service;
        public JSONController(IJSONService service) { this.service = service; }

        [HttpPost]
        [Route("AddImages")]
        public ActionResult<ImageModel> AddImags([FromBody] ImageModelDTO image)
        {
            service.AddImages(image);
            return Ok(image);
        }
        [HttpGet]
        [Route("GetTitelOfImg/{imageCode}")]
        public ActionResult<CollectionDetails> GetTitelOfImg(string imageCode)
        {
            return service.GetTitelOfImg(imageCode);
        }
    }
    public class aaa
    {
    }
}
