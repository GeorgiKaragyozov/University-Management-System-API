namespace University_Management_System_API.Extensions.Lecture
{
    using Microsoft.Extensions.DependencyInjection;
    using University_Management_System_API.Business.Convertor.Lecture;
    using University_Management_System_API.Business.Processor.Lecture;
    using University_Management_System_API.DataAccess.DataAccessObject.Lecture;
    using University_Management_System_API.DataAccess.DataAccessObject.LectureStatus;
    using University_Management_System_API.DataAccess.DataAccessObject.Room;
    using University_Management_System_API.DataAccess.DataAccessObject.TeacherDiscipline;
    public static class RegisterLectureExtensions
    {
        public static void RegisterDependencies(this IServiceCollection services)
        {
            //------------------- File Json -------------------//
            //services.AddTransient<ILectureStorage, LectureStorage>();
            //services.AddTransient<ILectureDao, LectureDaoFile>();

            //------------------- Entity Framework -------------------//
            services.AddTransient<ILectureDao, LectureDaoEF>();

            services.AddTransient<ILectureParamConverter, LectureParamConverter>();
            services.AddTransient<ILectureResultConverter, LectureResultConverter>();

            services.AddTransient<ILectureStatusDao, LectureStatusDaoEF>();
            services.AddTransient<ITeacherDisciplineDao, TeacherDisciplineDaoEF>();
            services.AddTransient<IRoomDao, RoomDaoEF>();

            services.AddTransient<ILectureProcessor, LectureProcessor>();
        }
    }
}
