namespace CwkSocial.Api.Models.UserProfile.Responses;


public record UserProfileResponse(string IdentityId,
                                  BasicInfo BasicInfo,
                                  DateTime CreatedAt,
                                  DateTime LastModifiedAt);