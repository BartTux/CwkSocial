using AutoMapper;
using CwkSocial.Api.Models.UserProfile.Responses;
using CwkSocial.Api.Models.UserProfiles.Requests;
using CwkSocial.Application.UserProfiles.Commands;
using CwkSocial.Domain.Aggregates.UserProfileAggregate;

namespace CwkSocial.Api.MappingProfiles;

public class UserProfileMappingProfile : Profile
{
    public UserProfileMappingProfile()
    {
        CreateMap<CreateUserProfileRequest, CreateUserProfileCommand>();
        CreateMap<BasicInfo, Models.BasicInfo>();

        CreateMap<UserProfile, UserProfileResponse>();

        CreateMap<UpdateUserProfileBasicInfoRequest, UpdateUserProfileBasicInfoCommand>();
    }
}
