namespace University_Management_System_API.Extensions.AccountType
{
    using Microsoft.Extensions.DependencyInjection;
    using University_Management_System_API.Business.Convertor.AccountType;
    using University_Management_System_API.Business.Processor.AccountType;
    using University_Management_System_API.DataAccess.DataAccessObject.AccountType;

    public static class RegisterAccountTypeExtensions
    {
        public static void RegisterDependencies(this IServiceCollection services)
        {
            //------------------- File Json -------------------//
            //services.AddTransient<IAccountTypeStorage, AccountTypeStorage>();
            //services.AddTransient<IAccountTypeDao, AccountTypeDaoFile>();


            //------------------- Entity Framework -------------------//
            services.AddTransient<IAccountTypeDao, AccountTypeDaoEF>();

            services.AddTransient<IAccountTypeParamConverter, AccountTypeParamConverter>();
            services.AddTransient<IAccountTypeResultConverter, AccountTypeResultConverter>();

            services.AddTransient<IAccountTypeProcessor, AccountTypeProcessor>();
        }
    }
}
