using MediatR;
using CwkSocial.Domain.Aggregates.UserProfileAggregate;

namespace CwkSocial.Application.UserProfiles.Commands;

public record CreateUserProfileCommand(string Firstname,
                                       string Lastname,
                                       string EmailAddress,
                                       string PhoneNumber,
                                       DateTime DateOfBirth,
                                       string CurrentCity) : IRequest<UserProfile>;