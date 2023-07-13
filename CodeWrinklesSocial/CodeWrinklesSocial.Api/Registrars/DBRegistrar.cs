using CWKSocial.Dal;
using Microsoft.EntityFrameworkCore;

namespace CodeWrinklesSocial.Api.Registrars
{
    public class DBRegistrar : IWebApplicationBuilderRegistrar
    {
        public void RegisterServices(WebApplicationBuilder builder)
        {
            var cs = builder.Configuration.GetConnectionString("Default");
            builder.Services.AddDbContext<DataContext>(options => options.UseSqlServer(cs) );   
         }
    }
}