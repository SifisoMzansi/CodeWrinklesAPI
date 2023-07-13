using CodeWrinklesSocial.Api.Registrars;

namespace CodeWrinklesSocial.Api.Extensions
{
    public static class RegistraExtensions
    {
        public static void ResterServices(this WebApplicationBuilder builder , Type scanningType)
        {
            var registrars = GetRegistrars<IWebApplicationBuilderRegistrar>(scanningType);

            foreach (var registrar in registrars)
            {
                registrar.RegisterServices(builder);
            }
        }

        public static void RegisterPipelineComponents(this WebApplication app, Type scanningType)
        {
            var registrars = GetRegistrars<IWebApplicationRegistrar>(scanningType);
            foreach (var registrar in registrars)
            {
                registrar.RegisterPipelineComponents(app);
            }
        }

        private static IEnumerable<T> GetRegistrars<T>(Type scanningType) where T : IRegistrar
        {
            return scanningType.Assembly.GetTypes()
                .Where(t => t.IsAssignableTo(typeof(T)) && !t.IsAbstract && !t.IsInterface)
                .Select(Activator.CreateInstance)
                .Cast<T>();
        }
    }
}
