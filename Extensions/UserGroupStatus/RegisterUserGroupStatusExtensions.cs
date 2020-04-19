namespace University_Management_System_API.Extensions.UserGroupStatus
{
    using Microsoft.Extensions.DependencyInjection;
    using University_Management_System_API.Business.Convertor.UserGroupStatus;
    using University_Management_System_API.Business.Processor.UserGroupStatus;
    using University_Management_System_API.DataAccess.DataAccessObject.UserGroupStatus;

    public static class RegisterUserGroupStatusExtensions
    {
        public static void RegisterDependencies(this IServiceCollection services)
        {
            //------------------- File Json -------------------//
            //services.AddTransient<IUserGroupStatusStorage, UserGroupStatusStorage>();
            //services.AddTransient<IUserGroupStatusDao, UserGroupStatusDaoFile>();

            //------------------- Entity Framework -------------------//
            services.AddTransient<IUserGroupStatusDao, UserGroupStatusDaoEF>();

            services.AddTransient<IUserGroupStatusParamConverter, UserGroupStatusParamConverter>();
            services.AddTransient<IUserGroupStatusResultConverter, UserGroupStatusResultConverter>();

            services.AddTransient<IUserGroupStatusProcessor, UserGroupStatusProcessor>();
        }
    }
}
