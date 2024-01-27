using AutoMapper;
using CwkSocial.Application.UserProfiles.Commands;
using CwkSocial.Domain.Aggregates.UserProfileAggregate;
using CwkSocial.Infrastructure;
using MediatR;

namespace CwkSocial.Application.UserProfiles.CommandHandlers;

public class CreateUserProfileCommandHandler : IRequestHandler<CreateUserProfileCommand, UserProfile>
{
    private readonly AppDbContext _context;

    public CreateUserProfileCommandHandler(AppDbContext context)
    {
        _context = context;
    }

    public async Task<UserProfile> Handle(CreateUserProfileCommand request,
                                          CancellationToken cancellationToken)
    {
        var basicInfo = BasicInfo.Create(
            request.Firstname,
            request.Lastname,
            request.EmailAddress,
            request.PhoneNumber,
            request.DateOfBirth,
            request.CurrentCity
        );

        var userProfile = UserProfile.Create(Guid.NewGuid().ToString(), basicInfo);

        _context.UserProfiles.Add(userProfile);
        await _context.SaveChangesAsync();

        return userProfile;
    }
}
