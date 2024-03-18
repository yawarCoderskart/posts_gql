using Microsoft.AspNetCore.Mvc;
using Posts_graphql.Domain.Models;


namespace Post_gql.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PostsController : ControllerBase
    {
        [HttpGet]
        [Route("{id}")]
        public IActionResult GetById(int id)
        {
            var post = new Post {   Text = "hello" };
            return Ok(post);
        }
    }
}