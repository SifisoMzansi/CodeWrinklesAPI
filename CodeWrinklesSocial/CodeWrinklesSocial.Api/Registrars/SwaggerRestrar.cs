using CodeWrinklesSocial.Api.Options;

namespace CodeWrinklesSocial.Api.Registrars
{
    public class SwaggerRestrar : IWebApplicationBuilderRegistrar
    {
         public void RegisterServices(WebApplicationBuilder builder)
        {
            builder.Services.AddSwaggerGen(); 
            builder.Services.ConfigureOptions<ConfigureSwaggerOptions>();
        }
    }
}
