namespace University_Management_System_API.Business.Convertor.User
{
    using System.Text;
    using Microsoft.Extensions.Options;
    using University_Management_System_API.Authentication.Common;
    using University_Management_System_API.Business.Convertor.Common;
    using University_Management_System_API.DataAccess.DataAccessObject.UserStatus;

    public class UserParamConverter : BaseParamConverter<UserParam, Model.User>, IUserParamConverter
    {
        private IUserStatusDao _statusDao;
        public IUserStatusDao StatusDao
        {
            get { return _statusDao; }
            set { _statusDao = value; }
        }


        private IOptions<SecretKeySettings> _options;
        public IOptions<SecretKeySettings> Options
        {
            get { return _options; }
            set { _options = value; }
        }

        public UserParamConverter(IUserStatusDao statusDao, IOptions<SecretKeySettings> options)
        {
            this.Options = options;
            this.StatusDao = statusDao;
        }

        public override Model.User GetEntity(UserParam param)
        {
            return new Model.User
            {
                Id = param.Id,
            };
        }

        public override void ConvertSpecific(UserParam param, Model.User entity)
        {
            entity.Status = StatusDao.Find(param.StatusId);

            entity = HashPassword(entity);
    
        }

        public Model.User HashPassword(Model.User entity)
        {
            //get secret value
            var secret = this.Options.Value.Secret;
            //to byte secret value
            var key = Encoding.UTF8.GetBytes(secret);

            entity.Password = HashPlainText.GenerateHash(entity.Password, key);
            return entity;
        }
    }
}
