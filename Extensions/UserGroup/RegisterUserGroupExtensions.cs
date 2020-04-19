namespace University_Management_System_API.Extensions.UserGroup
{
    using Microsoft.Extensions.DependencyInjection;
    using University_Management_System_API.Business.Convertor.UserGroup;
    using University_Management_System_API.Business.Processor.UserGroup;
    using University_Management_System_API.DataAccess.DataAccessObject.UserGroup;
    using University_Management_System_API.DataAccess.DataAccessObject.UserGroupStatus;

    public static class RegisterUserGroupExtensions
    {
        public static void RegisterDependencies(this IServiceCollection services)
        {
            //------------------- File Json -------------------//
            //services.AddTransient<IUserGroupStorage, UserGroupStorage>();
            //services.AddTransient<IUserGroupDao, UserGroupDaoFile>();

            //------------------- Entity Framework -------------------//
            services.AddTransient<IUserGroupDao, UserGroupDaoEF>();

            services.AddTransient<IUserGroupParamConverter, UserGroupParamConverter>();
            services.AddTransient<IUserGroupResultConverter, UserGroupResultConverter>();

            services.AddTransient<IUserGroupStatusDao, UserGroupStatusDaoEF>();

            services.AddTransient<IUserGroupProcessor, UserGroupProcessor>();
        }
    }
}
