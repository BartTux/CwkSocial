namespace CwkSocial.Domain.Aggregates.UserProfile;

public class BasicInfo
{
    public string Firstname { get; set; }
    public string Lastname { get; set; }
    public string EmailAddress { get; set; }
    public string PhoneNumber { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string CurrentCity { get; set; }
}
