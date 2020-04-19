namespace University_Management_System_API.Extensions.TeacherDisciplineStatus
{
    using Microsoft.Extensions.DependencyInjection;
    using University_Management_System_API.Business.Convertor.TeacherDisciplineStatus;
    using University_Management_System_API.Business.Processor.TeacherDisciplineStatus;
    using University_Management_System_API.DataAccess.DataAccessObject.TeacherDisciplineStatus;

    public static class RegisterTeacherDisciplineStatusExtensions
    {
        public static void RegisterDependencies(this IServiceCollection services)
        {
            //------------------- File Json -------------------//
            //services.AddTransient<ITeacherDisciplineStatusStorage, TeacherDisciplineStatusStorage>();
            //services.AddTransient<ITeacherDisciplineStatusDao, TeacherDisciplineStatusDaoFile>();

            //------------------- Entity Framework -------------------//
            services.AddTransient<ITeacherDisciplineStatusDao, TeacherDisciplineStatusDaoEF>();

            services.AddTransient<ITeacherDisciplineStatusParamConverter, TeacherDisciplineStatusParamConverter>();
            services.AddTransient<ITeacherDisciplineStatusResultConverter, TeacherDisciplineStatusResultConverter>();

            services.AddTransient<ITeacherDisciplineStatusProcessor, TeacherDisciplineStatusProcessor>();
        }
    }
}
