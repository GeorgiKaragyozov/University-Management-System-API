namespace University_Management_System_API.Business.Processor.User
{
    using System.Threading.Tasks;
    using University_Management_System_API.Business.Convertor.User;
    using University_Management_System_API.Business.Processor.Common;

    public interface IUserProcessor : IBaseProcessor<UserParam, UserResult, long>
    {
        Task<UserResult> AuthenticateAsync(string usename, string password);
    }
}
