using CWKSocial.Dal.Configurations;
using CWKSocial.Domain.Aggregates.PostAggregates;
using CWKSocial.Domain.Aggregates.UserProfileAggregates;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CWKSocial.Dal
{
    public class DataContext : IdentityDbContext
    {
        public DataContext(DbContextOptions options) :base (options) 
        {

        }

        public DbSet<UserProfile> UserProfiles { get; set; }
        public DbSet<Post> Posts { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new PostCommentConfig());
            builder.ApplyConfiguration(new PostInterActionConfig());
            builder.ApplyConfiguration(new UserProfileConfig());
            builder.ApplyConfiguration(new IdentityUserLoginConfig());
            builder.ApplyConfiguration(new IdentityUserRoleConfig());
            builder.ApplyConfiguration(new IdentityUserTokenConfig());

        }
    }
}
