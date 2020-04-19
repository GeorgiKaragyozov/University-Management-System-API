namespace University_Management_System_API.Extensions.Account
{
    using Microsoft.Extensions.DependencyInjection;
    using University_Management_System_API.Business.Convertor.Account;
    using University_Management_System_API.Business.Processor.Account;
    using University_Management_System_API.DataAccess.DataAccessObject.Account;
    using University_Management_System_API.DataAccess.DataAccessObject.AccountStatus;
    using University_Management_System_API.DataAccess.DataAccessObject.AccountType;
    using University_Management_System_API.DataAccess.DataAccessObject.Departament;
    using University_Management_System_API.DataAccess.DataAccessObject.Speciality;
    using University_Management_System_API.DataAccess.DataAccessObject.User;

    public static class RegisterAccountExtensions
    {
        public static void RegisterDependencies(this IServiceCollection services)
        {
            //------------------- File Json -------------------//
            //services.AddTransient<IAccountStorage, AccountStorage>();
            //services.AddTransient<IAccountStatusStorage, AccountStatusStorage>();
            //services.AddTransient<IUserStorage, UserStorage>();
            //services.AddTransient<ISpecialityStorage, SpecialityStorage>();
            //services.AddTransient<IDepartamentStorage, DepartamentStorage>();
            //services.AddTransient<IAccountTypeStorage, AccountTypeStorage>();

            //services.AddTransient<IAccountDao, AccountDaoFile>();

            //------------------- Entity Framework -------------------//
            services.AddTransient<IAccountDao, AccountDaoEF>();

            services.AddTransient<IAccountParamConverter, AccountParamConverter>();
            services.AddTransient<IAccountResultConverter, AccountResultConverter>();

            services.AddTransient<IUserDao, UserDaoEF>();
            services.AddTransient<ISpecialityDao, SpecialityDaoEF>();
            services.AddTransient<IDepartamentDao, DepartamentDaoEF>();
            services.AddTransient<IAccountStatusDao, AccountStatusDaoEF>();
            services.AddTransient<IAccountTypeDao, AccountTypeDaoEF>();

            services.AddTransient<IAccountProcessor, AccountProcessor>();
        }
    }
}
