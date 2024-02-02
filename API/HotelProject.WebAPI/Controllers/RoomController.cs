using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomController : ControllerBase
    {
        //private readonly

        [HttpGet]
        public IActionResult RoomList()
        {
            return Ok();
        }

        [HttpPost]
        public IActionResult AddRoom()
        {
            return Ok();
        }

        [HttpDelete]
        public IActionResult DeleteRoom()
        {
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateRoom()
        {
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetList()
        {
            return Ok();
        }


    }
}
