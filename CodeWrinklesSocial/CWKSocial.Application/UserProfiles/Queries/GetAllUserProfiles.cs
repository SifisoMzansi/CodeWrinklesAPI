using CWKSocial.Domain.Aggregates.UserProfileAggregates;
using MediatR;

namespace CWKSocial.Application.UserProfiles.Queries
{
    public class GetAllUserProfiles : IRequest<IEnumerable<UserProfile>>
    {
        public GetAllUserProfiles()
        {
        }
    }
}
