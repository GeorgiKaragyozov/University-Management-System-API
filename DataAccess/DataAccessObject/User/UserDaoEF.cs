namespace University_Management_System_API.DataAccess.DataAccessObject.User
{
    using System.Linq;
    using System.Threading.Tasks;
    using University_Management_System_API.DataAccess.DataAccessObject.Common;

    public class UserDaoEF : BaseDaoEF<Model.User, long>, IUserDao
    {
        public UserDaoEF(UniversityManagementSystemContext context)
            : base(context)
        {
        }

        /// <summary>
        /// Checks in the database if there is a user with that username and password
        /// </summary>
        /// <param name="entity">user</param>
        /// <returns>user data</returns>
        public async Task<Model.User> AuthenticateAsync(Model.User entity)
        {
            Model.User user = await Task.Run(() => _dbContext.Users.SingleOrDefault(
                e => e.Username == entity.Username &&
                e.Password == entity.Password));

            return user;
        }
    }
}
