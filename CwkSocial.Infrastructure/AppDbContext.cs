using CwkSocial.Domain.Aggregates.PostAggregate;
using CwkSocial.Domain.Aggregates.UserProfileAggregate;
using CwkSocial.Infrastructure.Configurations;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CwkSocial.Infrastructure;

public class AppDbContext : IdentityDbContext
{
    public DbSet<UserProfile> UserProfiles { get; set; }
    public DbSet<Post> Posts { get; set; }


    public AppDbContext(DbContextOptions options) : base(options) {}


    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder
            .ApplyConfiguration(new CommentConfig())
            .ApplyConfiguration(new InteractionConfig())
            .ApplyConfiguration(new UserProfileConfig())
            .ApplyConfiguration(new IdentityUserLoginConfig())
            .ApplyConfiguration(new IdentityUserRoleConfig())
            .ApplyConfiguration(new IdentityUserTokenConfig());
    }
}
