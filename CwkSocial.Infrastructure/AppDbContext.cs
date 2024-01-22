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
        builder.ApplyConfiguration(new CommentConfig());
        builder.ApplyConfiguration(new InteractionConfig());
        builder.ApplyConfiguration(new UserProfileConfiguration());
        builder.ApplyConfiguration(new IdentityUserLoginConfiguration());
        builder.ApplyConfiguration(new IdentityUserRoleConfiguration());
        builder.ApplyConfiguration(new IdentityUserTokenConfiguration());
    }
}
