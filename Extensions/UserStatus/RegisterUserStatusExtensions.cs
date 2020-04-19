namespace University_Management_System_API.Extensions.UserStatus
{
    using Microsoft.Extensions.DependencyInjection;
    using University_Management_System_API.Business.Convertor.UserStatus;
    using University_Management_System_API.Business.Processor.UserStatus;
    using University_Management_System_API.DataAccess.DataAccessObject.UserStatus;

    public static class RegisterUserStatusExtensions
    {
        public static void RegisterDependencies(this IServiceCollection services)
        {
            //------------------- File Json -------------------//
            //services.AddTransient<IUserStatusStorage, UserStatusStorage>();
            //services.AddTransient<IUserStatusDao, UserStatusDaoFile>();

            //------------------- Entity Framework -------------------//
            //services.AddTransient<IUserStatusDao, UserStatusDaoEF>();

            services.AddTransient<IUserStatusParamConverter, UserStatusParamConverter>();
            services.AddTransient<IUserStatusResultConverter, UserStatusResultConverter>();

            services.AddTransient<IUserStatusProcessor, UserStatusProcessor>();
        }
    }
}
