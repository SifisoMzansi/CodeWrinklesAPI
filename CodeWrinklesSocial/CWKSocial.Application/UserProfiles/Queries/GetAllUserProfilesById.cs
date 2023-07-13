using CWKSocial.Domain.Aggregates.UserProfileAggregates;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CWKSocial.Application.UserProfiles.Queries
{
    public class GetAllUserProfileById :IRequest<UserProfile>
    { 
        public Guid UserProfileId { get; set; } 
    }
}
