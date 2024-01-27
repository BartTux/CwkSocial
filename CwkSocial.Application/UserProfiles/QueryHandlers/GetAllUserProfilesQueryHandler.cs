using CwkSocial.Application.UserProfiles.Queries;
using CwkSocial.Domain.Aggregates.UserProfileAggregate;
using CwkSocial.Infrastructure;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace CwkSocial.Application.UserProfiles.QueryHandlers;

public class GetAllUserProfilesQueryHandler 
    : IRequestHandler<GetAllUserProfilesQuery, IEnumerable<UserProfile>>
{
    private readonly AppDbContext _context;

    public GetAllUserProfilesQueryHandler(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<UserProfile>> Handle(GetAllUserProfilesQuery request,
                                                       CancellationToken cancellationToken)
    {
        var userProfiles = await _context.UserProfiles.ToListAsync();
        return userProfiles;
    }
}
