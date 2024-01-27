using CwkSocial.Domain.Aggregates.UserProfileAggregate;
using MediatR;

namespace CwkSocial.Application.UserProfiles.Queries;

public record GetUserProfileByIdQuery(Guid id) : IRequest<UserProfile>;
