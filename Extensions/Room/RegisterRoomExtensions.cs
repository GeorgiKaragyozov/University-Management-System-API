namespace University_Management_System_API.Extensions.Room
{
    using Microsoft.Extensions.DependencyInjection;
    using University_Management_System_API.Business.Convertor.Room;
    using University_Management_System_API.Business.Processor.Room;
    using University_Management_System_API.DataAccess.DataAccessObject.Room;
    using University_Management_System_API.DataAccess.DataAccessObject.RoomStatus;

    public static class RegisterRoomExtensions
    {
        public static void RegisterDependencies(this IServiceCollection services)
        {
            //------------------- File Json -------------------//
            //services.AddTransient<IRoomStorage, RoomStorage>();
            //services.AddTransient<IRoomDao, RoomDaoFile>();

            //------------------- Entity Framework -------------------//
            services.AddTransient<IRoomDao, RoomDaoEF>();

            services.AddTransient<IRoomParamConverter, RoomParamConverter>();
            services.AddTransient<IRoomResultConverter, RoomResultConverter>();

            services.AddTransient<IRoomStatusDao, RoomStatusDaoEF>();

            services.AddTransient<IRoomProcessor, RoomProcessor>();
        }
    }
}
