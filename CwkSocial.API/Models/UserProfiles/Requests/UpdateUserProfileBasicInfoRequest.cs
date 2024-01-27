namespace CwkSocial.Api.Models.UserProfiles.Requests;

public record UpdateUserProfileBasicInfoRequest
{
    public Guid Id { get; set; }
    public string Firstname { get; set; }
    public string Lastname { get; set; }
    public string EmailAddress { get; set; }
    public string PhoneNumber { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string CurrentCity { get; set; }
}