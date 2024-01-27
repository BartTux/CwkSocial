using CwkSocial.Domain.Aggregates.UserProfileAggregate;
using MediatR;

namespace CwkSocial.Application.UserProfiles.Queries;

public record GetAllUserProfilesQuery : IRequest<IEnumerable<UserProfile>>;
