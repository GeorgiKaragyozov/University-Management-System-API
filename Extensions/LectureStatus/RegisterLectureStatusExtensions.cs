namespace University_Management_System_API.Extensions.LectureStatus
{
    using Microsoft.Extensions.DependencyInjection;
    using University_Management_System_API.Business.Convertor.LectureStatus;
    using University_Management_System_API.Business.Processor.LectureStatus;
    using University_Management_System_API.DataAccess.DataAccessObject.LectureStatus;

    public static class RegisterLectureStatusExtensions
    {
        public static void RegisterDependencies(this IServiceCollection services)
        {
            //------------------- File Json -------------------//
            //services.AddTransient<ILectureStatusStorage, LectureStatusStorage>();
            //services.AddTransient<ILectureStatusDao, LectureStatusDaoFile>();

            //------------------- Entity Framework -------------------//
            services.AddTransient<ILectureStatusDao, LectureStatusDaoEF>();

            services.AddTransient<ILectureStatusParamConverter, LectureStatusParamConverter>();
            services.AddTransient<ILectureStatusResultConverter, LectureStatusResultConverter>();

            services.AddTransient<ILectureStatusProcessor, LectureStatusProcessor>();
        }
    }
}
