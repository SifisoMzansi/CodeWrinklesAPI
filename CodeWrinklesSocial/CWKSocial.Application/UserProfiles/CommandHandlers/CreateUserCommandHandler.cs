using AutoMapper;
using CWKSocial.Application.UserProfiles.Commands;
using CWKSocial.Dal;
using CWKSocial.Domain.Aggregates.UserProfileAggregates;
using MediatR;

namespace CWKSocial.Application.UserProfiles.CommandHandlers
{
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, UserProfile>
    {

        private readonly DataContext _dataContext;
        public CreateUserCommandHandler(DataContext dataContext )
        {
            _dataContext = dataContext;
 }

         

        public  async Task<UserProfile> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            var basicInfo = BasicInfo.CreateBasicInfo(request.FirstName , request.LastName , request.EmailAddress , request.Phone , request.DateOfBirth, request.CUrrentCity);

            var userProfile = UserProfile.CreateUserProfile(Guid.NewGuid().ToString(), basicInfo);
            _dataContext.UserProfiles.Add(userProfile);
            await _dataContext.SaveChangesAsync();
            return userProfile;
         }
    }
}
