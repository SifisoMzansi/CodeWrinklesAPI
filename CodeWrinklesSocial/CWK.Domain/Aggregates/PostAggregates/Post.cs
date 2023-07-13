using CWKSocial.Domain.Aggregates.UserProfileAggregates;
using System.Net.Http.Headers;

namespace CWKSocial.Domain.Aggregates.PostAggregates
{
    public class Post
    {
        private readonly List<PostComment> _comments = new List<PostComment>();
        private readonly List<PostInterAction> _postInterAction = new List<PostInterAction>();

        private Post()
        {
         
        }

        public Guid PostId { get; private set; }
        public Guid UserProfileId { get; private set; }
        public UserProfile? UserProfile { get; private set; }
        public string TextContent { get; private set; } = string.Empty;
        public DateTime CreateDate { get; private set; }
        public DateTime LastModified { get; private set; }
        public IEnumerable<PostComment>? Comments
        {
            get
            {
                return _comments;
            }
        }
        public IEnumerable<PostInterAction>? Interactions 
        { 
            get { 
                return _postInterAction; 
            }  }

        //Factory Method
        public static Post CreatePost(Guid userProfileId,string textContent)
        {
            return new Post
            {
                UserProfileId = userProfileId,
                TextContent = textContent,
                CreateDate = DateTime.UtcNow,
                LastModified = DateTime.UtcNow
            };
        }

        //public methods 
        public void UpdatePostText(string newText)
        { 
            TextContent = newText;
            LastModified = DateTime.UtcNow;
        }
        public void AddPostComment(PostComment newComment)
        {
            _comments.Add(newComment);
        }
        public void RemoveComment(PostComment toComment)
        {
            _comments.Remove(toComment);
        }
        public void AddPostInteraction(PostInterAction postInterAction)
        {
            _postInterAction.Add(postInterAction);
        }
        public void RemovePostInteraction(PostInterAction postInterAction)
        {
            _postInterAction.Remove(postInterAction);
        }
    }
}
