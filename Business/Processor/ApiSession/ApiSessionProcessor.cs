namespace University_Management_System_API.Business.Processor.ApiSession
{
    using System.Threading.Tasks;
    using University_Management_System_API.Business.Processor.Common;
    using University_Management_System_API.Business.Convertor.ApiSession;
    using University_Management_System_API.DataAccess.DataAccessObject.ApiSession;

    public class ApiSessionProcessor
         : BaseProcessor<IApiSessionParamConverter, IApiSessionResultConverter, ApiSessionParam, ApiSessionResult,
            IApiSessionDao, long, Model.ApiSession>, IApiSessionProcessor
    {
        protected override long GetTPK(ApiSessionParam param)
        {
            return param.Id;
        }

        /// <summary>
        /// Get User's Session by token
        /// </summary>
        /// <param name="authToken">authToken</param>
        /// <returns>session return</returns>
        public async Task<ApiSessionResult> GetByAuthTokenAsync(string authToken)
        {
            ApiSessionResult result = new ApiSessionResult();
            Model.ApiSession entity = await Dao.GetByAuthTokenAsync(authToken);

            result = ResultConverter.ConvertStandart(entity, result);
            return result;
        }

        public ApiSessionProcessor(
           IApiSessionDao dao,
           IApiSessionParamConverter paramConverter,
           IApiSessionResultConverter resultConverter)

           : base(dao, paramConverter, resultConverter)
        {
        }
    }
}
