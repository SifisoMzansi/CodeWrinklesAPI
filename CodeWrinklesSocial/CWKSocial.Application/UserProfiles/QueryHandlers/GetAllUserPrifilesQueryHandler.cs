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
    internal class GetAllUserPrifilesQueryHandler : IRequestHandler<GetAllUserProfiles, IEnumerable<UserProfile>>
    {

        private readonly DataContext _dataContext;

        public GetAllUserPrifilesQueryHandler(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async    Task<IEnumerable<UserProfile>> Handle(GetAllUserProfiles request, CancellationToken cancellationToken)
        {
            return await _dataContext.UserProfiles.ToListAsync();
         }
    }
}
