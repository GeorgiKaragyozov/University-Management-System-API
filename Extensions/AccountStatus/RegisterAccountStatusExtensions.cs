namespace University_Management_System_API.Extensions.AccountStatus
{
    using Microsoft.Extensions.DependencyInjection;
    using University_Management_System_API.Business.Convertor.AccountStatus;
    using University_Management_System_API.Business.Processor.AccountStatus;
    using University_Management_System_API.DataAccess.DataAccessObject.AccountStatus;

    public static class RegisterAccountStatusExtensions
    {
        public static void RegisterDependencies(this IServiceCollection services)
        {
            //------------------- File Json -------------------//
            //services.AddTransient<IAccountStatusStorage, AccountStatusStorage>();
            //services.AddTransient<IAccountStatusDao, AccountStatusDaoFile>();


            //------------------- Entity Framework -------------------//
            services.AddTransient<IAccountStatusDao, AccountStatusDaoEF>();

            services.AddTransient<IAccountStatusParamConverter, AccountStatusParamConverter>();
            services.AddTransient<IAccountStatusResultConverter, AccountStatusResultConverter>();

            services.AddTransient<IAccountStatusProcessor, AccountStatusProcessor>();
        }
    }
}
