namespace University_Management_System_API.DataAccess.DataAccessObject.ApiSession
{
    using System.Linq;
    using System.Threading.Tasks;
    using University_Management_System_API.DataAccess.DataAccessObject.Common;

    public class ApiSessionDaoFile : BaseDaoFile<Model.ApiSession, long, IApiSessionStorage>, IApiSessionDao
    {
        public ApiSessionDaoFile(IApiSessionStorage storage)
            : base(storage)
        {
        }

        protected override long GetPK(Model.ApiSession entity)
        {
            return entity.Id;
        }

        /// <summary>
        ///  Checks in the Json file for authToken
        /// </summary>
        /// <param name="authToken">authToken</param>
        /// <returns>session</returns>
        public async Task<Model.ApiSession> GetByAuthTokenAsync(string authToken)
        {
            Model.ApiSession entity = await Task.Run(() =>
               DataStorage.ReturnDictionary().SingleOrDefault(
                e => e.Value.AuthToken == authToken).Value);

            return entity;
        }
    }
}
