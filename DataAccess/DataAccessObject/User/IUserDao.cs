namespace University_Management_System_API.DataAccess.DataAccessObject.User
{
    using System.Threading.Tasks;
    using University_Management_System_API.DataAccess.DataAccessObject.Common;

    public interface IUserDao : IBaseDao<Model.User, long>
    {
        Task<Model.User> AuthenticateAsync(Model.User entity);
    }
}
