using AutoMapper;
using CodeWrinklesSocial.Api.Contracts.UserProfile.Requests;
using CodeWrinklesSocial.Api.Contracts.UserProfile.Responses;
using CWKSocial.Application.UserProfiles.Commands;
using CWKSocial.Domain.Aggregates.UserProfileAggregates;

namespace CodeWrinklesSocial.Api.MapppingProfile
{
    public class UserProfileMappings :Profile
    {
        public UserProfileMappings()
        {
            CreateMap<UserProfileCreate, CreateUserCommand >();
            CreateMap<UserProfile, UserProfileResponse>();
            CreateMap<BasicInfo, BasicInformation>();
        }
    }
}
