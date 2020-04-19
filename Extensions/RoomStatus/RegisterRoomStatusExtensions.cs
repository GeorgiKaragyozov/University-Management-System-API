namespace University_Management_System_API.Extensions.RoomStatus
{
    using Microsoft.Extensions.DependencyInjection;
    using University_Management_System_API.Business.Convertor.RoomStatus;
    using University_Management_System_API.Business.Processor.RoomStatus;
    using University_Management_System_API.DataAccess.DataAccessObject.RoomStatus;

    public static class RegisterRoomStatusExtensions
    {
        public static void RegisterDependencies(this IServiceCollection services)
        {
            //------------------- File Json -------------------//
            //services.AddTransient<IRoomStatusStorage, RoomStatusStorage>();
            //services.AddTransient<IRoomStatusDao, RoomStatusDaoFile>();

            //------------------- Entity Framework -------------------//
            services.AddTransient<IRoomStatusDao, RoomStatusDaoEF>();

            services.AddTransient<IRoomStatusParamConverter, RoomStatusParamConverter>();
            services.AddTransient<IRoomStatusResultConverter, RoomStatusResultConverter>();

            services.AddTransient<IRoomStatusProcessor, RoomStatusProcessor>();
        }
    }
}
