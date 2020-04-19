namespace University_Management_System_API.Extensions.TeacherDiscipline
{
    using Microsoft.Extensions.DependencyInjection;
    using University_Management_System_API.Business.Convertor.TeacherDiscipline;
    using University_Management_System_API.Business.Processor.TeacherDiscipline;
    using University_Management_System_API.DataAccess.DataAccessObject.Account;
    using University_Management_System_API.DataAccess.DataAccessObject.Discipline;
    using University_Management_System_API.DataAccess.DataAccessObject.TeacherDiscipline;
    using University_Management_System_API.DataAccess.DataAccessObject.TeacherDisciplineStatus;

    public static class RegisterTeacherDisciplineExtensions
    {
        public static void RegisterDependencies(this IServiceCollection services)
        {
            //------------------- File Json -------------------//
            //services.AddTransient<ITeacherDisciplineStorage, TeacherDisciplineStorage>();
            //services.AddTransient<ITeacherDisciplineDao, TeacherDisciplineDaoFile>();

            //------------------- Entity Framework -------------------//
            services.AddTransient<ITeacherDisciplineDao, TeacherDisciplineDaoEF>();

            services.AddTransient<ITeacherDisciplineParamConverter, TeacherDisciplineParamConverter>();
            services.AddTransient<ITeacherDisciplineResultConverter, TeacherDisciplineResultConverter>();

            services.AddTransient<ITeacherDisciplineStatusDao, TeacherDisciplineStatusDaoEF>();
            services.AddTransient<IAccountDao, AccountDaoEF>();
            services.AddTransient<IDisciplineDao, DisciplineDaoEF>();

            services.AddTransient<ITeacherDisciplineProcessor, TeacherDisciplineProcessor>();
        }
    }
}
