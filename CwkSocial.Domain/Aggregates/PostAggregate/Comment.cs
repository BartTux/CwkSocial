using CwkSocial.Domain.Aggregates.UserProfileAggregate;

namespace CwkSocial.Domain.Aggregates.PostAggregate;

public class Comment
{
    public Guid Id { get; private set; }
    public Guid UserProfileId { get; private set; }
    public Guid PostId { get; private set; }
    public string TextContent { get; private set; }
    public DateTime CreatedAt { get; private set; }
    public DateTime LastModifiedAt { get; private set;}


    private Comment() {}


    //TODO: Add validation, error handling strategies, error notification strategies 
    public static Comment Create(Guid userProfileId, Guid postId, string content)
        => new()
        {
            UserProfileId = userProfileId,
            PostId = postId,
            TextContent = content,
            CreatedAt = DateTime.UtcNow,
            LastModifiedAt = DateTime.UtcNow
        };


    // Public methods
    public void UpdateTextContent(string content)
    {
        TextContent = content;
        LastModifiedAt = DateTime.UtcNow;
    }
}
