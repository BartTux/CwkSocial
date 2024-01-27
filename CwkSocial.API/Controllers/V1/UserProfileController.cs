using CwkSocial.Api.Models.UserProfiles.Requests;
using CwkSocial.Application.UserProfiles.Commands;
using Microsoft.AspNetCore.Mvc;
using MediatR;
using AutoMapper;
using CwkSocial.Api.Models.UserProfile.Responses;
using CwkSocial.Application.UserProfiles.Queries;

namespace CwkSocial.Api.Controllers.V1;

[ApiController]
[ApiVersion("1.0")]
[Route("api/v{version:apiVersion}/[controller]")]
public class UserProfileController : ControllerBase
{
    private readonly IMediator _mediator;
    private readonly IMapper _mapper;

    public UserProfileController(IMediator mediator, IMapper mapper)
    {
        _mediator = mediator;
        _mapper = mapper;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var userProfiles = await _mediator.Send(new GetAllUserProfilesQuery());
        var response = _mapper.Map<IEnumerable<UserProfileResponse>>(userProfiles);

        return Ok(response);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById([FromRoute] string id)
    {
        var userProfile = await _mediator.Send(new GetUserProfileByIdQuery(Guid.Parse(id)));
        var response = _mapper.Map<UserProfileResponse>(userProfile);

        return Ok(response);
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] CreateUserProfileRequest request)
    {
        var command = _mapper.Map<CreateUserProfileCommand>(request);
        var userProfile = await _mediator.Send(command);

        var response = _mapper.Map<UserProfileResponse>(userProfile);

        return CreatedAtAction(nameof(GetById), new { id = userProfile.Id }, response);
    }

    [HttpPatch("{id}")]
    public async Task<IActionResult> Update([FromRoute] string id,
                                            [FromBody] UpdateUserProfileBasicInfoRequest request)
    {
        request.Id = Guid.Parse(id);
        var command = _mapper.Map<UpdateUserProfileBasicInfoCommand>(request);

        await _mediator.Send(command);

        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete([FromRoute] string id)
    {
        await _mediator.Send(new DeleteUserProfileQuery(Guid.Parse(id)));
        return NoContent();
    }
}
