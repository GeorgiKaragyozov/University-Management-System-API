namespace University_Management_System_API.DataAccess.DataAccessObject.ApiSession
{
    using System.Threading.Tasks;
    using University_Management_System_API.DataAccess.DataAccessObject.Common;

    public interface IApiSessionDao : IBaseDao<Model.ApiSession, long>
    {
        Task<Model.ApiSession> GetByAuthTokenAsync(string authToken);
    }
}
