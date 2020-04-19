namespace University_Management_System_API.Extensions.User
{
    using Microsoft.Extensions.DependencyInjection;
    using University_Management_System_API.Business.Convertor.User;
    using University_Management_System_API.Business.Processor.User;
    using University_Management_System_API.DataAccess.DataAccessObject.User;
    using University_Management_System_API.DataAccess.DataAccessObject.UserStatus;

    public static class RegisterUserExtensions
    {
        public static void RegisterDependencies(this IServiceCollection services)
        {
            //------------------- File Json -------------------//
            //services.AddTransient<IUserStorage, UserStorage>();
            //services.AddTransient<IUserDao, UserDaoFile>();

            //------------------- Entity Framework -------------------//
            services.AddTransient<IUserDao, UserDaoEF>();

            services.AddTransient<IUserParamConverter, UserParamConverter>();
            services.AddTransient<IUserResultConverter, UserResultConverter>();
            
            services.AddTransient<IUserStatusDao, UserStatusDaoEF>();

            services.AddTransient<IUserProcessor, UserProcessor>();
        }
    }
}
