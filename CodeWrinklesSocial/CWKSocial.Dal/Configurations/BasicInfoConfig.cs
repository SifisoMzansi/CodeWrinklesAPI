using CWKSocial.Domain.Aggregates.UserProfileAggregates;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CWKSocial.Dal.Configurations
{
    internal class BasicInfoConfig : IEntityTypeConfiguration<BasicInfo>
    {
        public void Configure(EntityTypeBuilder<BasicInfo> builder)
        {
          //  builder.HasKey(pc => pc.);
        }
    }
}
