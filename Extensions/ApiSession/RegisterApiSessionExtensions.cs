namespace University_Management_System_API.Extensions.ApiSession
{
    using Microsoft.Extensions.DependencyInjection;
    using University_Management_System_API.Business.Convertor.ApiSession;
    using University_Management_System_API.Business.Processor.ApiSession;
    using University_Management_System_API.DataAccess.DataAccessObject.ApiSession;

    public static class RegisterApiSessionExtensions
    {
        public static void RegisterDependencies(this IServiceCollection services)
        {
            //------------------- File Json -------------------//
            //services.AddTransient<IApiSessionStorage, ApiSessionStorage>();
            //services.AddTransient<IApiSessionDao, ApiSessionDaoFile>();


            //------------------- Entity Framework -------------------//
            services.AddTransient<IApiSessionDao, ApiSessionDaoEF>();

            services.AddTransient<IApiSessionParamConverter, ApiSessionParamConverter>();
            services.AddTransient<IApiSessionResultConverter, ApiSessionResultConverter>();

            services.AddTransient<IApiSessionProcessor, ApiSessionProcessor>();
        }
    }
}
