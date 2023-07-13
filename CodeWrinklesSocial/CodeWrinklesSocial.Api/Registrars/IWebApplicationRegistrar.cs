using CodeWrinklesSocial.Api.Extensions;

namespace CodeWrinklesSocial.Api.Registrars
{
    public interface IWebApplicationRegistrar : IRegistrar
    {
         void RegisterPipelineComponents(WebApplication app);
    }
}
