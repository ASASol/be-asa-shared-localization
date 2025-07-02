using be_asa_shared_localization.Localization;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace be_asa_shared_localization.Extensions
{
    public static class LocalizationServiceCollectionExtensions
    {
        public static IServiceCollection AddAsaJsonLocalization(this IServiceCollection services)
        {
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddSingleton<IJsonLocalizationService, JsonLocalizationService>();
            return services;
        }
    }
}
