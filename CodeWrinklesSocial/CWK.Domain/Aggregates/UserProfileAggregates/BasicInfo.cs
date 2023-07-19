using System.Reflection.Metadata.Ecma335;

namespace CWKSocial.Domain.Aggregates.UserProfileAggregates
{
    public class BasicInfo
    {
        private BasicInfo() { }

        public string FirstName { get; private set; } = null!;
        public string LastName { get; private set; } = null!;

        public string EmailAddress { get; private set; } = null!;

        public string Description { get; private set; } = null!;

        public string Title { get; private set; } = null!;
        public string Phone { get; private set; } = null!;


        public DateTime DateOfBirth  { get; private set; }
        public string CUrrentCity { get; private set; } = null!;


        //Factory Method
        public static BasicInfo CreateBasicInfo(string firstName, string lastName, string emailAddress, string phone
          , DateTime dateOfbirth, string currentCity)
        {
            return new BasicInfo()
            {
                FirstName = firstName,
                LastName = lastName,
                EmailAddress = emailAddress,
                Phone = phone,
                DateOfBirth=dateOfbirth, 
                CUrrentCity = currentCity,
                Description = "New User"
            };
        }

       
    }
}
