using CWKSocial.Domain.Aggregates.PostAggregates;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CWKSocial.Dal.Configurations
{
    internal class PostInterActionConfig : IEntityTypeConfiguration<PostInterAction>
    {
        public void Configure(EntityTypeBuilder<PostInterAction> builder)
        {
            builder.HasKey(pc => pc.InteractionId);        
                }
    }
}
