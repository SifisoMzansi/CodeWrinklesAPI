using CWKSocial.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace CodeWrinklesSocial.Api.Controllers;

    [ApiController]
    [Route("[controller]")]
    public class PostsController : Controller
    {    
        [HttpGet]
        [Route("{id}")]
        public  IActionResult GetById(int id)
        {
            var post = new Post { Id = id , Text="Hello world"};
            return Ok(post);
        }
    }