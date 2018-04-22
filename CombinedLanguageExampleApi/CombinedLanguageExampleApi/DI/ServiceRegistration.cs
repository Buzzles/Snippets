using Microsoft.Extensions.DependencyInjection;
using CSharpServices;
using FSharpServices;

namespace CombinedLanguageExampleApi.DI
{
    public static class ServiceRegistration
    {
        public static void RegisterCustomServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddSingleton<ICSharpService, ACSharpService>();

            serviceCollection.AddSingleton<IFSharpService, AnFSharpService>();
        }
    }
}
