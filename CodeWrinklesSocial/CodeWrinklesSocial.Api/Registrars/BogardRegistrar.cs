using CWKSocial.Application.UserProfiles.Queries;
using MediatR;
using System.Reflection;

namespace CodeWrinklesSocial.Api.Registrars
{
    public class BogardRegistrar : IWebApplicationBuilderRegistrar
    {
        public void RegisterServices(WebApplicationBuilder builder)
        {
            builder.Services.AddAutoMapper(typeof(Program), typeof(GetAllUserProfiles));
         //   builder.Services.AddMediatR(typeof(GetAllUserProfiles));

            builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly()));

        }
    }
}
