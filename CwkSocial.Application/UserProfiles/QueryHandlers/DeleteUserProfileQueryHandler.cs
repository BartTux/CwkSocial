using CwkSocial.Application.UserProfiles.Queries;
using CwkSocial.Infrastructure;
using Microsoft.EntityFrameworkCore;
using MediatR;

namespace CwkSocial.Application.UserProfiles.QueryHandlers;

public class DeleteUserProfileQueryHandler : IRequestHandler<DeleteUserProfileQuery>
{
    private readonly AppDbContext _context;

    public DeleteUserProfileQueryHandler(AppDbContext context)
    {
        _context = context;
    }

    public async Task Handle(DeleteUserProfileQuery request, CancellationToken cancellationToken)
    {
        var userProfile = await _context.UserProfiles
            .FirstOrDefaultAsync(up => up.Id == request.Id)
            ?? throw new Exception("User not found");

        _context.Remove(userProfile);
        await _context.SaveChangesAsync();
    }
}
