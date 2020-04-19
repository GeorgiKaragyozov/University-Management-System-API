namespace University_Management_System_API.Extensions.Authentication
{
    using Microsoft.AspNetCore.Authentication;
    using Microsoft.Extensions.DependencyInjection;
    using University_Management_System_API.Authentication.AuthenticationHendler;
    using University_Management_System_API.Authentication.AuthenticationProvider;

    public static class RegisterAuthenticationProviderExtensions
    {
        public static void RegisterDependencies(this IServiceCollection services)
        {
            services.AddScoped<IBaseAuthenticationProvider, BasicAuthenticationProvider>();

            services.AddScoped<IBaseAuthenticationProvider, TokenAuthenticationProvider>();

            services.AddAuthentication("BasicAuthentication")
                .AddScheme<AuthenticationSchemeOptions, BasicAuthenticationHandler>("BasicAuthentication", null);
        }
    }
}
