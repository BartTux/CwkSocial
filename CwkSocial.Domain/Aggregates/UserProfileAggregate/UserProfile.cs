namespace CwkSocial.Domain.Aggregates.UserProfileAggregate;

public class UserProfile
{
    public Guid Id { get; private set; }
    public string IdentityId { get; private set; }
    public BasicInfo BasicInfo { get; private set; }
    public DateTime CreatedAt { get; private set; }
    public DateTime LastModifiedAt { get; private set; }


    private UserProfile() {}


    // TODO: Add validation, error handling strategies, error notification strategies 
    public static UserProfile Create(string identityId, BasicInfo basicInfo)
        => new()
        {
            IdentityId = identityId,
            BasicInfo = basicInfo,
            CreatedAt = DateTime.UtcNow,
            LastModifiedAt = DateTime.UtcNow,
        };


    // Public methods
    public void UpdateBasicInfo(BasicInfo basicInfo)
    {
        BasicInfo = basicInfo;
        LastModifiedAt = DateTime.UtcNow;
    }
}