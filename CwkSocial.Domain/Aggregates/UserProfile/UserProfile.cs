namespace CwkSocial.Domain.Aggregates.UserProfile;

public class UserProfile
{
    public Guid Id { get; set; }
    public string IdentityId { get; set; }
    public BasicInfo BasicInfo { get; set; }

    public DateTime CreatedAt { get; set; }
    public DateTime ModifiedAt { get; set; }
    public string City { get; set; }
}
