using AutoMapper;
using CodeWrinklesSocial.Api.Contracts.UserProfile.Requests;
using CodeWrinklesSocial.Api.Contracts.UserProfile.Responses;
using CodeWrinklesSocial.Api.Routes;
using CWKSocial.Application.UserProfiles.Commands;
using CWKSocial.Application.UserProfiles.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CodeWrinklesSocial.Api.Controllers.v1
{
    [ApiVersion("1.0")]
    [Route(ApiRoutes.BaseRoute)]
    [ApiController]
    public class UserProfilesController:Controller
    {
        private readonly IMediator _mediator;
        private readonly IMapper  _mapper;

        public UserProfilesController(IMediator mediator , IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }

        [HttpGet]
        public  async Task<IActionResult> GetAllProfiles()
        {
            var query = new GetAllUserProfiles();
            var response = await _mediator.Send(query);
            var Profiles = _mapper.Map < List<UserProfileResponse>>(response);
            return Ok(Profiles);
        }

        public async Task<IActionResult> CreateUserProfile([FromBody]UserProfileCreate profile)
        {

            var command = _mapper.Map<CreateUserCommand>(profile);
            var response = await _mediator.Send(command);
            var userProfile = _mapper.Map<UserProfileResponse>(response);

           return CreatedAtAction(nameof(GetUserProfileId), new { id = response.UserProfileId }, userProfile);
         }

        [Route(ApiRoutes.UserProfiles.IdRoute)]
        public async Task<IActionResult> GetUserProfileId(string id)
        {
            var query = new GetAllUserProfileById(){ UserProfileId = Guid.Parse(id)} ;
            var response = _mediator.Send(query);
            var userProfile = _mapper.Map<UserProfileResponse>(response);
            return Ok(userProfile);
        }
    }
}
