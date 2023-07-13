using CodeWrinklesSocial.Api.Routes;
using Microsoft.AspNetCore.Mvc;

namespace CodeWrinklesSocial.Api.Controllers.v1;

[ApiVersion("1.0")]
[Route(ApiRoutes.BaseRoute)]
[ApiController]
public class PostsController : Controller
{
    [HttpGet]
    [Route(ApiRoutes.Posts.GetById)]
    public IActionResult GetById(int id)
    {
         return Ok();
    }
}