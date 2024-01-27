using CwkSocial.Domain.Aggregates.PostAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CwkSocial.Infrastructure.Configurations;

internal class CommentConfig : IEntityTypeConfiguration<Comment>
{
    public void Configure(EntityTypeBuilder<Comment> builder)
    {
        builder.HasKey(x => x.Id);
        builder
            .HasOne(c => c.UserProfile)
            .WithMany()
            .HasForeignKey(c => c.UserProfileId)
            .OnDelete(DeleteBehavior.NoAction);
    }
}
