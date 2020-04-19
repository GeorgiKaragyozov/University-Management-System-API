namespace University_Management_System_API.Business.Processor.User
{
    using System.Threading.Tasks;
    using University_Management_System_API.Business.Convertor.User;
    using University_Management_System_API.Business.Processor.Common;
    using University_Management_System_API.DataAccess.DataAccessObject.User;

    public class UserProcessor
        : BaseProcessor<IUserParamConverter, IUserResultConverter, UserParam, UserResult, IUserDao, long,
            Model.User>, IUserProcessor
    {
        protected override long GetTPK(UserParam param)
        {
            return param.Id;
        }

        public UserProcessor(
            IUserDao dao,
            IUserParamConverter paramConverter,
            IUserResultConverter resultConverter)

            : base(dao, paramConverter, resultConverter)
        {
        }

        /// <summary>
        /// hashes the password and sends the request to DAO
        /// </summary>
        /// <param name="username">username</param>
        /// <param name="password">password</param>
        /// <returns>user result</returns>
        public async Task<UserResult> AuthenticateAsync(string username, string password)
        {
            Model.User entity = new Model.User()
            {
                Username = username,
                Password = password
            };

            entity = ParamConverter.HashPassword(entity);

            entity = await Dao.AuthenticateAsync(entity);

            UserResult result = ResultConverter.Convert(entity);

            return result;
        }           
    }
}
