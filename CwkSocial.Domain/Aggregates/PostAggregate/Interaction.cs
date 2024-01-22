using CwkSocial.Domain.Aggregates.Enums;

namespace CwkSocial.Domain.Aggregates.PostAggregate;

public class Interaction
{
    public Guid Id { get; private set; }
    public Guid PostId { get; private set; }
    public InteractionTypeEnum InteractionType { get; private set; }


    private Interaction() {}


    //TODO: Add validation, error handling strategies, error notification strategies 
    public static Interaction Create(Guid postId, InteractionTypeEnum interactionType)
        => new()
        {
            PostId = postId,
            InteractionType = interactionType
        };

    // Public methods
    public void UpdateInteractionType(InteractionTypeEnum interactionType) 
        => InteractionType = interactionType;
}
