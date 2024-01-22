using CwkSocial.Domain.Aggregates.UserProfileAggregate;

namespace CwkSocial.Domain.Aggregates.PostAggregate;

public class Post
{
    private readonly List<Comment> _comments = new();
    private readonly List<Interaction> _interactions = new();

    public Guid Id { get; private set; }

    public Guid UserProfileId { get; private set; }
    public virtual UserProfile UserProfile { get; private set; }

    public string TextContent { get; private set; }
    public DateTime CreatedAt { get; private set; }
    public DateTime LastModifiedAt { get; private set; }

    public IEnumerable<Comment> Comments => _comments;
    public IEnumerable<Interaction> Interactions => _interactions;


    private Post() {}


    //TODO: Add validation, error handling strategies, error notification strategies 
    public static Post Create(Guid userProfileId, string textContent)
        => new()
        {
            UserProfileId = userProfileId,
            TextContent = textContent,
            CreatedAt = DateTime.UtcNow,
            LastModifiedAt = DateTime.UtcNow,
        };

    // Public methods
    public void UpdateTextContent(string content)
    {
        TextContent = content;
        LastModifiedAt = DateTime.UtcNow;
    }

    public void AddComment(Comment comment) => _comments.Add(comment);
    public void RemoveComment(Comment comment) => _comments.Remove(comment);
    public void AddInteraction(Interaction interaction) => _interactions.Add(interaction);
    public void RemoveInteraction(Interaction interaction) => _interactions.Remove(interaction);
}