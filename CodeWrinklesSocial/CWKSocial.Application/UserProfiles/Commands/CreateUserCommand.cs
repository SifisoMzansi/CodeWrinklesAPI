using CWKSocial.Domain.Aggregates.UserProfileAggregates;
using MediatR;

namespace CWKSocial.Application.UserProfiles.Commands
{
    public class CreateUserCommand :IRequest<UserProfile>
    {
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string EmailAddress { get; set; } = null!;
        public string Title { get; set; } = null!;
        public string Phone { get; set; } = null!;
        public DateTime DateOfBirth { get; private set; }
        public string CUrrentCity { get; private set; } = null!;
    }
}
