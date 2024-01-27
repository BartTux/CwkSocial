using MediatR;

namespace CwkSocial.Application.UserProfiles.Commands;

public record UpdateUserProfileBasicInfoCommand(Guid Id,
                                                string Firstname,
                                                string Lastname,
                                                string EmailAddress,
                                                string PhoneNumber,
                                                DateTime DateOfBirth,
                                                string CurrentCity) : IRequest;