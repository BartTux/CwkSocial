﻿using CwkSocial.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace CwkSocial.API.Controllers.V1;

[ApiController]
[ApiVersion("1.0")]
[Route("api/v{version:apiVersion}/[controller]")]
public class PostsController : ControllerBase
{
    [HttpGet("{id:int}")]
    public IActionResult GetById(int id)
    {
        var post = new Post { Id = id, Content = "text" };
        return Ok(post);
    }
}
