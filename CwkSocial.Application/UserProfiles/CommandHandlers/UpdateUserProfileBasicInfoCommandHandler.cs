using CwkSocial.Application.UserProfiles.Commands;
using CwkSocial.Domain.Aggregates.UserProfileAggregate;
using CwkSocial.Infrastructure;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace CwkSocial.Application.UserProfiles.CommandHandlers;

public class UpdateUserProfileBasicInfoCommandHandler : IRequestHandler<UpdateUserProfileBasicInfoCommand>
{
    private readonly AppDbContext _context;

    public UpdateUserProfileBasicInfoCommandHandler(AppDbContext context)
    {
        _context = context;
    }

    public async Task Handle(UpdateUserProfileBasicInfoCommand request,
                             CancellationToken cancellationToken)
    {
        var userProfile = await _context.UserProfiles
            .FirstOrDefaultAsync(up => up.Id == request.Id)
            ?? throw new Exception();

        var basicInfo = BasicInfo.Create(
            request.Firstname,
            request.Lastname,
            request.EmailAddress,
            request.PhoneNumber,
            request.DateOfBirth,
            request.CurrentCity
        );

        userProfile.UpdateBasicInfo(basicInfo);

        _context.UserProfiles.Update(userProfile);
        await _context.SaveChangesAsync();
    }
}
