namespace University_Management_System_API.DataAccess.DataAccessObject.ApiSession
{
    using System.Linq;
    using System.Threading.Tasks;
    using University_Management_System_API.DataAccess.DataAccessObject.Common;

    public class ApiSessionDaoEF : BaseDaoEF<Model.ApiSession, long>, IApiSessionDao
    {
        public ApiSessionDaoEF(UniversityManagementSystemContext context)
            : base(context)
        {
        }

        /// <summary>
        /// Checks in the database for authToken
        /// </summary>
        /// <param name="authToken">authToken</param>
        /// <returns>session</returns>
        public async Task<Model.ApiSession> GetByAuthTokenAsync(string authToken)
        {
            Model.ApiSession entity = await Task.Run(() =>
               _dbContext.ApiSessions.SingleOrDefault(
                e => e.AuthToken == authToken));

            return entity;
        }
    }
}
