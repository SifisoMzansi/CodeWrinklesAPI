﻿namespace CWKSocial.Domain.Aggregates.PostAggregates
{
    public class PostComment
    {
        public Guid CommentId { get; private set; }
        public Guid PostId { get; private set; }
        public string Text  { get; private set; } = string.Empty;
        public Guid UserProfileId { get; private set; }
        public DateTime DateCreated { get; private set; }
        public DateTime LastModified { get; private set; }

        //Factories 

        public static PostComment CreatePostComment(Guid postId, string text, Guid userProfileId)
        {
            return new PostComment()
            {
                PostId = postId,
                 Text = text,
                 UserProfileId = userProfileId,
                 DateCreated = DateTime.UtcNow,
                 LastModified = DateTime.UtcNow
            };
        }

        //public methods 
        public void UpdateCommentText(string newText)
        {
            Text = newText;
            LastModified = DateTime.UtcNow;
        }
    }
}