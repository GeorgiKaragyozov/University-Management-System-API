namespace University_Management_System_API.DataAccess.DataAccessObject.User
{
    using System.Linq;
    using System.Threading.Tasks;
    using University_Management_System_API.DataAccess.DataAccessObject.Common;

    public class UserDaoFile : BaseDaoFile<Model.User, long, IUserStorage>, IUserDao
    {
        protected override long GetPK(Model.User entity)
        {
            return entity.Id;
        }

        public UserDaoFile(IUserStorage storage)
         : base(storage)
        {
        }

        /// <summary>
        /// Checks in the Json file if there is a user with that username and password
        /// </summary>
        /// <param name="entity">user</param>
        /// <returns>user data</returns>
        public async Task<Model.User> AuthenticateAsync(Model.User entity)
        {
            Model.User user = await Task.Run(() => DataStorage
                    .ReturnDictionary().SingleOrDefault(
                       e => e.Value.Username == entity.Username &&
                       e.Value.Password == entity.Password).Value);

            return user;
        }    
    }
}
