using CWKSocial.Application.UserProfiles.Queries;
using CWKSocial.Dal;
using CWKSocial.Domain.Aggregates.UserProfileAggregates;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CWKSocial.Application.UserProfiles.QueryHandlers
{
    internal class GetAllUserProfilesByIdHandler : IRequestHandler<GetAllUserProfileById, UserProfile>
    {
        private readonly DataContext _dataContext;

        public GetAllUserProfilesByIdHandler(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<UserProfile> Handle(GetAllUserProfileById request, CancellationToken cancellationToken)
        {
            return  await _dataContext.UserProfiles.FirstOrDefaultAsync(up => up.UserProfileId == request.UserProfileId );
         }
    }
}
