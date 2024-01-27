using CwkSocial.Application.UserProfiles.Queries;
using CwkSocial.Domain.Aggregates.UserProfileAggregate;
using CwkSocial.Infrastructure;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace CwkSocial.Application.UserProfiles.QueryHandlers;

public class GetUserProfileByIdQueryHandler : IRequestHandler<GetUserProfileByIdQuery, UserProfile>
{
    private readonly AppDbContext _context;

    public GetUserProfileByIdQueryHandler(AppDbContext context)
    {
        _context = context;
    }

    public async Task<UserProfile> Handle(GetUserProfileByIdQuery request,
                                          CancellationToken cancellationToken)
    {
        var userProfile = await _context.UserProfiles
            .FirstOrDefaultAsync(up => up.Id == request.id)
            ?? throw new Exception("User not found");

        return userProfile;
    }
}
