using CwkSocial.Domain.Aggregates.PostAggregate;
using Microsoft.AspNetCore.Mvc;

namespace CwkSocial.API.Controllers.V2;

[ApiController]
[ApiVersion("2.0")]
[Route("api/v{version:apiVersion}/[controller]")]
public class PostsController : ControllerBase
{
    [HttpGet("{id:int}")]
    public IActionResult GetById(int id)
    {
        return Ok();
    }
}
