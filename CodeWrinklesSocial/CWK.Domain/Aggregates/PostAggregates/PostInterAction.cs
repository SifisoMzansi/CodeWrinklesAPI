using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CWKSocial.Domain.Aggregates.PostAggregates
{
    public class PostInterAction
    {
        private PostInterAction() { }

        public Guid InteractionId { get; private set; } 
        public Guid PostId { get; private set; }    
        public InteractionType InteractionType { get; private set; }

        // Factory
        public static PostInterAction CreatePostInteraction(Guid postId , InteractionType interactionType)
        { 
            return new PostInterAction { InteractionId = postId , InteractionType = interactionType };
        }
    }
}
