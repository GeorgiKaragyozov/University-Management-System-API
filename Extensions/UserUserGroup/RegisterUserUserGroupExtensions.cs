namespace University_Management_System_API.Extensions.UserUserGroup
{
    using Microsoft.Extensions.DependencyInjection;
    using University_Management_System_API.Business.Convertor.UserUserGroup;
    using University_Management_System_API.Business.Processor.UserUserGroup;
    using University_Management_System_API.DataAccess.DataAccessObject.User;
    using University_Management_System_API.DataAccess.DataAccessObject.UserGroup;
    using University_Management_System_API.DataAccess.DataAccessObject.UserUserGroup;

    public static class RegisterUserUserGroupExtensions
    {
        public static void RegisterDependencies(this IServiceCollection services)
        {
            //------------------- File Json -------------------//
            //services.AddTransient<IUserUserGroupStorage, UserUserGroupStorage>();
            //services.AddTransient<IUserUserGroupDao, UserUserGroupDaoFile>();

            //------------------- Entity Framework -------------------//
            services.AddTransient<IUserUserGroupDao, UserUserGroupDaoEF>();

            services.AddTransient<IUserUserGroupParamConverter, UserUserGroupParamConverter>();
            services.AddTransient<IUserUserGroupResultConverter, UserUserGroupResultConverter>();

            services.AddTransient<IUserDao, UserDaoEF>();
            services.AddTransient<IUserGroupDao, UserGroupDaoEF>();

            services.AddTransient<IUserUserGroupProcessor, UserUserGroupProcessor>();
        }
    }
}
