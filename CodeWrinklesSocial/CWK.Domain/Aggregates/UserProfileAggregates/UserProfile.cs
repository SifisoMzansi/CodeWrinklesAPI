namespace CWKSocial.Domain.Aggregates.UserProfileAggregates
{
    public class UserProfile
    {
        private UserProfile() { }
        public Guid UserProfileId { get; private set; }
        public string IdentityId { get; private  set; } = null!;
        public BasicInfo BasicInfo { get; private set; } = null!;
        public DateTime DateCreated { get; private set; }
        public DateTime LastModified { get; private set; }

        public static UserProfile CreateUserProfile(string identity, BasicInfo basicInfo)
        {
            //To do Add validation Error handling , Error Notification strategies
            return new UserProfile()
            {
                IdentityId = identity,
                BasicInfo = basicInfo,
                DateCreated = DateTime.UtcNow,
                LastModified = DateTime.UtcNow
            };

         }

        //Public Info
        public void UpdateBasicInfo(BasicInfo basicInfo)
        {
            BasicInfo = basicInfo;
            LastModified = DateTime.UtcNow;
        }

    }
}
