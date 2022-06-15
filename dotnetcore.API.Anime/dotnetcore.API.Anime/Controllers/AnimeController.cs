using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace dotnetcore.API.Anime.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnimeController : ControllerBase
    {
        // GET: api/<AnimeController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

       
    }
}
