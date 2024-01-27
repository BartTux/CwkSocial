using MediatR;

namespace CwkSocial.Application.UserProfiles.Queries;

public record DeleteUserProfileQuery(Guid Id) : IRequest;