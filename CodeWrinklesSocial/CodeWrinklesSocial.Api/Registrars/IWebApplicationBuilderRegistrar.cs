using CodeWrinklesSocial.Api.Extensions;

namespace CodeWrinklesSocial.Api.Registrars
{
    public interface IWebApplicationBuilderRegistrar : IRegistrar
    {
        void RegisterServices(WebApplicationBuilder builder);
    }
}
