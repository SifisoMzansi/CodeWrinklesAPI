using AutoMapper;
using CWKSocial.Application.UserProfiles.Commands;
using CWKSocial.Domain.Aggregates.UserProfileAggregates;

namespace CWKSocial.Application.MappingProfiles
{
    internal class UserProfileMap : Profile
    {
        public UserProfileMap() 
        {
            CreateMap<CreateUserCommand, BasicInfo>();
        }
    }
}
